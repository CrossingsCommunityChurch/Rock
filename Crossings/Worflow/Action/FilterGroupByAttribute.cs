using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using Rock;
using Rock.Attribute;
using Rock.Data;
using Rock.Web.Cache;
using Rock.Workflow;
using Rock.Workflow.Action.CheckIn;

namespace Crossings.Worflow.Action
{
        /// <summary>
        /// Removes (or excludes) the groups for each selected family member that are not specific to their age or birthdate.
        /// </summary>
        [ActionCategory("Check-In")]
        [Description("Removes (or excludes) the groups for each selected family member that are not specific to their Attribute.")]
        [Export(typeof(ActionComponent))]
        [ExportMetadata("ComponentName", "Filter Groups By Attribute")]

        [BooleanField("Remove", "Select 'Yes' if groups should be removed.  Select 'No' if they should just be marked as excluded.", true, "", 0)]
        [AttributeField(Rock.SystemGuid.EntityType.GROUP, "Group Room Attribute", "Select the attribute used to define the Room Attributes of the group", true, false, order: 1)]
    public class FilterGroupsByAttribute : CheckInActionComponent
        {
            /// <summary>
            /// Executes the specified workflow.
            /// </summary>
            /// <param name="rockContext">The rock context.</param>
            /// <param name="action">The workflow action.</param>
            /// <param name="entity">The entity.</param>
            /// <param name="errorMessages">The error messages.</param>
            /// <returns></returns>
            /// <exception cref="System.NotImplementedException"></exception>
            public override bool Execute(RockContext rockContext, Rock.Model.WorkflowAction action, Object entity, out List<string> errorMessages)
            {
                var checkInState = GetCheckInState(entity, out errorMessages);
                if (checkInState == null)
                {
                    return false;
                }

                var family = checkInState.CheckIn.CurrentFamily;
                if (family != null)
                {
                var remove = GetAttributeValue(action, "Remove").AsBoolean();

                    // get the Room Attribute
                    var roomAttributeKey = string.Empty;
                    var roomAttributeGuid = GetAttributeValue(action, "GroupRoomAttribute").AsGuidOrNull();
                    if (roomAttributeGuid.HasValue)
                    {
                        var attribute = AttributeCache.Get(roomAttributeGuid.Value, rockContext);
                        if (attribute != null)
                        {
                            roomAttributeKey = attribute.Key;
                        }
                    }

                    foreach (var person in family.People)
                    {
                        person.Person.LoadAttributes();
                        // Gets the guid of the attribute as a string.
                        var personRoomAtt = person.Person.GetAttributeValue("RoomAttribute");

                        foreach (var groupType in person.GroupTypes.ToList())
                        {
                            foreach (var group in groupType.Groups.ToList())
                            {
                                // First we check that the Attribute is not empty and it matches the group attribute.
                                if (!string.IsNullOrWhiteSpace(roomAttributeKey))
                                {
                                    var groupRoomAtt = group.Group.GetAttributeValue(roomAttributeKey).ToStringSafe();
                                if (string.IsNullOrWhiteSpace(groupRoomAtt) || personRoomAtt == groupRoomAtt) continue;
                                    if (remove)
                                    {
                                        groupType.Groups.Remove(group);
                                    }
                                    else
                                    {
                                        group.ExcludedByFilter = true;
                                    }
                                }
                            }
                        }
                    }
                }

                return true;
            }
        }
    }
