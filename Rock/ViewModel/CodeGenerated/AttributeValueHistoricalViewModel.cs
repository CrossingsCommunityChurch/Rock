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
    /// AttributeValueHistorical View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.AttributeValueHistorical ) )]
    public partial class AttributeValueHistoricalViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the AttributeValueId.
        /// </summary>
        /// <value>
        /// The AttributeValueId.
        /// </value>
        public int AttributeValueId { get; set; }

        /// <summary>
        /// Gets or sets the CurrentRowIndicator.
        /// </summary>
        /// <value>
        /// The CurrentRowIndicator.
        /// </value>
        public bool CurrentRowIndicator { get; set; }

        /// <summary>
        /// Gets or sets the EffectiveDateTime.
        /// </summary>
        /// <value>
        /// The EffectiveDateTime.
        /// </value>
        public DateTime EffectiveDateTime { get; set; }

        /// <summary>
        /// Gets or sets the ExpireDateTime.
        /// </summary>
        /// <value>
        /// The ExpireDateTime.
        /// </value>
        public DateTime ExpireDateTime { get; set; }

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
        /// Gets or sets the Value.
        /// </summary>
        /// <value>
        /// The Value.
        /// </value>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the ValueAsBoolean.
        /// </summary>
        /// <value>
        /// The ValueAsBoolean.
        /// </value>
        public bool? ValueAsBoolean { get; set; }

        /// <summary>
        /// Gets or sets the ValueAsDateTime.
        /// </summary>
        /// <value>
        /// The ValueAsDateTime.
        /// </value>
        public DateTime? ValueAsDateTime { get; set; }

        /// <summary>
        /// Gets or sets the ValueAsNumeric.
        /// </summary>
        /// <value>
        /// The ValueAsNumeric.
        /// </value>
        public decimal? ValueAsNumeric { get; set; }

        /// <summary>
        /// Gets or sets the ValueAsPersonId.
        /// </summary>
        /// <value>
        /// The ValueAsPersonId.
        /// </value>
        public int? ValueAsPersonId { get; set; }

        /// <summary>
        /// Gets or sets the ValueFormatted.
        /// </summary>
        /// <value>
        /// The ValueFormatted.
        /// </value>
        public string ValueFormatted { get; set; }

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