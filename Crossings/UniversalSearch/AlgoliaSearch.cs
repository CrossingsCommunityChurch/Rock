using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;



using Rock.Attribute;
using Rock.Data;
using Rock.Model;
using Rock.UniversalSearch.IndexModels;
using Rock.UniversalSearch.IndexModels.Attributes;
using Rock.Web.Cache;
using Rock.UniversalSearch;
using Algolia.Search;
using Algolia.Search.Clients;
using Algolia.Search.Models.Search;

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
            // Want to add objectId for Algolia to this as document.Id
            SearchIndex index = _client.InitIndex(indexName);

            index.SaveObjectAsync<T>(document, autoGenerateObjectId: true);

        }

        /// <summary>
        /// Searches the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="searchType">Type of the search.</param>
        /// <param name="entities">The entities.</param>
        /// <param name="fieldCriteria">The field criteria.</param>
        /// <param name="size">The size.</param>
        /// <param name="from">From.</param>
        /// <param name="totalResultsAvailable">The total results available.</param>
        /// <returns></returns>
        public override List<IndexModelBase> Search(string query, SearchType searchType, List<int> entities, SearchFieldCriteria fieldCriteria, int? size, int? from, out long totalResultsAvailable)
        {
            List<IndexModelBase> documents = null;
            totalResultsAvailable = 0;
            return documents;
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
            index.ClearObjectsAsync();
            //EClient.DeleteByQueryAsync<T>( indexName, typeof( T ).Name.ToLower(), d => d.MatchAll() );
        }

        /// <summary>
        /// Deletes the document.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="document">The document.</param>
        /// <param name="indexName">Name of the index.</param>
        public override void DeleteDocument<T>(T document, string indexName = null)
        {
            if (indexName == null)
            {
                indexName = document.GetType().Name.ToLower();
            }
            SearchIndex index = _client.InitIndex(indexName);
            var query = new Query { Filters = $"id:{document}" };
            //EClient.Delete<T>(document, d => d.Index(indexName));
        }

        /// <summary>
        /// Creates the index.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        /// <param name="deleteIfExists">if set to <c>true</c> [delete if exists].</param>
        public override void CreateIndex(Type documentType, bool deleteIfExists = true)
        {
            var indexName = documentType.Name.ToLower();

            object instance = Activator.CreateInstance(documentType);

            // check if index already exists
            SearchIndex index = _client.InitIndex(indexName);
            var existsResponse = index.Exists();

            if (existsResponse)
            {
                // If Index exists check value and possibly delete.
                if (deleteIfExists)
                {
                    //Algolia can clear the index (this could get 
                    this.DeleteIndex(documentType);
                }
                else
                {
                    return;
                }
            }
            // For Algolia the model does not matter the documents do not need to be formatted.

        }

        /// <summary>
        /// Deletes the index.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        public override void DeleteIndex(Type documentType)
        {
            var indexName = documentType.Name.ToLower();
            SearchIndex index = _client.InitIndex(indexName);
            index.ClearObjectsAsync();
        }

        /// <summary>
        /// Searches the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="searchType">Type of the search.</param>
        /// <param name="entities">The entities.</param>
        /// <param name="fieldCriteria">The field criteria.</param>
        /// <param name="size">The size.</param>
        /// <param name="from">From.</param>
        /// <returns></returns>
        public override List<IndexModelBase> Search(string query, SearchType searchType = SearchType.Wildcard, List<int> entities = null, SearchFieldCriteria fieldCriteria = null, int? size = null, int? from = null)
        {
            long totalResultsAvailable = 0;
            return Search(query, searchType, entities, fieldCriteria, size, from, out totalResultsAvailable);
        }



        /// <summary>
        /// Called at the start of a crawl will clean the whole index.
        /// May need to modify to lower cost.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyValue">The property value.</param>
        public override void DeleteDocumentByProperty(Type documentType, string propertyName, object propertyValue)
        {
            var indexName = documentType.Name.ToLower();
            SearchIndex index = _client.InitIndex(indexName);
            index.ClearObjectsAsync();
        }

        /// <summary>
        /// Deletes the document by identifier.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        /// <param name="id">The identifier.</param>
        public override void DeleteDocumentById(Type documentType, int id)
        {
            this.DeleteDocumentByProperty(documentType, "id", id);
        }

        /// <summary>
        /// Gets the document by identifier.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public override IndexModelBase GetDocumentById(Type documentType, int id)
        {
            return GetDocumentById(documentType, id.ToString());
        }

        /// <summary>
        /// Gets the document by identifier.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public override IndexModelBase GetDocumentById(Type documentType, string id)
        {
            var indexName = documentType.Name.ToLower();

            //var request = new GetRequest(indexName, indexName, id) { };

            var result = true;

            IndexModelBase document = new IndexModelBase();

            return document;
        }

    }
}
