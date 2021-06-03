/*
 * Created by SharpDevelop.
 * User: user
 * Date: 24.11.2019
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalPics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		
		}
		
		Image img1 = Image.FromFile("PythTree.png");
		Image img2 = Image.FromFile("DurStar.png");
		Image img3 = Image.FromFile("FractalPics.png");
		
		
		void PythagorasButtonClick(object sender, EventArgs e)
		{
			Hide();
			Form1 form = null;
			
			if (form == null) // Если форма не существует, то создаём
			{
				form = new Form1(); // Создание нового экземпляра формы
				form.ShowDialog(); // Отображаем форму
			}
			else
				form.Activate();
			
			Show();
		}
		
		void DurerStarButtonClick(object sender, EventArgs e)
		{
			Hide();
			DurerStarForm form = null;
			
			if (form == null)
			{
				form = new DurerStarForm();
				form.ShowDialog();
			}
			else
				form.Activate();
			
			Show();
		}
		
		
		
		void PythagorasButtonMouseEnter(object sender, EventArgs e)
		{
			pictureBox1.Image = img1;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			
		}
		
		void PythagorasButtonMouseLeave(object sender, EventArgs e)
		{
			pictureBox1.Image = img3;
		}
		
		void DurerStarButtonMouseEnter(object sender, EventArgs e)
		{
			pictureBox1.Image = img2;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		void DurerStarButtonMouseLeave(object sender, EventArgs e)
		{
			pictureBox1.Image = img3;
		}
	}
}
