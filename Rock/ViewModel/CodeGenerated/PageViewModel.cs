//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

using System;

namespace Rock.ViewModel
{
    /// <summary>
    /// Page View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.Page ) )]
    public partial class PageViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the AdditionalSettings.
        /// </summary>
        /// <value>
        /// The AdditionalSettings.
        /// </value>
        public string AdditionalSettings { get; set; }

        /// <summary>
        /// Gets or sets the AllowIndexing.
        /// </summary>
        /// <value>
        /// The AllowIndexing.
        /// </value>
        public bool AllowIndexing { get; set; }

        /// <summary>
        /// Gets or sets the BodyCssClass.
        /// </summary>
        /// <value>
        /// The BodyCssClass.
        /// </value>
        public string BodyCssClass { get; set; }

        /// <summary>
        /// Gets or sets the BreadCrumbDisplayIcon.
        /// </summary>
        /// <value>
        /// The BreadCrumbDisplayIcon.
        /// </value>
        public bool BreadCrumbDisplayIcon { get; set; }

        /// <summary>
        /// Gets or sets the BreadCrumbDisplayName.
        /// </summary>
        /// <value>
        /// The BreadCrumbDisplayName.
        /// </value>
        public bool BreadCrumbDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the BrowserTitle.
        /// </summary>
        /// <value>
        /// The BrowserTitle.
        /// </value>
        public string BrowserTitle { get; set; }

        /// <summary>
        /// Gets or sets the CacheControlHeaderSettings.
        /// </summary>
        /// <value>
        /// The CacheControlHeaderSettings.
        /// </value>
        public string CacheControlHeaderSettings { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the DisplayInNavWhen.
        /// </summary>
        /// <value>
        /// The DisplayInNavWhen.
        /// </value>
        public int DisplayInNavWhen { get; set; }

        /// <summary>
        /// Gets or sets the EnableViewState.
        /// </summary>
        /// <value>
        /// The EnableViewState.
        /// </value>
        public bool EnableViewState { get; set; }

        /// <summary>
        /// Gets or sets the ForeignGuid.
        /// </summary>
        /// <value>
        /// The ForeignGuid.
        /// </value>
        public Guid? ForeignGuid { get; set; }

        /// <summary>
        /// Gets or sets the ForeignKey.
        /// </summary>
        /// <value>
        /// The ForeignKey.
        /// </value>
        public string ForeignKey { get; set; }

        /// <summary>
        /// Gets or sets the HeaderContent.
        /// </summary>
        /// <value>
        /// The HeaderContent.
        /// </value>
        public string HeaderContent { get; set; }

        /// <summary>
        /// Gets or sets the IconBinaryFileId.
        /// </summary>
        /// <value>
        /// The IconBinaryFileId.
        /// </value>
        public int? IconBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the IconCssClass.
        /// </summary>
        /// <value>
        /// The IconCssClass.
        /// </value>
        public string IconCssClass { get; set; }

        /// <summary>
        /// Gets or sets the IncludeAdminFooter.
        /// </summary>
        /// <value>
        /// The IncludeAdminFooter.
        /// </value>
        public bool IncludeAdminFooter { get; set; }

        /// <summary>
        /// Gets or sets the InternalName.
        /// </summary>
        /// <value>
        /// The InternalName.
        /// </value>
        public string InternalName { get; set; }

        /// <summary>
        /// Gets or sets the IsSystem.
        /// </summary>
        /// <value>
        /// The IsSystem.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the KeyWords.
        /// </summary>
        /// <value>
        /// The KeyWords.
        /// </value>
        public string KeyWords { get; set; }

        /// <summary>
        /// Gets or sets the LayoutId.
        /// </summary>
        /// <value>
        /// The LayoutId.
        /// </value>
        public int LayoutId { get; set; }

        /// <summary>
        /// Gets or sets the MedianPageLoadTimeDurationSeconds.
        /// </summary>
        /// <value>
        /// The MedianPageLoadTimeDurationSeconds.
        /// </value>
        public double? MedianPageLoadTimeDurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets the MenuDisplayChildPages.
        /// </summary>
        /// <value>
        /// The MenuDisplayChildPages.
        /// </value>
        public bool MenuDisplayChildPages { get; set; }

        /// <summary>
        /// Gets or sets the MenuDisplayDescription.
        /// </summary>
        /// <value>
        /// The MenuDisplayDescription.
        /// </value>
        public bool MenuDisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets the MenuDisplayIcon.
        /// </summary>
        /// <value>
        /// The MenuDisplayIcon.
        /// </value>
        public bool MenuDisplayIcon { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        /// <value>
        /// The Order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the PageDisplayBreadCrumb.
        /// </summary>
        /// <value>
        /// The PageDisplayBreadCrumb.
        /// </value>
        public bool PageDisplayBreadCrumb { get; set; }

        /// <summary>
        /// Gets or sets the PageDisplayDescription.
        /// </summary>
        /// <value>
        /// The PageDisplayDescription.
        /// </value>
        public bool PageDisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets the PageDisplayIcon.
        /// </summary>
        /// <value>
        /// The PageDisplayIcon.
        /// </value>
        public bool PageDisplayIcon { get; set; }

        /// <summary>
        /// Gets or sets the PageDisplayTitle.
        /// </summary>
        /// <value>
        /// The PageDisplayTitle.
        /// </value>
        public bool PageDisplayTitle { get; set; }

        /// <summary>
        /// Gets or sets the PageTitle.
        /// </summary>
        /// <value>
        /// The PageTitle.
        /// </value>
        public string PageTitle { get; set; }

        /// <summary>
        /// Gets or sets the ParentPageId.
        /// </summary>
        /// <value>
        /// The ParentPageId.
        /// </value>
        public int? ParentPageId { get; set; }

        /// <summary>
        /// Gets or sets the RequiresEncryption.
        /// </summary>
        /// <value>
        /// The RequiresEncryption.
        /// </value>
        public bool RequiresEncryption { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDateTime.
        /// </summary>
        /// <value>
        /// The CreatedDateTime.
        /// </value>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedDateTime.
        /// </summary>
        /// <value>
        /// The ModifiedDateTime.
        /// </value>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the CreatedByPersonAliasId.
        /// </summary>
        /// <value>
        /// The CreatedByPersonAliasId.
        /// </value>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedByPersonAliasId.
        /// </summary>
        /// <value>
        /// The ModifiedByPersonAliasId.
        /// </value>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the ForeignId.
        /// </summary>
        /// <value>
        /// The ForeignId.
        /// </value>
        public int? ForeignId { get; set; }

    }
}