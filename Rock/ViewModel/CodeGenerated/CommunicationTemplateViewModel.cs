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
    /// CommunicationTemplate View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.CommunicationTemplate ) )]
    public partial class CommunicationTemplateViewModel : IViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the BCCEmails.
        /// </summary>
        /// <value>
        /// The BCCEmails.
        /// </value>
        public string BCCEmails { get; set; }

        /// <summary>
        /// Gets or sets the CategoryId.
        /// </summary>
        /// <value>
        /// The CategoryId.
        /// </value>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the CCEmails.
        /// </summary>
        /// <value>
        /// The CCEmails.
        /// </value>
        public string CCEmails { get; set; }

        /// <summary>
        /// Gets or sets the CssInliningEnabled.
        /// </summary>
        /// <value>
        /// The CssInliningEnabled.
        /// </value>
        public bool CssInliningEnabled { get; set; }

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
        /// Gets or sets the FromEmail.
        /// </summary>
        /// <value>
        /// The FromEmail.
        /// </value>
        public string FromEmail { get; set; }

        /// <summary>
        /// Gets or sets the FromName.
        /// </summary>
        /// <value>
        /// The FromName.
        /// </value>
        public string FromName { get; set; }

        /// <summary>
        /// Gets or sets the ImageFileId.
        /// </summary>
        /// <value>
        /// The ImageFileId.
        /// </value>
        public int? ImageFileId { get; set; }

        /// <summary>
        /// Gets or sets the IsActive.
        /// </summary>
        /// <value>
        /// The IsActive.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the IsSystem.
        /// </summary>
        /// <value>
        /// The IsSystem.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the LavaFieldsJson.
        /// </summary>
        /// <value>
        /// The LavaFieldsJson.
        /// </value>
        public string LavaFieldsJson { get; set; }

        /// <summary>
        /// Gets or sets the LogoBinaryFileId.
        /// </summary>
        /// <value>
        /// The LogoBinaryFileId.
        /// </value>
        public int? LogoBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        /// <value>
        /// The Message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the MessageMetaData.
        /// </summary>
        /// <value>
        /// The MessageMetaData.
        /// </value>
        public string MessageMetaData { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the PushData.
        /// </summary>
        /// <value>
        /// The PushData.
        /// </value>
        public string PushData { get; set; }

        /// <summary>
        /// Gets or sets the PushImageBinaryFileId.
        /// </summary>
        /// <value>
        /// The PushImageBinaryFileId.
        /// </value>
        public int? PushImageBinaryFileId { get; set; }

        /// <summary>
        /// Gets or sets the PushMessage.
        /// </summary>
        /// <value>
        /// The PushMessage.
        /// </value>
        public string PushMessage { get; set; }

        /// <summary>
        /// Gets or sets the PushOpenAction.
        /// </summary>
        /// <value>
        /// The PushOpenAction.
        /// </value>
        public int /* PushOpenAction*/? PushOpenAction { get; set; }

        /// <summary>
        /// Gets or sets the PushOpenMessage.
        /// </summary>
        /// <value>
        /// The PushOpenMessage.
        /// </value>
        public string PushOpenMessage { get; set; }

        /// <summary>
        /// Gets or sets the PushSound.
        /// </summary>
        /// <value>
        /// The PushSound.
        /// </value>
        public string PushSound { get; set; }

        /// <summary>
        /// Gets or sets the PushTitle.
        /// </summary>
        /// <value>
        /// The PushTitle.
        /// </value>
        public string PushTitle { get; set; }

        /// <summary>
        /// Gets or sets the ReplyToEmail.
        /// </summary>
        /// <value>
        /// The ReplyToEmail.
        /// </value>
        public string ReplyToEmail { get; set; }

        /// <summary>
        /// Gets or sets the SenderPersonAliasId.
        /// </summary>
        /// <value>
        /// The SenderPersonAliasId.
        /// </value>
        public int? SenderPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the SMSFromDefinedValueId.
        /// </summary>
        /// <value>
        /// The SMSFromDefinedValueId.
        /// </value>
        public int? SMSFromDefinedValueId { get; set; }

        /// <summary>
        /// Gets or sets the SMSMessage.
        /// </summary>
        /// <value>
        /// The SMSMessage.
        /// </value>
        public string SMSMessage { get; set; }

        /// <summary>
        /// Gets or sets the Subject.
        /// </summary>
        /// <value>
        /// The Subject.
        /// </value>
        public string Subject { get; set; }

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
        /// Gets or sets the Guid.
        /// </summary>
        /// <value>
        /// The Guid.
        /// </value>
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets the ForeignId.
        /// </summary>
        /// <value>
        /// The ForeignId.
        /// </value>
        public int? ForeignId { get; set; }

        /// <summary>
        /// Sets the properties from entity.
        /// </summary>
        /// <param name="entity">The entity, cache item, or some object.</param>
        public virtual void SetPropertiesFrom( Object entity )
        {
            entity.CopyPropertiesTo( this );
        }
    }
}
