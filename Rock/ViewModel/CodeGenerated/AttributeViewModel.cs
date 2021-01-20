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
    /// Attribute View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.Attribute ) )]
    public partial class AttributeViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the AbbreviatedName.
        /// </summary>
        /// <value>
        /// The AbbreviatedName.
        /// </value>
        public string AbbreviatedName { get; set; }

        /// <summary>
        /// Gets or sets the AllowSearch.
        /// </summary>
        /// <value>
        /// The AllowSearch.
        /// </value>
        public bool AllowSearch { get; set; }

        /// <summary>
        /// Gets or sets the DefaultValue.
        /// </summary>
        /// <value>
        /// The DefaultValue.
        /// </value>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the EnableHistory.
        /// </summary>
        /// <value>
        /// The EnableHistory.
        /// </value>
        public bool EnableHistory { get; set; }

        /// <summary>
        /// Gets or sets the EntityTypeId.
        /// </summary>
        /// <value>
        /// The EntityTypeId.
        /// </value>
        public int? EntityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the EntityTypeQualifierColumn.
        /// </summary>
        /// <value>
        /// The EntityTypeQualifierColumn.
        /// </value>
        public string EntityTypeQualifierColumn { get; set; }

        /// <summary>
        /// Gets or sets the EntityTypeQualifierValue.
        /// </summary>
        /// <value>
        /// The EntityTypeQualifierValue.
        /// </value>
        public string EntityTypeQualifierValue { get; set; }

        /// <summary>
        /// Gets or sets the FieldTypeId.
        /// </summary>
        /// <value>
        /// The FieldTypeId.
        /// </value>
        public int FieldTypeId { get; set; }

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
        /// Gets or sets the IconCssClass.
        /// </summary>
        /// <value>
        /// The IconCssClass.
        /// </value>
        public string IconCssClass { get; set; }

        /// <summary>
        /// Gets or sets the IsActive.
        /// </summary>
        /// <value>
        /// The IsActive.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the IsAnalytic.
        /// </summary>
        /// <value>
        /// The IsAnalytic.
        /// </value>
        public bool IsAnalytic { get; set; }

        /// <summary>
        /// Gets or sets the IsAnalyticHistory.
        /// </summary>
        /// <value>
        /// The IsAnalyticHistory.
        /// </value>
        public bool IsAnalyticHistory { get; set; }

        /// <summary>
        /// Gets or sets the IsGridColumn.
        /// </summary>
        /// <value>
        /// The IsGridColumn.
        /// </value>
        public bool IsGridColumn { get; set; }

        /// <summary>
        /// Gets or sets the IsIndexEnabled.
        /// </summary>
        /// <value>
        /// The IsIndexEnabled.
        /// </value>
        public bool IsIndexEnabled { get; set; }

        /// <summary>
        /// Gets or sets the IsMultiValue.
        /// </summary>
        /// <value>
        /// The IsMultiValue.
        /// </value>
        public bool IsMultiValue { get; set; }

        /// <summary>
        /// Gets or sets the IsPublic.
        /// </summary>
        /// <value>
        /// The IsPublic.
        /// </value>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Gets or sets the IsRequired.
        /// </summary>
        /// <value>
        /// The IsRequired.
        /// </value>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the IsSystem.
        /// </summary>
        /// <value>
        /// The IsSystem.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the Key.
        /// </summary>
        /// <value>
        /// The Key.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        /// <value>
        /// The Order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the PostHtml.
        /// </summary>
        /// <value>
        /// The PostHtml.
        /// </value>
        public string PostHtml { get; set; }

        /// <summary>
        /// Gets or sets the PreHtml.
        /// </summary>
        /// <value>
        /// The PreHtml.
        /// </value>
        public string PreHtml { get; set; }

        /// <summary>
        /// Gets or sets the ShowOnBulk.
        /// </summary>
        /// <value>
        /// The ShowOnBulk.
        /// </value>
        public bool ShowOnBulk { get; set; }

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