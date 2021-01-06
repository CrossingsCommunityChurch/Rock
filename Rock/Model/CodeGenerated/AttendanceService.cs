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

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Attendance Service class
    /// </summary>
    public partial class AttendanceService : Service<Attendance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public AttendanceService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( Attendance item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class AttendanceExtensionMethods
    {
        /// <summary>
        /// Clones this Attendance object to a new Attendance object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static Attendance Clone( this Attendance source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as Attendance;
            }
            else
            {
                var target = new Attendance();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this Attendance object to a new Attendance object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static Attendance CloneWithoutIdentity( this Attendance source )
        {
            var target = new Attendance();
            target.CopyPropertiesFrom( source );

            target.Id = 0;
            target.Guid = Guid.NewGuid();
            target.ForeignKey = null;
            target.ForeignId = null;
            target.ForeignGuid = null;
            target.CreatedByPersonAlias = null;
            target.CreatedByPersonAliasId = null;
            target.CreatedDateTime = RockDateTime.Now;
            target.ModifiedByPersonAlias = null;
            target.ModifiedByPersonAliasId = null;
            target.ModifiedDateTime = RockDateTime.Now;

            return target;
        }

        /// <summary>
        /// Copies the properties from another Attendance object to this Attendance object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this Attendance target, Attendance source )
        {
            target.Id = source.Id;
            target.AttendanceCheckInSessionId = source.AttendanceCheckInSessionId;
            target.AttendanceCodeId = source.AttendanceCodeId;
            target.CampusId = source.CampusId;
            target.CheckedInByPersonAliasId = source.CheckedInByPersonAliasId;
            target.CheckedOutByPersonAliasId = source.CheckedOutByPersonAliasId;
            target.DeclineReasonValueId = source.DeclineReasonValueId;
            target.DeviceId = source.DeviceId;
            target.DidAttend = source.DidAttend;
            target.EndDateTime = source.EndDateTime;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.IsFirstTime = source.IsFirstTime;
            target.Note = source.Note;
            target.OccurrenceId = source.OccurrenceId;
            target.PersonAliasId = source.PersonAliasId;
            target.PresentByPersonAliasId = source.PresentByPersonAliasId;
            target.PresentDateTime = source.PresentDateTime;
            target.Processed = source.Processed;
            target.QualifierValueId = source.QualifierValueId;
            target.RequestedToAttend = source.RequestedToAttend;
            target.RSVP = source.RSVP;
            target.RSVPDateTime = source.RSVPDateTime;
            target.ScheduleConfirmationSent = source.ScheduleConfirmationSent;
            target.ScheduledByPersonAliasId = source.ScheduledByPersonAliasId;
            target.ScheduledToAttend = source.ScheduledToAttend;
            target.ScheduleReminderSent = source.ScheduleReminderSent;
            target.SearchResultGroupId = source.SearchResultGroupId;
            target.SearchTypeValueId = source.SearchTypeValueId;
            target.SearchValue = source.SearchValue;
            target.StartDateTime = source.StartDateTime;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
