using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Model;
using Rock.UniversalSearch.IndexModels;
using Rock.UniversalSearch.IndexModels.Attributes;

namespace Crossings.UniversalSearch
{
    class CccSitePageIndex : IndexModelBase
    {
        /// <summary>
        /// Gets or sets the site identifier.
        /// </summary>
        /// <value>
        /// The site identifier.
        /// </value>
        [RockIndexField]
        public int SiteId { get; set; }

        /// <summary>
        /// Gets or sets the name of the site.
        /// </summary>
        /// <value>
        /// The name of the site.
        /// </value>
        [RockIndexField]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets the page title.
        /// </summary>
        /// <value>
        /// The page title.
        /// </value>
        [RockIndexField(Boost = 4)]
        public string PageTitle { get; set; }

        /// <summary>
        /// Gets or sets the page summary.
        /// </summary>
        /// <value>
        /// The page summary.
        /// </value>
        [RockIndexField(Boost = 2)]
        public string PageSummary { get; set; }

        /// <summary>
        /// Gets or sets the page keywords.
        /// </summary>
        /// <value>
        /// The page keywords.
        /// </value>
        [RockIndexField(Boost = 8)]
        public string PageKeywords { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [RockIndexField(Index = IndexType.NotIndexed)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [RockIndexField]
        public string Content { get; set; }

        /// <summary>
        /// gets or sets the tags. 
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// Gets or sets the last indexed date time.
        /// </summary>
        /// <value>
        /// The last indexed date time.
        /// </value>
        [RockIndexField(Type = IndexFieldType.Date)]
        public DateTime LastIndexedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the icon CSS class.
        /// </summary>
        /// <value>
        /// The icon CSS class.
        /// </value>
        [RockIndexField(Index = IndexType.NotIndexed)]
        public override string IconCssClass
        {
            get
            {
                return "fa fa-desktop";
            }
        }

        /// <summary>
        /// Loads the by model.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns></returns>
        public static SitePageIndex LoadByModel(Site site)
        {
            // site page does not have a Rock model
            return null;
        }
    }
}
