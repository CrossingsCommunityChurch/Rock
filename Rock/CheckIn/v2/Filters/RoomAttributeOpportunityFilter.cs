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

using Rock;
using Rock.Model;
using Rock.Utility;
using Rock.Web.Cache;

namespace Rock.CheckIn.v2.Filters
{
    /// <summary>
    /// Filters out any groups whose configured room attribute value does not
    /// match the person's room attribute value.
    /// </summary>
    internal class RoomAttributeOpportunityFilter : OpportunityFilter
    {
        #region Fields

        /// <summary>
        /// Lazily loads the current person's room attribute value.
        /// </summary>
        private readonly Lazy<string> _personRoomAttributeValue;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomAttributeOpportunityFilter"/> class.
        /// </summary>
        public RoomAttributeOpportunityFilter()
        {
            _personRoomAttributeValue = new Lazy<string>( GetPersonRoomAttributeValue, true );
        }

        #endregion

        #region Methods

        /// <inheritdoc/>
        public override bool IsGroupValid( GroupOpportunity group )
        {
            var groupAttributeKey = TemplateConfiguration.RoomAttributeKey;

            if ( string.IsNullOrWhiteSpace( groupAttributeKey ) )
            {
                return true;
            }

            var groupAttributeValue = GetGroupAttributeValue( group, groupAttributeKey );

            // If the group doesn't have a value set for the attribute, keep it.
            if ( string.IsNullOrWhiteSpace( groupAttributeValue ) )
            {
                return true;
            }

            var personAttributeValue = _personRoomAttributeValue.Value;

            // If the person doesn't have a value, they don't qualify for groups
            // that do.
            if ( string.IsNullOrWhiteSpace( personAttributeValue ) )
            {
                return false;
            }

            return string.Equals( personAttributeValue, groupAttributeValue, StringComparison.OrdinalIgnoreCase );
        }

        /// <summary>
        /// Gets the room attribute value for the current person.
        /// </summary>
        /// <returns>The value of the configured room attribute for the person or <c>string.Empty</c>.</returns>
        private string GetPersonRoomAttributeValue()
        {
            var personId = PersonId.Value;

            if ( personId == 0 )
            {
                return string.Empty;
            }

            var person = new PersonService( RockContext ).Get( personId );

            if ( person == null )
            {
                return string.Empty;
            }

            person.LoadAttributes( RockContext );

            return person.GetAttributeValue( TemplateConfiguration.RoomAttributeKey ).ToStringSafe();
        }

        /// <summary>
        /// Gets the room attribute value for the specified group.
        /// </summary>
        /// <param name="group">The group.</param>
        /// <param name="groupAttributeKey">The group attribute key.</param>
        /// <returns>The value of the configured room attribute for the group or <c>string.Empty</c>.</returns>
        private string GetGroupAttributeValue( GroupOpportunity group, string groupAttributeKey )
        {
            var groupId = IdHasher.Instance.GetId( group.Id );

            if ( !groupId.HasValue )
            {
                return string.Empty;
            }

            var groupCache = GroupCache.Get( groupId.Value, RockContext );

            if ( groupCache == null )
            {
                return string.Empty;
            }

            return groupCache.GetAttributeValue( groupAttributeKey ).ToStringSafe();
        }

        #endregion
    }
}
