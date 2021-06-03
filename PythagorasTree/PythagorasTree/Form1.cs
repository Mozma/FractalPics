/*
 * Created by SharpDevelop.
 * User: user
 * Date: 24.11.2019
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace FractalPics
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		public Graphics g; 
		public Bitmap bit;
		public Pen goodPen, bestPen, simplePen,randomPen;
		//simplePen = new Pen(Color.White);
		
		public double ang90 = Math.PI / 2;
		public double ang60 = Math.PI / 3;
		public double ang45 = Math.PI / 4; 
		public double ang30 = Math.PI / 6;
		public double angB1, angB2;
		
		public Color backColor;
		
	
		int count;
	
		
		
		#region Методы построения деревьев
		
		public void getAngle(){
		
			angB1 = (Math.PI * Convert.ToDouble(STreeBlowTrackBar.Value)) / 180;
			angB2 = (Math.PI * Convert.ToDouble(trackBar2.Value)) / 180;
		}
		
		public void DrawSimpleTree(double x,double y, double a, double angle){
			if (a > 2){
				a *= 0.65;
				
				double xnew = Math.Round(x + a * Math.Cos(angle));
				double ynew = Math.Round(y - a * Math.Sin(angle));
				g.DrawLine(goodPen, (float)x, (float)y, (float)xnew, (float)ynew);
				
				x = xnew;
				y = ynew;
				
				DrawSimpleTree(x,y,a, angle + ang60);
				DrawSimpleTree(x,y,a, angle - ang60);
				
			}
		}
		
		public void DrawSimpleTreeWithWind(double x,double y, double a, double angle, Pen randomPen){
			if (a > 2){
				a *= 0.7;
				int red = 255, green = 255, blue = 255;
				
				double xnew = Math.Round(x + a * Math.Cos(angle));
				double ynew = Math.Round(y - a * Math.Sin(angle));
				
				g.DrawLine(randomPen, (float)x, (float)y, (float)xnew, (float)ynew);
				
				x = xnew;
				y = ynew;
				
				if(blue - count > 150){
					randomPen = new Pen(Color.FromArgb(red, green - count, blue - count));
					
				}else 
					count = 0;
				count += 1;
				
				DrawSimpleTreeWithWind(x,y,a, angle + angB1, randomPen);
				DrawSimpleTreeWithWind(x,y,a, angle - angB2, randomPen);
				
			}
		}
		
		public void DrawTree( Pen pen, int depth, PointF ll_corner, VectorF v_base, float alpha){
			VectorF v_height = v_base.PerpendicularCCW();
			PointF[] points =
			{
				ll_corner,
				ll_corner + v_base,
				ll_corner + v_base + v_height,
				ll_corner + v_height
			};
			
			g.DrawPolygon(pen,points);
			
			
			
			if(depth > 0){
				//
				//Left Branch
				//
				double w1 = v_base.Length * Math.Cos(alpha);
				
				float wb1 = (float)(w1 * Math.Cos(alpha));
				float wh1 = (float)(w1 * Math.Sin(alpha));
				VectorF v_base1 = v_base.Scale(wb1) + v_height.Scale(wh1);
				
				PointF ll_corner1 = ll_corner + v_height;
			
				DrawTree(pen, depth - 1, ll_corner1, v_base1, alpha);
			
				//
				//Right Branch
				//
				double beta = Math.PI / 2.0 - alpha;
				double w2 = v_base.Length * Math.Sin(alpha);
				
				float wb2 = (float)(w2 * Math.Cos(beta));
				float wh2 = (float)(w2 * Math.Sin(beta));
				VectorF v_base2 = v_base.Scale(wb2) - v_height.Scale(wh2);

			   
				PointF ll_corner2 = ll_corner1 + v_base1;
				
				DrawTree(pen, depth - 1, ll_corner2, v_base2, alpha);
			}
		}
		
		public void setPic(){
			g.Clear(backColor);
			
			int depth = trackBar3.Value;
			int length= trackBar5.Value;
			float alpha = (float)((double)trackBar4.Value * Math.PI / 180.0);
			float root_x = pictureBox1.Width / 2;
			float root_y = pictureBox1.Height * 0.9f;
			VectorF v_base = new VectorF(length, 0);
			PointF ll_corner = new PointF(root_x, root_y) - v_base / 2;
			
		 

			DrawTree(goodPen, depth, ll_corner, v_base, alpha);
		}
		
	
		#endregion
	
			
		
	}
}
