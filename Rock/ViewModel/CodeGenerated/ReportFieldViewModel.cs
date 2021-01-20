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
    /// ReportField View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.ReportField ) )]
    public partial class ReportFieldViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the ColumnHeaderText.
        /// </summary>
        /// <value>
        /// The ColumnHeaderText.
        /// </value>
        public string ColumnHeaderText { get; set; }

        /// <summary>
        /// Gets or sets the ColumnOrder.
        /// </summary>
        /// <value>
        /// The ColumnOrder.
        /// </value>
        public int ColumnOrder { get; set; }

        /// <summary>
        /// Gets or sets the DataSelectComponentEntityTypeId.
        /// </summary>
        /// <value>
        /// The DataSelectComponentEntityTypeId.
        /// </value>
        public int? DataSelectComponentEntityTypeId { get; set; }

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
        /// Gets or sets the IsCommunicationMergeField.
        /// </summary>
        /// <value>
        /// The IsCommunicationMergeField.
        /// </value>
        public bool? IsCommunicationMergeField { get; set; }

        /// <summary>
        /// Gets or sets the IsCommunicationRecipientField.
        /// </summary>
        /// <value>
        /// The IsCommunicationRecipientField.
        /// </value>
        public bool? IsCommunicationRecipientField { get; set; }

        /// <summary>
        /// Gets or sets the ReportFieldType.
        /// </summary>
        /// <value>
        /// The ReportFieldType.
        /// </value>
        public int ReportFieldType { get; set; }

        /// <summary>
        /// Gets or sets the ReportId.
        /// </summary>
        /// <value>
        /// The ReportId.
        /// </value>
        public int ReportId { get; set; }

        /// <summary>
        /// Gets or sets the Selection.
        /// </summary>
        /// <value>
        /// The Selection.
        /// </value>
        public string Selection { get; set; }

        /// <summary>
        /// Gets or sets the ShowInGrid.
        /// </summary>
        /// <value>
        /// The ShowInGrid.
        /// </value>
        public bool ShowInGrid { get; set; }

        /// <summary>
        /// Gets or sets the SortDirection.
        /// </summary>
        /// <value>
        /// The SortDirection.
        /// </value>
        public int SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the SortOrder.
        /// </summary>
        /// <value>
        /// The SortOrder.
        /// </value>
        public int? SortOrder { get; set; }

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