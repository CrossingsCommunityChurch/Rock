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
    /// GroupLocationHistoricalSchedule View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.GroupLocationHistoricalSchedule ) )]
    public partial class GroupLocationHistoricalScheduleViewModel : ViewModelBase
    {
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
        /// Gets or sets the GroupLocationHistoricalId.
        /// </summary>
        /// <value>
        /// The GroupLocationHistoricalId.
        /// </value>
        public int GroupLocationHistoricalId { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleId.
        /// </summary>
        /// <value>
        /// The ScheduleId.
        /// </value>
        public int ScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleModifiedDateTime.
        /// </summary>
        /// <value>
        /// The ScheduleModifiedDateTime.
        /// </value>
        public DateTime? ScheduleModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the ScheduleName.
        /// </summary>
        /// <value>
        /// The ScheduleName.
        /// </value>
        public string ScheduleName { get; set; }

        /// <summary>
        /// Gets or sets the ForeignId.
        /// </summary>
        /// <value>
        /// The ForeignId.
        /// </value>
        public int? ForeignId { get; set; }

    }
}