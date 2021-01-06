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
    /// GroupSync Service class
    /// </summary>
    public partial class GroupSyncService : Service<GroupSync>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSyncService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GroupSyncService(RockContext context) : base(context)
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
        public bool CanDelete( GroupSync item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GroupSyncExtensionMethods
    {
        /// <summary>
        /// Clones this GroupSync object to a new GroupSync object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GroupSync Clone( this GroupSync source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GroupSync;
            }
            else
            {
                var target = new GroupSync();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this GroupSync object to a new GroupSync object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static GroupSync CloneWithoutIdentity( this GroupSync source )
        {
            var target = new GroupSync();
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
        /// Copies the properties from another GroupSync object to this GroupSync object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GroupSync target, GroupSync source )
        {
            target.Id = source.Id;
            target.AddUserAccountsDuringSync = source.AddUserAccountsDuringSync;
            target.ExitSystemCommunicationId = source.ExitSystemCommunicationId;
            #pragma warning disable 612, 618
            target.ExitSystemEmailId = source.ExitSystemEmailId;
            #pragma warning restore 612, 618
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.GroupId = source.GroupId;
            target.GroupTypeRoleId = source.GroupTypeRoleId;
            target.LastRefreshDateTime = source.LastRefreshDateTime;
            target.ScheduleIntervalMinutes = source.ScheduleIntervalMinutes;
            target.SyncDataViewId = source.SyncDataViewId;
            target.WelcomeSystemCommunicationId = source.WelcomeSystemCommunicationId;
            #pragma warning disable 612, 618
            target.WelcomeSystemEmailId = source.WelcomeSystemEmailId;
            #pragma warning restore 612, 618
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
