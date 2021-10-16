﻿
//  Copyright (c) 2008 - 2014, www.metabolt.net (METAbolt)
//  All rights reserved.

//  Redistribution and use in source and binary forms, with or without modification, 
//  are permitted provided that the following conditions are met:

//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright notice, 
//    this list of conditions and the following disclaimer in the documentation 
//    and/or other materials provided with the distribution. 
//  * Neither the name METAbolt nor the names of its contributors may be used to 
//    endorse or promote products derived from this software without specific prior 
//    written permission. 

//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
//  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
//  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
//  IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
//  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
//  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
//  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
//  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
//  POSSIBILITY OF SUCH DAMAGE.

#region Using Directives

using System;

using ScintillaNET;
using System.Drawing;

#endregion Using Directives


namespace METAbolt
{
    // A helper class to use the Scintilla container as an INI lexer.
    // We'll ignore the fact that SciLexer.DLL already has an INI capable lexer. ;)
    class IniLexer
    {
        #region Constants

        private const int EOL = -1;

        // SciLexer's weird choice for a default style index
        private const int DEFAULT_STYLE = 32;

        // Our custom styles (indexes chosen not to conflict with anything else)
        private const int KEY_STYLE = 11;
        private const int VALUE_STYLE = 12;
        private const int ASSIGNMENT_STYLE = 13;
        private const int SECTION_STYLE = 14;
        private const int COMMENT_STYLE = 15;
        private const int QUOTED_STYLE = 16;

        #endregion Constants


        #region Fields

        private Scintilla scintilla;
        private int startPos;

        private int index;
        private string text;

        #endregion Fields


        #region Methods

        public static void Init(Scintilla scintilla)
        {
            scintilla.Lexer = Lexer.Container;
            scintilla.LexerLanguage = string.Empty;

            // Add our custom styles to the collection
            scintilla.Styles[QUOTED_STYLE].ForeColor = Color.FromArgb(153, 51, 51);
            scintilla.Styles[KEY_STYLE].ForeColor = Color.FromArgb(0, 0, 153);
            scintilla.Styles[ASSIGNMENT_STYLE].ForeColor = Color.OrangeRed;
            scintilla.Styles[VALUE_STYLE].ForeColor = Color.FromArgb(102, 0, 102);
            scintilla.Styles[COMMENT_STYLE].ForeColor = Color.FromArgb(102, 102, 102);
            scintilla.Styles[SECTION_STYLE].ForeColor = Color.FromArgb(0, 0, 102);
            scintilla.Styles[SECTION_STYLE].Bold = true;
        }


        private int Read()
        {
            if (index < text.Length)
                return text[index];

            return EOL;
        }


        private void SetStyle(int style, int length)
        {
            if (length > 0)
            {
                scintilla.SetStyling(length, style);
            }
        }


        public void Style()
        {
            scintilla.StartStyling(startPos);

            // Run our humble lexer...
            StyleWhitespace();
            switch (Read())
            {
                case '[':

                    // Section, default, comment
                    StyleUntilMatch(SECTION_STYLE, new char[] { ']' });
                    StyleCh(SECTION_STYLE);
                    StyleUntilMatch(DEFAULT_STYLE, new char[] { ';' });
                    goto case ';';

                case ';':

                    // Comment
                    SetStyle(COMMENT_STYLE, text.Length - index);
                    break;

                default:

                    // Key, assignment, quote, value, comment
                    StyleUntilMatch(KEY_STYLE, new char[] { '=', ';' });
                    switch (Read())
                    {
                        case '=':

                            // Assignment, quote, value, comment
                            StyleCh(ASSIGNMENT_STYLE);
                            switch (Read())
                            {
                                case '"':

                                    // Quote
                                    StyleCh(QUOTED_STYLE);  // '"'
                                    StyleUntilMatch(QUOTED_STYLE, new char[] { '"' });

                                    // Make sure it wasn't an escaped quote
                                    if (index > 0 && index < text.Length && text[index - 1] == '\\')
                                        goto case '"';

                                    StyleCh(QUOTED_STYLE); // '"'
                                    goto default;

                                default:

                                    // Value, comment
                                    StyleUntilMatch(VALUE_STYLE, new char[] { ';' });
                                    SetStyle(COMMENT_STYLE, text.Length - index);
                                    break;
                            }
                            break;

                        default: // ';', EOL

                            // Comment
                            SetStyle(COMMENT_STYLE, text.Length - index);
                            break;
                    }
                    break;
            }
        }

        private void StyleCh(int style)
        {
            // Style just one char and advance
            SetStyle(style, 1);
            index++;
        }

        private void StyleUntilMatch(int style, char[] chars)
        {
            // Advance until we match a char in the array
            int startIndex = index;
            while (index < text.Length && Array.IndexOf<char>(chars, text[index]) < 0)
                index++;

            if (startIndex != index)
                SetStyle(style, index - startIndex);
        }

        private void StyleWhitespace()
        {
            // Advance the index until non-whitespace character
            int startIndex = index;
            while (index < text.Length && Char.IsWhiteSpace(text[index]))
                index++;

            SetStyle(DEFAULT_STYLE, index - startIndex);
        }

        #endregion Methods


        #region Constructors

        private IniLexer(Scintilla scintilla, int startPos, int length)
        {
            this.scintilla = scintilla;
            this.startPos = startPos;

            // One line of text
            this.text = scintilla.GetTextRange(startPos, length);
        }

        #endregion Constructors
    }
}