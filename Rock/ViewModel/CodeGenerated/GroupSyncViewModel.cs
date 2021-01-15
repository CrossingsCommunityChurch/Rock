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
    /// GroupSync View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.GroupSync ) )]
    public partial class GroupSyncViewModel : IViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the AddUserAccountsDuringSync.
        /// </summary>
        /// <value>
        /// The AddUserAccountsDuringSync.
        /// </value>
        public bool AddUserAccountsDuringSync { get; set; }

        /// <summary>
        /// Gets or sets the ExitSystemCommunicationId.
        /// </summary>
        /// <value>
        /// The ExitSystemCommunicationId.
        /// </value>
        public int? ExitSystemCommunicationId { get; set; }

        /// <summary>
        /// Gets or sets the ExitSystemEmailId.
        /// </summary>
        /// <value>
        /// The ExitSystemEmailId.
        /// </value>
        public int? ExitSystemEmailId { get; set; }

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
        /// Gets or sets the GroupId.
        /// </summary>
        /// <value>
        /// The GroupId.
        /// </value>
        public int GroupId { get; set; }

        /// <summary>
        /// Gets or sets the GroupTypeRoleId.
        /// </summary>
        /// <value>
        /// The GroupTypeRoleId.
        /// </value>
        public int GroupTypeRoleId { get; set; }

        /// <summary>
        /// Gets or sets the LastRefreshDateTime.
        /// </summary>
        /// <value>
        /// The LastRefreshDateTime.
        /// </value>
        public DateTime? LastRefreshDateTime { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleIntervalMinutes.
        /// </summary>
        /// <value>
        /// The ScheduleIntervalMinutes.
        /// </value>
        public int? ScheduleIntervalMinutes { get; set; }

        /// <summary>
        /// Gets or sets the SyncDataViewId.
        /// </summary>
        /// <value>
        /// The SyncDataViewId.
        /// </value>
        public int SyncDataViewId { get; set; }

        /// <summary>
        /// Gets or sets the WelcomeSystemCommunicationId.
        /// </summary>
        /// <value>
        /// The WelcomeSystemCommunicationId.
        /// </value>
        public int? WelcomeSystemCommunicationId { get; set; }

        /// <summary>
        /// Gets or sets the WelcomeSystemEmailId.
        /// </summary>
        /// <value>
        /// The WelcomeSystemEmailId.
        /// </value>
        public int? WelcomeSystemEmailId { get; set; }

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
