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
    /// GroupDemographicValue Service class
    /// </summary>
    public partial class GroupDemographicValueService : Service<GroupDemographicValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDemographicValueService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GroupDemographicValueService(RockContext context) : base(context)
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
        public bool CanDelete( GroupDemographicValue item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GroupDemographicValueExtensionMethods
    {
        /// <summary>
        /// Clones this GroupDemographicValue object to a new GroupDemographicValue object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GroupDemographicValue Clone( this GroupDemographicValue source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GroupDemographicValue;
            }
            else
            {
                var target = new GroupDemographicValue();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this GroupDemographicValue object to a new GroupDemographicValue object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static GroupDemographicValue CloneWithoutIdentity( this GroupDemographicValue source )
        {
            var target = new GroupDemographicValue();
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
        /// Copies the properties from another GroupDemographicValue object to this GroupDemographicValue object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GroupDemographicValue target, GroupDemographicValue source )
        {
            target.Id = source.Id;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.GroupDemographicTypeId = source.GroupDemographicTypeId;
            target.GroupId = source.GroupId;
            target.LastCalculatedDateTime = source.LastCalculatedDateTime;
            target.RelatedEntityId = source.RelatedEntityId;
            target.RelatedEntityTypeId = source.RelatedEntityTypeId;
            target.Value = source.Value;
            target.ValueAsBoolean = source.ValueAsBoolean;
            target.ValueAsGuid = source.ValueAsGuid;
            target.ValueAsNumeric = source.ValueAsNumeric;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
