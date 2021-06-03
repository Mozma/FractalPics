/*
 * Created by SharpDevelop.
 * User: user
 * Date: 28.11.2019
 * Time: 8:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace FractalPics
{
	partial class Form1
	{		
		private void Form1_Load(object sender, EventArgs e){
			backColor = Color.Black;
			
			bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bit);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			
			goodPen = new Pen(Color.White);
			
		}
		
		
		#region Главные кнопки
		void SimpleTreeButtonClick(object sender, EventArgs e)
		{
			g.Clear(backColor);
			
			float xr = pictureBox1.Width / 2;
			float yr = pictureBox1.Height * 0.9f;
		
			DrawSimpleTree(xr, yr, 350, ang90);
			 
			pictureBox1.Image = bit;
		}
		
		void STreeWithBlowButtonClick(object sender, EventArgs e)
		{
			g.Clear(backColor);
			randomPen = new Pen(Color.FromArgb(255,244,255));
			
			float xr = pictureBox1.Width / 2;
			float yr = pictureBox1.Height * 0.9f;
			double size = trackBar6.Value;
			count = 0;
			getAngle();
			DrawSimpleTreeWithWind(xr, yr, size, ang90, randomPen);
			
			pictureBox1.Image = bit;
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
			g.Clear(backColor);
			
			setPic();
			
			pictureBox1.Image = bit;
		}
		
			
		void Button3Click(object sender, EventArgs e)
		{
			Close();
		}
		
		
		#endregion	
		
		#region trackBar
		void STreeBlowTrackBarScroll(object sender, EventArgs e)
		{
			label1.Text = String.Format("Ang: {0}", STreeBlowTrackBar.Value);
			STreeWithBlowButton.PerformClick();
		}
		
		void TrackBar2Scroll(object sender, EventArgs e)
		{
			label2.Text = String.Format("Ang: {0}", trackBar2.Value);
			STreeWithBlowButton.PerformClick();
		}
	
		void TrackBar4Scroll(object sender, EventArgs e)
		{
			label4.Text = String.Format("Alph: {0}", trackBar4.Value);
			button4.PerformClick();
		}
		
		void TrackBar3Scroll(object sender, EventArgs e)
		{
			label3.Text = String.Format("Dep: {0}", trackBar3.Value);
			button4.PerformClick();
		}
		
		void TrackBar5Scroll(object sender, EventArgs e)
		{
			label5.Text = String.Format("Size: {0}", trackBar5.Value);
			button4.PerformClick();
		}
		
		void TrackBar6Scroll(object sender, EventArgs e)
		{
			label6.Text = String.Format("Size: {0}", trackBar6.Value);
			STreeWithBlowButton.PerformClick();
		}
		#endregion
		
		void PictureBox1Resize(object sender, EventArgs e)
		{
			bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bit);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			
			pictureBox1.Refresh();
		}
		
		
	}
}
