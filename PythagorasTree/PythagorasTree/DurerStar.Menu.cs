using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FractalPics
{
	partial class DurerStarForm
	{	
		void PenColorToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(colorDialog1.ShowDialog() != DialogResult.Cancel){
				goodPen = null;
				br = new SolidBrush (colorDialog1.Color);
			}
		}
		
		void BackgroundColorToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(colorDialog1.ShowDialog() != DialogResult.Cancel){
				backColor = colorDialog1.Color;
				g.Clear(backColor);
				
				pictureBox1.Image = bit;
			}
		}
		
		void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Images|*.png;*.bmp;*.jpg";
			ImageFormat format = ImageFormat.Png;
			if (sfd.ShowDialog() == DialogResult.OK)
			{
			    string ext = System.IO.Path.GetExtension(sfd.FileName);
			    switch (ext)
			    {
			        case ".jpg":
			            format = ImageFormat.Jpeg;
			            break;
			        case ".bmp":
			            format = ImageFormat.Bmp;
			            break;
			    }
			    pictureBox1.Image.Save(sfd.FileName, format);
			}
		}
	}
}
