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
    /// CommunicationResponse View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.CommunicationResponse ) )]
    public partial class CommunicationResponseViewModel : IViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        public int Id { get; set; }

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
        /// Gets or sets the FromPersonAliasId.
        /// </summary>
        /// <value>
        /// The FromPersonAliasId.
        /// </value>
        public int? FromPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the IsRead.
        /// </summary>
        /// <value>
        /// The IsRead.
        /// </value>
        public bool IsRead { get; set; }

        /// <summary>
        /// Gets or sets the MessageKey.
        /// </summary>
        /// <value>
        /// The MessageKey.
        /// </value>
        public string MessageKey { get; set; }

        /// <summary>
        /// Gets or sets the RelatedCommunicationId.
        /// </summary>
        /// <value>
        /// The RelatedCommunicationId.
        /// </value>
        public int? RelatedCommunicationId { get; set; }

        /// <summary>
        /// Gets or sets the RelatedMediumEntityTypeId.
        /// </summary>
        /// <value>
        /// The RelatedMediumEntityTypeId.
        /// </value>
        public int RelatedMediumEntityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the RelatedSmsFromDefinedValueId.
        /// </summary>
        /// <value>
        /// The RelatedSmsFromDefinedValueId.
        /// </value>
        public int? RelatedSmsFromDefinedValueId { get; set; }

        /// <summary>
        /// Gets or sets the RelatedTransportEntityTypeId.
        /// </summary>
        /// <value>
        /// The RelatedTransportEntityTypeId.
        /// </value>
        public int RelatedTransportEntityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the Response.
        /// </summary>
        /// <value>
        /// The Response.
        /// </value>
        public string Response { get; set; }

        /// <summary>
        /// Gets or sets the ToPersonAliasId.
        /// </summary>
        /// <value>
        /// The ToPersonAliasId.
        /// </value>
        public int? ToPersonAliasId { get; set; }

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
