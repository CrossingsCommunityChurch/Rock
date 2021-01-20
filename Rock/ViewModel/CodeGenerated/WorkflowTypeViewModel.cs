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
    /// WorkflowType View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.WorkflowType ) )]
    public partial class WorkflowTypeViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the CategoryId.
        /// </summary>
        /// <value>
        /// The CategoryId.
        /// </value>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the CompletedWorkflowRetentionPeriod.
        /// </summary>
        /// <value>
        /// The CompletedWorkflowRetentionPeriod.
        /// </value>
        public int? CompletedWorkflowRetentionPeriod { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

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
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets the IsPersisted.
        /// </summary>
        /// <value>
        /// The IsPersisted.
        /// </value>
        public bool IsPersisted { get; set; }

        /// <summary>
        /// Gets or sets the IsSystem.
        /// </summary>
        /// <value>
        /// The IsSystem.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the LoggingLevel.
        /// </summary>
        /// <value>
        /// The LoggingLevel.
        /// </value>
        public int LoggingLevel { get; set; }

        /// <summary>
        /// Gets or sets the LogRetentionPeriod.
        /// </summary>
        /// <value>
        /// The LogRetentionPeriod.
        /// </value>
        public int? LogRetentionPeriod { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the NoActionMessage.
        /// </summary>
        /// <value>
        /// The NoActionMessage.
        /// </value>
        public string NoActionMessage { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        /// <value>
        /// The Order.
        /// </value>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the ProcessingIntervalSeconds.
        /// </summary>
        /// <value>
        /// The ProcessingIntervalSeconds.
        /// </value>
        public int? ProcessingIntervalSeconds { get; set; }

        /// <summary>
        /// Gets or sets the SummaryViewText.
        /// </summary>
        /// <value>
        /// The SummaryViewText.
        /// </value>
        public string SummaryViewText { get; set; }

        /// <summary>
        /// Gets or sets the WorkflowIdPrefix.
        /// </summary>
        /// <value>
        /// The WorkflowIdPrefix.
        /// </value>
        public string WorkflowIdPrefix { get; set; }

        /// <summary>
        /// Gets or sets the WorkTerm.
        /// </summary>
        /// <value>
        /// The WorkTerm.
        /// </value>
        public string WorkTerm { get; set; }

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