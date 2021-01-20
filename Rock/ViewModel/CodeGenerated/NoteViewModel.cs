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
    /// Note View Model
    /// </summary>
    [ViewModelOf( typeof( Rock.Model.Note ) )]
    public partial class NoteViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the ApprovalsSent.
        /// </summary>
        /// <value>
        /// The ApprovalsSent.
        /// </value>
        public bool ApprovalsSent { get; set; }

        /// <summary>
        /// Gets or sets the ApprovalStatus.
        /// </summary>
        /// <value>
        /// The ApprovalStatus.
        /// </value>
        public int ApprovalStatus { get; set; }

        /// <summary>
        /// Gets or sets the ApprovedByPersonAliasId.
        /// </summary>
        /// <value>
        /// The ApprovedByPersonAliasId.
        /// </value>
        public int? ApprovedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the ApprovedDateTime.
        /// </summary>
        /// <value>
        /// The ApprovedDateTime.
        /// </value>
        public DateTime? ApprovedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the Caption.
        /// </summary>
        /// <value>
        /// The Caption.
        /// </value>
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the EditedByPersonAliasId.
        /// </summary>
        /// <value>
        /// The EditedByPersonAliasId.
        /// </value>
        public int? EditedByPersonAliasId { get; set; }

        /// <summary>
        /// Gets or sets the EditedDateTime.
        /// </summary>
        /// <value>
        /// The EditedDateTime.
        /// </value>
        public DateTime? EditedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the EntityId.
        /// </summary>
        /// <value>
        /// The EntityId.
        /// </value>
        public int? EntityId { get; set; }

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
        /// Gets or sets the IsAlert.
        /// </summary>
        /// <value>
        /// The IsAlert.
        /// </value>
        public bool? IsAlert { get; set; }

        /// <summary>
        /// Gets or sets the IsPrivateNote.
        /// </summary>
        /// <value>
        /// The IsPrivateNote.
        /// </value>
        public bool IsPrivateNote { get; set; }

        /// <summary>
        /// Gets or sets the IsSystem.
        /// </summary>
        /// <value>
        /// The IsSystem.
        /// </value>
        public bool IsSystem { get; set; }

        /// <summary>
        /// Gets or sets the NoteTypeId.
        /// </summary>
        /// <value>
        /// The NoteTypeId.
        /// </value>
        public int NoteTypeId { get; set; }

        /// <summary>
        /// Gets or sets the NoteUrl.
        /// </summary>
        /// <value>
        /// The NoteUrl.
        /// </value>
        public string NoteUrl { get; set; }

        /// <summary>
        /// Gets or sets the NotificationsSent.
        /// </summary>
        /// <value>
        /// The NotificationsSent.
        /// </value>
        public bool NotificationsSent { get; set; }

        /// <summary>
        /// Gets or sets the ParentNoteId.
        /// </summary>
        /// <value>
        /// The ParentNoteId.
        /// </value>
        public int? ParentNoteId { get; set; }

        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        /// <value>
        /// The Text.
        /// </value>
        public string Text { get; set; }

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