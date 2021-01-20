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
    /// ConnectionRequestWorkflow View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.ConnectionRequestWorkflow ) )]
    public partial class ConnectionRequestWorkflowViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the ConnectionRequestId.
        /// </summary>
        /// <value>
        /// The ConnectionRequestId.
        /// </value>
        public int ConnectionRequestId { get; set; }

        /// <summary>
        /// Gets or sets the ConnectionWorkflowId.
        /// </summary>
        /// <value>
        /// The ConnectionWorkflowId.
        /// </value>
        public int ConnectionWorkflowId { get; set; }

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
        /// Gets or sets the TriggerQualifier.
        /// </summary>
        /// <value>
        /// The TriggerQualifier.
        /// </value>
        public string TriggerQualifier { get; set; }

        /// <summary>
        /// Gets or sets the TriggerType.
        /// </summary>
        /// <value>
        /// The TriggerType.
        /// </value>
        public int TriggerType { get; set; }

        /// <summary>
        /// Gets or sets the WorkflowId.
        /// </summary>
        /// <value>
        /// The WorkflowId.
        /// </value>
        public int WorkflowId { get; set; }

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