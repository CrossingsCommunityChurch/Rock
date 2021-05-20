using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Reflection;

using Nest;

using Newtonsoft.Json.Linq;

using Rock.Attribute;
using Rock.Data;
using Rock.Model;
using Rock.UniversalSearch.IndexModels;
using Rock.UniversalSearch.IndexModels.Attributes;
using Rock.Web.Cache;
using Rock.UniversalSearch;
using Algolia.Search;
using Algolia.Search.Clients;

namespace Crossings.UniversalSearch
{
    /// <summary>
    /// Algolia Search index provider
    /// </summary>
    /// <seealso cref="Rock.UniversalSearch.IndexComponent"/>
    [Description("Algolia universal search index")]
    [Export( typeof(IndexComponent))]
    [ExportMetadata("ComponentName", "AlgoliaSearch")]

    [TextField("Application ID", "The Application ID in the Algolia Account ", true, key: "AppID")]
    [TextField("API Key", "The API Key from your Algolia Account", true, key: "APIKey")]
    class AlgoliaSearch : IndexComponent
    {
        /// <summary
        /// The Client
        /// </summary>
        protected SearchClient _client;

        /// <summary>
        /// Gets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        public override bool IsConnected
        {
            get
            {
                if( _client == null)
                {
                    ConnectToServer();
                    if( _client == null)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public SearchClient Client
        {
            get
            {
                return _client;
            }
        }

        /// <summary>
        /// Gets the index location. Unsure how this works currently.
        /// </summary>
        /// <value>
        /// The index location.
        /// </value>
        public override string IndexLocation
        {
            get
            {
                return GetAttributeValue("AppID");
            }
        }

        ///<summary>
        /// Initializes a new instance of the Algolia class
        /// </summary>
        public AlgoliaSearch()
        {
            ConnectToServer();
        }

        /// <summary>
        /// Method that is called when attribute values are updated. Components can
        /// override this to perform any needed setup/validation based on current attribute
        /// values.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <returns></returns>
        public override bool ValidateAttributeValues(out string errorMessage)
        {
            // reset the connection when the component settings are changed
            ConnectToServer();

            return base.ValidateAttributeValues(out errorMessage);
        }

        /// <summary>
        /// Connects to server.
        /// </summary>
        protected virtual void ConnectToServer()
        {
            if (!string.IsNullOrWhiteSpace(GetAttributeValue("AppID")) && !string.IsNullOrWhiteSpace(GetAttributeValue("APIKey")))
            {
                try
                {
                    var appID = GetAttributeValue("AppID");
                    var apiKey = GetAttributeValue("APIKey");
                    _client = new SearchClient(appID, apiKey);
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Indexes the document.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="document">The document.</param>
        /// <param name="indexName">Name of the index.</param>
        /// <param name="mappingType">Type of the mapping.</param>
        public override void IndexDocument<T>( T document, string indexName = null, string mappingType = null )
        {
            if ( indexName == null )
            {
                indexName = document.GetType().Name.ToLower();
            }

            SearchIndex index = _client.InitIndex(indexName);

            index.SaveObjectAsync<T>(document, autoGenerateObjectId: true);

        }

        /// <summary>
        /// Deletes the type of the documents by.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="indexName">Name of the index.</param>
        public override void DeleteDocumentsByType<T>( string indexName = null )
        {
            if ( indexName == null )
            {
                indexName = typeof( T ).Name.ToLower();
            }


            SearchIndex index = _client.InitIndex(indexName);
            index.DeleteByAsync
            _client.DeleteByQueryAsync<T>( indexName, typeof( T ).Name.ToLower(), d => d.MatchAll() );
        }

    }
}
