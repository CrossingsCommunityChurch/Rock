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
    /// StreakType View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.StreakType ) )]
    public partial class StreakTypeViewModel : IViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the EnableAttendance.
        /// </summary>
        /// <value>
        /// The EnableAttendance.
        /// </value>
        public bool EnableAttendance { get; set; }

        /// <summary>
        /// Gets or sets the FirstDayOfWeek.
        /// </summary>
        /// <value>
        /// The FirstDayOfWeek.
        /// </value>
        public int /* DayOfWeek*/? FirstDayOfWeek { get; set; }

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
        /// Gets or sets the IsActive.
        /// </summary>
        /// <value>
        /// The IsActive.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the OccurrenceFrequency.
        /// </summary>
        /// <value>
        /// The OccurrenceFrequency.
        /// </value>
        public int OccurrenceFrequency { get; set; }

        /// <summary>
        /// Gets or sets the OccurrenceMap.
        /// </summary>
        /// <value>
        /// The OccurrenceMap.
        /// </value>
        public Byte[] OccurrenceMap { get; set; }

        /// <summary>
        /// Gets or sets the RequiresEnrollment.
        /// </summary>
        /// <value>
        /// The RequiresEnrollment.
        /// </value>
        public bool RequiresEnrollment { get; set; }

        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        /// <value>
        /// The StartDate.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the StructureEntityId.
        /// </summary>
        /// <value>
        /// The StructureEntityId.
        /// </value>
        public int? StructureEntityId { get; set; }

        /// <summary>
        /// Gets or sets the StructureType.
        /// </summary>
        /// <value>
        /// The StructureType.
        /// </value>
        public Rock.Client.Enums.StreakStructureType? StructureType { get; set; }

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
