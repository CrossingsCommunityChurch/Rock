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
    /// Metric View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.Metric ) )]
    public partial class MetricViewModel : IViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the AdminPersonAliasId.
        /// </summary>
        /// <value>
        /// The AdminPersonAliasId.
        /// </value>
        public int? AdminPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the DataViewId.
        /// </summary>
        /// <value>
        /// The DataViewId.
        /// </value>
        public int? DataViewId { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the EnableAnalytics.
        /// </summary>
        /// <value>
        /// The EnableAnalytics.
        /// </value>
        public bool EnableAnalytics { get; set; }

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
        /// Gets or sets the IsCumulative.
        /// </summary>
        /// <value>
        /// The IsCumulative.
        /// </value>
        public bool IsCumulative { get; set; }

        /// <summary>
        /// Gets or sets the IsSystem.
        /// </summary>
        /// <value>
        /// The IsSystem.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the LastRunDateTime.
        /// </summary>
        /// <value>
        /// The LastRunDateTime.
        /// </value>
        public DateTime? LastRunDateTime { get; set; }

        /// <summary>
        /// Gets or sets the MetricChampionPersonAliasId.
        /// </summary>
        /// <value>
        /// The MetricChampionPersonAliasId.
        /// </value>
        public int? MetricChampionPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the NumericDataType.
        /// </summary>
        /// <value>
        /// The NumericDataType.
        /// </value>
        public int NumericDataType { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleId.
        /// </summary>
        /// <value>
        /// The ScheduleId.
        /// </value>
        public int? ScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the SourceLava.
        /// </summary>
        /// <value>
        /// The SourceLava.
        /// </value>
        public string SourceLava { get; set; }

        /// <summary>
        /// Gets or sets the SourceSql.
        /// </summary>
        /// <value>
        /// The SourceSql.
        /// </value>
        public string SourceSql { get; set; }

        /// <summary>
        /// Gets or sets the SourceValueTypeId.
        /// </summary>
        /// <value>
        /// The SourceValueTypeId.
        /// </value>
        public int? SourceValueTypeId { get; set; }

        /// <summary>
        /// Gets or sets the Subtitle.
        /// </summary>
        /// <value>
        /// The Subtitle.
        /// </value>
        public string Subtitle { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        /// <value>
        /// The Title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the XAxisLabel.
        /// </summary>
        /// <value>
        /// The XAxisLabel.
        /// </value>
        public string XAxisLabel { get; set; }

        /// <summary>
        /// Gets or sets the YAxisLabel.
        /// </summary>
        /// <value>
        /// The YAxisLabel.
        /// </value>
        public string YAxisLabel { get; set; }

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
