using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalPics
{
	public partial class DurerStarForm : Form
	{
		public DurerStarForm()
		{
			InitializeComponent();
		}
		
		private Graphics g;
		private Bitmap bit;
		private Pen goodPen; // bestPen, simplePen,randomPen;
		private SolidBrush br = new SolidBrush(Color.Black);

		private Color backColor = Color.White;
	
		double pi = Math.PI;
	
		/// <summary>
		/// Метод, который рисует пятиугольник
		/// </summary>

		public void Draw_Pentagon(double x, double y, double r, double angle, double depth){
			goodPen = new Pen(Color.Black, 1);	
	
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			int i;

			double[] x1 = new double[5];
			double[] y1 = new double[5];
			PointF[] tmp = new PointF[5];
			
			
			for (i = 0; i < 5; i++)
			{
				x1[i] = r * Math.Cos(angle + i * pi * 2 / 5);
				y1[i] = r * Math.Sin(angle + i * pi * 2 / 5);
				tmp[i] = new PointF((float)(x+x1[i]),(float)(y+y1[i]));
			}
			
			if(depth == 0){
				g.FillPolygon(br, tmp);
			}
			if(checkBox1.Checked){
				for (i = 0; i < 4; i++)
				{
					g.DrawLine(goodPen, (int)Math.Round(x + x1[i]), (int)Math.Round(y + y1[i]), (int)Math.Round(x + x1[i + 1]), (int)Math.Round(y + y1[i + 1]));
				}
				g.DrawLine(goodPen, (int)Math.Round(x + x1[4]), (int)Math.Round(y + y1[4]), (int)Math.Round(x + x1[0]), (int)Math.Round(y + y1[0]));
			}
		}
		

		/// <summary>
		/// Метод, который рисует звезду
		/// </summary>
		public  void Draw_Star(double x, double y, double r, double angle, int depth){
			int i;
			double h;
 
			h = 2 * r * Math.Cos(pi / 5);
 
			for (i = 0; i < 5; i++)
			{
				Draw_Pentagon(x - h * Math.Cos(angle + i * pi * 2 / 5), y - h * Math.Sin(angle + i * pi * 2 / 5), r, angle + pi + i * pi * 2 / 5, depth);
 
				if (depth > 0)
					Draw_Star(x - h * Math.Cos(angle + i * pi * 2 / 5), y - h * Math.Sin(angle + i * pi * 2 / 5), r / (2 * Math.Cos(pi / 5) + 1), angle + pi + (2 * i + 1) * pi * 2 / 10, depth - 1);
			}
			
			Draw_Pentagon(x, y, r, angle, depth);
 
			if (depth > 0)
				Draw_Star(x, y, r / (2 * Math.Cos(pi / 5) + 1), angle + pi, depth - 1);
		   
			 pictureBox1.Image = bit;
		  
		}
	}
}
