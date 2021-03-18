﻿using System;
using System.ComponentModel;
using System.Web.UI;
using System.Linq;

using Rock;
using Rock.Data;
using Rock.Attribute;
using Rock.Model;
using DocumentFormat.OpenXml.Wordprocessing;


namespace Plugins.com_simpledonation
{
    /// <summary>
    /// Merlin block for Simple Donation customers to add to any RockRMS page.
    /// </summary>
    [DisplayName( "Merlin" )]
    [Category( "Simple Donation" )]
    [Description( "Merlin block for Simple Donation users to add a giving option to any Rock page." )]

    #region Block Attributes

    [TextField(
        "Merlin Widget Id",
        Key = AttributeKey.MerlinWidgetId,
        Description = "Enter the Id for your Merlin widget provided by Simple Donation (found in your Financial Gateway settings in Rock, such as https://yourchurchname.simpledonation.com",
        DefaultValue = "",
        Order = 1 )]

    [ColorField(
        "Primary Color",
        Key = AttributeKey.PrimaryColor,
        Description = "The primary color for your Merlin widget buttons.",
        DefaultValue = "004371",
        Order = 2 )]

    [TextField(
        "Button Text",
        Key = AttributeKey.MerlinButtonText,
        Description = "Enter the preferred text displayed on the Merlin button.",
        DefaultValue = "Give Now",
        Order = 3 )]

    #endregion Block Attributes
    public partial class 
        SimpleDonationMerlin : Rock.Web.UI.RockBlock
    {

        #region Attribute Keys

        /// <summary>
        /// Keys to use for Block Attributes
        /// </summary>
        public static class AttributeKey
        {
            public const string MerlinWidgetId = "MerlinWidgetId";
            public const string PrimaryColor = "PrimaryColor";
            public const string MerlinButtonText = "MerlinButtonText";
        }

        #endregion Attribute Keys

        #region PageParameterKeys

        /// <summary>
        /// Keys to use for Page Parameters
        /// </summary>
        protected static class PageParameterKey
        {
            public const string StarkId = "StarkId";
        }

        #endregion PageParameterKeys

        #region Fields

        // used for private variables

        #endregion

        #region Properties

        // used for public / protected properties

        #endregion

        #region Base Control Methods

        protected override void OnInit( EventArgs e )
        {
            base.OnInit( e );

            // this event gets fired after block settings are updated. it's nice to repaint the screen if these settings would alter it
            this.BlockUpdated += MerlinBlock_BlockUpdated;
            this.AddConfigurationUpdateTrigger( upnlContent );
            {
                MerlinSettings();
            }
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );


            if ( !Page.IsPostBack )
            {
				{
					MerlinSettings();
				}
            }
        }

        #endregion

        #region Events

        protected void MerlinBlock_BlockUpdated( object sender, EventArgs e )
        {
            {
                MerlinSettings();
            }
        }
		
		protected void MerlinSettings()
            {
            var rockContext = new RockContext(); // set the context to pull from
                var domainUrl = new AttributeValueService( rockContext ).Queryable() 
                    .FirstOrDefault( av => av.Attribute.Key == "Domain" && av.Attribute.Description == "Your Simple Donation API Domain" && av.Attribute.FieldType.Name == "Url Link" ); // pulls the Value from AttributeValue table for the Attribute with Key of 'Domain' and Descripton of 'Your Simple Donation API Domain'

            string MerlinWidgetId = this.GetAttributeValue( "MerlinWidgetId" ); // Retrieves the Merlin widget id block attribute
            string PrimaryColor = this.GetAttributeValue( "PrimaryColor" ); // Retrieves the Merlin primary color block attribute
            string MerlinButtonText = this.GetAttributeValue( "MerlinButtonText" ); // Retrieves the Merlin button text block attribute
            string PrimaryColorTrim = PrimaryColor.Split( '#' ).Last(); // removes any # from the hex code if present

            merlinWarning.Visible = !MerlinWidgetId.IsNotNullOrWhiteSpace(); // Show warning to populate Merlin widget Id upon first launch
            merlinControl.Visible = MerlinWidgetId.IsNotNullOrWhiteSpace(); // Do not show Give Now button if there is no Merlin widget Id present, currently requires a forced page refresh for user upon setting save

            // Constructs the Merlin widget script html for button
            string MerlinWidgetFull = string.Concat( "<script async src='https://merlin.simpledonation.com/js/installScript.js?key=", MerlinWidgetId , "&primaryColor=", PrimaryColorTrim , "'></script><button class='open-merlin'>", MerlinButtonText, "</button>" );
            // Constructs the missing Merlin widget Id warning
            string MerlinWarningFull = string.Concat( "<div class='alert alert-warning'><div class='row'><div class='col-md-1 text-center'><i class='fa fa-hat-wizard fa-4x' style='padding: 10px 0; margin: 0;'></i></div><div class='col-md-11'><p>Merlin is <em>magical</em>, but he cannot guess your widget key.<br/>Please copy your Merlin key from your <b><a href='", domainUrl, "/admin' target='_blank'>", domainUrl, "/admin</a></b> dashboard and paste it into the block settings or simply contact <b><a href='mailto:happy@simpledonation.com?subject=Help,%20I%20need%20my%20Merlin%20Widget%20key!' target='_blank'>happy@simpledonation.com</a></b> and we'll provide this for you</i>.</p><p>If you'd like to see how to setup your Merlin block visit <b><a href='https://www.simpledonation.com/rock' target='_blank'>www.simpledonation.com/rock</a></b></p></div></div></div><div class='alert alert-danger'><div class='row'><div class='col-md-1 text-center'><i class='fa fa-exclamation-triangle fa-4x' style='padding: 0 0 10px 0;'></i></div><div class='col-md-11'><p>Ensure that the page Cache Duration is set to zero '0' or in v12 the Cacheability Type to 'No-Cache' with Max Age or Max Shared Age set to zero '0' in the Advanced page setting for any page utilizing the Merlin block.</p><p>If you'd like to see how to setup your Merlin block visit <b><a href='https://www.simpledonation.com/rock' target='_blank'>www.simpledonation.com/rock</a></b></p></div></div></div>" );

            merlinControl.Text = MerlinWidgetFull; // sends final consrtucted script with user settings to webform
            merlinWarning.Text = MerlinWarningFull; // sends final consrtucted missing widget Id warning to webform
        }

        #endregion

        #region Methods

        // helper functional methods (like BindGrid(), etc.)

        #endregion
    }
}