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
    /// CommunicationRecipient View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.CommunicationRecipient ) )]
    public partial class CommunicationRecipientViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the AdditionalMergeValuesJson.
        /// </summary>
        /// <value>
        /// The AdditionalMergeValuesJson.
        /// </value>
        public string AdditionalMergeValuesJson { get; set; }

        /// <summary>
        /// Gets or sets the CommunicationId.
        /// </summary>
        /// <value>
        /// The CommunicationId.
        /// </value>
        public int CommunicationId { get; set; }

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
        /// Gets or sets the MediumEntityTypeId.
        /// </summary>
        /// <value>
        /// The MediumEntityTypeId.
        /// </value>
        public int? MediumEntityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the OpenedClient.
        /// </summary>
        /// <value>
        /// The OpenedClient.
        /// </value>
        public string OpenedClient { get; set; }

        /// <summary>
        /// Gets or sets the OpenedDateTime.
        /// </summary>
        /// <value>
        /// The OpenedDateTime.
        /// </value>
        public DateTime? OpenedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the PersonalDeviceId.
        /// </summary>
        /// <value>
        /// The PersonalDeviceId.
        /// </value>
        public int? PersonalDeviceId { get; set; }

        /// <summary>
        /// Gets or sets the PersonAliasId.
        /// </summary>
        /// <value>
        /// The PersonAliasId.
        /// </value>
        public int? PersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the ResponseCode.
        /// </summary>
        /// <value>
        /// The ResponseCode.
        /// </value>
        public string ResponseCode { get; set; }

        /// <summary>
        /// Gets or sets the SendDateTime.
        /// </summary>
        /// <value>
        /// The SendDateTime.
        /// </value>
        public DateTime? SendDateTime { get; set; }

        /// <summary>
        /// Gets or sets the SentMessage.
        /// </summary>
        /// <value>
        /// The SentMessage.
        /// </value>
        public string SentMessage { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        /// <value>
        /// The Status.
        /// </value>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the StatusNote.
        /// </summary>
        /// <value>
        /// The StatusNote.
        /// </value>
        public string StatusNote { get; set; }

        /// <summary>
        /// Gets or sets the TransportEntityTypeName.
        /// </summary>
        /// <value>
        /// The TransportEntityTypeName.
        /// </value>
        public string TransportEntityTypeName { get; set; }

        /// <summary>
        /// Gets or sets the UniqueMessageId.
        /// </summary>
        /// <value>
        /// The UniqueMessageId.
        /// </value>
        public string UniqueMessageId { get; set; }

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