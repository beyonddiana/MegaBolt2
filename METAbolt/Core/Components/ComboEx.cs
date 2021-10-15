﻿//  Copyright (c) 2008 - 2014, www.metabolt.net (METAbolt)
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

using System.Drawing;
using System.Windows.Forms;

namespace METAbolt
{
    public partial class ComboEx : ComboBox
    {
        public ComboEx()
		{
			//Set DrawMode
			this.DrawMode = DrawMode.OwnerDrawFixed;	
		}

		/// <summary>
        /// ImageList Property
		/// </summary>
		public ImageList ICImageList { get; set; } = new ImageList();

        /// <summary>
		/// Override OnDrawItem, To Be able To Draw Images, Text, And Font Formatting
		/// </summary>
		/// <param name="e"></param>
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			e.DrawBackground(); //Draw Background Of Item
			e.DrawFocusRectangle(); //Draw Its rectangle

			if (e.Index < 0) //Do We Have A Valid List ¿

				//Just Draw Indented Text
				e.Graphics.DrawString(this.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + ICImageList.ImageSize.Width, e.Bounds.Top);

			else //We Have A List
			{
				
				if (this.Items[e.Index].GetType() == typeof(ICItem))  //Is It A ImageCombo Item ¿
				{															
					ICItem ICCurrItem = (ICItem)this.Items[e.Index]; //Get Current Item

					//Obtain Current Item's ForeColour
                    Color ICCurrForeColour = (ICCurrItem.ICForeColour != Color.FromKnownColor(KnownColor.Transparent)) ? ICCurrItem.ICForeColour : e.ForeColor;

					//Obtain Current Item's Font
                    Font ICCurrFont = ICCurrItem.ICHighLight ? new Font(e.Font, FontStyle.Bold) : e.Font;

                    if (ICCurrItem.ICImageIndex != -1) //If In Actual List ( Which Needs Images )
                    {
                        //Draw Image
                        this.ICImageList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, ICCurrItem.ICImageIndex);

                        //Then, Draw Text In Specified Bounds
                        e.Graphics.DrawString(ICCurrItem.ICText, ICCurrFont, new SolidBrush(ICCurrForeColour), e.Bounds.Left + ICImageList.ImageSize.Width, e.Bounds.Top);
                    }
                    else //No Image Needed, Index = -1
                    {
                        //Just Draw The Indented Text
                        e.Graphics.DrawString(ICCurrItem.ICText, ICCurrFont, new SolidBrush(ICCurrForeColour), e.Bounds.Left + ICImageList.ImageSize.Width, e.Bounds.Top);
                    }

                    ICCurrFont.Dispose();
				}
				else //Not An ImageCombo Box Item
				
					//Just Draw The Text
					e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + ICImageList.ImageSize.Width, e.Bounds.Top);
				
			}

			base.OnDrawItem (e);
		}

       public class ICItem : object
        {
            public ICItem()
            {
            }

            /// <summary>
            /// Text & Image Index Only
            /// </summary>
            /// <param name="ICIItemText"></param>
            /// <param name="ICImageIndex"></param>
            public ICItem(string ICIItemText, int ICImageIndex) //First Overload
            {
                ICText = ICIItemText; //Text
                this.ICImageIndex = ICImageIndex; //Image Index
            }

            /// <summary>
            /// Text, Image Index, Highlight, ForeColour
            /// </summary>
            /// <param name="ICIItemText"></param>
            /// <param name="ICImageIndex"></param>
            /// <param name="ICHighLight"></param>
            /// <param name="ICForeColour"></param>
            public ICItem(string ICIItemText, int ICImageIndex, bool ICHighLight, Color ICForeColour) //Second Overload
            {
                ICText = ICIItemText; //Text
                this.ICImageIndex = ICImageIndex; //Image Index
                this.ICHighLight = ICHighLight; //Highlighted ¿
                this.ICForeColour = ICForeColour; //ForeColour
            }

            /// <summary>
            /// ImageCombo Item Text
            /// </summary>
            public string ICText { get; set; } = null;

            /// <summary>
            /// Image Index
            /// </summary>
            public int ICImageIndex { get; set; } = -1;

            /// <summary>
            /// Highlighted ¿
            /// </summary>
            public bool ICHighLight { get; set; } = false;

            /// <summary>
            /// ForeColour
            /// </summary>
            public Color ICForeColour { get; set; } = Color.FromKnownColor(KnownColor.Transparent);

            /// <summary>
            /// Override ToString To Return Item Text
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return ICText;
            }
        }
    }
}
