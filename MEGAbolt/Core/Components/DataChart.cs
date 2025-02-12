/****************************************************************************************************************
(C) Copyright 2007 Zuoliu Ding.  All Rights Reserved.
DataChart.cs:		class DataChart
Created by:			Zuoliu Ding, 05/20/2006
Note:				Line Chart Custom control 
****************************************************************************************************************/

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace SystemMonitor
{
	/// <summary>
	/// Summary description for DataChart.
	/// </summary>
	public class DataChart : UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private Container components = null;
		private ArrayList _arrayList;

        #region Constructor/Dispose
		public DataChart()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			BackColor = Color.Silver;

			LineColor = Color.DarkBlue;
			GridColor = Color.Yellow;

			InitialHeight = 1000;
			GridPixels = 0;
			ChartType = ChartType.Stick;

			_arrayList = new ArrayList();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
            {
                components?.Dispose();
            }
			base.Dispose( disposing );
		}
		#endregion

		public void UpdateChart(double d)
		{
			Rectangle rt = ClientRectangle;
			int dataCount = rt.Width/2;

			if (_arrayList.Count >= dataCount) 
				_arrayList.RemoveAt(0);

			_arrayList.Add(d);

			Invalidate();
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Name = "DataChart";
			this.Size = new System.Drawing.Size(150, 16);
		}
		#endregion

		#region "Properties"

		[Description("Gets or sets the current Line Color in chart"), Category("DataChart")]
		public Color LineColor { get; set; }

        [Description("Gets or sets the current Grid Color in chart"), Category("DataChart")]
		public Color GridColor { get; set; }

        [Description("Gets or sets the initial maximum Height for sticks in chart"), Category("DataChart")]
		public int InitialHeight { get; set; }

        [Description("Gets or sets the current chart Type for stick or Line"), Category("DataChart")]
		public ChartType ChartType { get; set; }

        [Description("Enables grid drawing with spacing of the Pixel number"), Category("DataChart")]
		public int GridPixels { get; set; }

        #endregion

		#region Drawing
		protected override void OnPaint(PaintEventArgs e)
		{
			int count = _arrayList.Count;
			if (count==0) return;

			double y=0, yMax = InitialHeight;
			for (int i=0; i<count; i++)
			{
                y = Convert.ToDouble(_arrayList[i], CultureInfo.CurrentCulture);
				if (y>yMax) yMax = y;
			}

			Rectangle rt = ClientRectangle;
			y = yMax==0? 1: rt.Height/yMax;		// y ratio

			int xStart = rt.Width;
			int yStart = rt.Height;
			int nX, nY;

			Pen pen = null;
			e.Graphics.Clear(BackColor);

			if (GridPixels!=0)
			{
				pen = new Pen(GridColor, 1);
				nX = rt.Width/GridPixels;
				nY = rt.Height/GridPixels;

				for (int i=1; i<=nX; i++)
					e.Graphics.DrawLine(pen, i*GridPixels, 0, i*GridPixels, yStart);

				for (int i=1; i<nY; i++)
					e.Graphics.DrawLine(pen, 0, i*GridPixels, xStart, i*GridPixels);
			}

			// From the most recent data, so X <--------------|	
			// Get data from _arrayList	 a[0]..<--...a[count-1]
		
			if (ChartType==ChartType.Stick)
			{	
				pen = new Pen(LineColor, 2);

				for (int i=count-1; i>=0; i--)
				{
					nX = xStart - 2*(count-i);
					if (nX<=0) break;

                    nY = (int)(yStart - y * Convert.ToDouble(_arrayList[i], CultureInfo.CurrentCulture));
					e.Graphics.DrawLine(pen, nX, yStart, nX, nY);
				}
			}
			else
			if (ChartType==ChartType.Line)
			{	
				pen = new Pen(LineColor, 1);

				int nX0 = xStart - 2;
                int nY0 = (int)(yStart - y * Convert.ToDouble(_arrayList[count - 1], CultureInfo.CurrentCulture));
				for (int i=count-2; i>=0; i--)
				{
					nX = xStart - 2*(count-i);
					if (nX<=0) break;

                    nY = (int)(yStart - y * Convert.ToDouble(_arrayList[i], CultureInfo.CurrentCulture));
					e.Graphics.DrawLine(pen, nX0, nY0, nX, nY);

					nX0 = nX;
					nY0 = nY;
				}
			}

			base.OnPaint(e);
		}
		#endregion
	}

	public enum ChartType { Stick, Line }

}
