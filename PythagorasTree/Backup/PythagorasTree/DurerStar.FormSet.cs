/*
 * Created by SharpDevelop.
 * User: user
 * Date: 29.11.2019
 * Time: 22:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;

namespace PythagorasTree
{
	partial class DurerStarForm
	{
		void DurerStarFormLoad(object sender, EventArgs e)
		{
			backColor = Color.White;
			
			bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bit);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			
			
			goodPen = new Pen(Color.White);
		}
		
		
		
		
		void DurerStarButtonClick(object sender, EventArgs e)
		{
			g.Clear(backColor);
		
			Draw_Star(pictureBox1.Width / 2, (pictureBox1.Height / 2) + 30, DurerStarTrackBar.Value, pi / 2, DepthTrackBar.Value);
			
			
		}
		
		void BackButtonClick(object sender, System.EventArgs e)
		{
			Close();
		}
		
		void DurerStarFormResize(object sender, EventArgs e)
		{
			bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bit);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			g.Clear(backColor);
			
			pictureBox1.Refresh();
		}
		
		
		
		void DurerStarTrackBarScroll(object sender, EventArgs e)
		{
			SizeLabel.Text = String.Format("Size: {0}", DurerStarTrackBar.Value);
        	DurerStarButton.PerformClick();
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			DepthLabel.Text = String.Format("Depth: {0}", DepthTrackBar.Value);
        	DurerStarButton.PerformClick();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			DurerStarButton.PerformClick();
		}
	}
}