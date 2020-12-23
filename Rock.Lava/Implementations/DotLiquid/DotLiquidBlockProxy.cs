﻿// <copyright>
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
using System.Collections.Generic;
using System.IO;
using DotLiquid;

namespace Rock.Lava.DotLiquid
{
    /// <summary>
    /// Represents an implementation of a Lava Block for the DotLiquid Templating Framework.
    /// </summary>
    /// <remarks>
    /// This class implements a Lava Block element using the DotLiquid.Block Type that can be processed by the DotLiquid framework.
    /// </remarks>
    internal class DotLiquidBlockProxy : Block, ILiquidFrameworkElementRenderer
    {
        #region Static factory methods

        private static Dictionary<string, Func<string, IRockLavaBlock>> _factoryMethods = new Dictionary<string, Func<string, IRockLavaBlock>>( StringComparer.OrdinalIgnoreCase );

        public static void RegisterFactory( string name, Func<string, IRockLavaBlock> factoryMethod )
        {
            if ( string.IsNullOrWhiteSpace( name ) )
            {
                throw new ArgumentException( "Name must be specified." );
            }

            name = name.Trim().ToLower();

            _factoryMethods[name] = factoryMethod;
        }

        #endregion

        private IRockLavaBlock _lavaBlock = null;

        public string SourceElementName
        {
            get
            {
                return _lavaBlock.SourceElementName;
            }
        }

        #region DotLiquid Block Overrides

        public override void Initialize( string tagName, string markup, List<string> tokens )
        {
            if ( !_factoryMethods.ContainsKey( tagName ) )
            {
                throw new Exception( "Block factory could not be found." );
            }

            var factoryMethod = _factoryMethods[tagName];

            _lavaBlock = factoryMethod( tagName );

            if ( _lavaBlock == null )
            {
                throw new Exception( "Block factory could not provide a compatible block instance." );
            }

            // Initialize the Lava block first, because it may be called during the DotLiquid.Block initialization process.
            var blockTokens = new List<string>( tokens );

            // Remove the closing tag because it is not part of the block content.
            if ( blockTokens.Count > 0 )
            {
                blockTokens.RemoveAt( blockTokens.Count - 1 );
            }

            _lavaBlock.OnInitialize( tagName, markup, blockTokens );

            // Initialize the DotLiquid block.
            base.Initialize( tagName, markup, tokens );
        }

        public override void Render( Context context, TextWriter result )
        {
            var lavaContext = new DotLiquidLavaContext( context );

            var block = _lavaBlock as ILiquidFrameworkElementRenderer;

            if ( block == null )
            {
                throw new Exception( "Block proxy cannot be rendered." );
            }

            // Call the renderer implemented by the wrapped Lava block.
            block.Render( this, lavaContext, result );
        }

        /// <summary>
        /// Called by the DotLiquid framework when required to parse the supplied tokens from the Lava document.
        /// </summary>
        /// <param name="tokens"></param>
        protected override void Parse( List<string> tokens )
        {
            // Tokens are consumed as they are processed, so create a copy of the list for post-processing.
            var blockTokens = new List<string>( tokens );

            base.Parse( tokens );

            if ( this.NodeList == null )
            {
                this.NodeList = new List<object>();
            }

            // Allow the custom block to perform actions using the parsed tokens prior to rendering.
            _lavaBlock.OnParsed( blockTokens );
        }

        #endregion

        #region ILiquidFrameworkRenderer implementation

        void ILiquidFrameworkElementRenderer.Render( ILiquidFrameworkElementRenderer baseRenderer, ILavaContext context, TextWriter result )
        {
            // Call the default DotLiquid renderer.
            var dotLiquidContext = ( (DotLiquidLavaContext)context ).DotLiquidContext;

            base.Render( dotLiquidContext, result );
        }

        void ILiquidFrameworkElementRenderer.Parse( ILiquidFrameworkElementRenderer baseRenderer, List<string> tokens, out List<object> nodes )
        {
            base.Parse( tokens );

            nodes = base.NodeList;
        }

        #endregion

    }
}
