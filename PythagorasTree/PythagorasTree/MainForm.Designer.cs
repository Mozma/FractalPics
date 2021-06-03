/*
 * Created by SharpDevelop.
 * User: user
 * Date: 24.11.2019
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FractalPics
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PythagorasButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.DurerStarButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PythagorasButton
			// 
			this.PythagorasButton.BackColor = System.Drawing.Color.White;
			this.PythagorasButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PythagorasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PythagorasButton.Location = new System.Drawing.Point(12, 183);
			this.PythagorasButton.Name = "PythagorasButton";
			this.PythagorasButton.Size = new System.Drawing.Size(167, 22);
			this.PythagorasButton.TabIndex = 4;
			this.PythagorasButton.Text = "Pythagoras Tree";
			this.PythagorasButton.UseVisualStyleBackColor = false;
			this.PythagorasButton.MouseLeave += new System.EventHandler(this.PythagorasButtonMouseLeave);
			this.PythagorasButton.Click += new System.EventHandler(this.PythagorasButtonClick);
			this.PythagorasButton.MouseEnter += new System.EventHandler(this.PythagorasButtonMouseEnter);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 240);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.DurerStarButton);
			this.panel3.Controls.Add(this.PythagorasButton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(192, 240);
			this.panel3.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(195, 179);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// DurerStarButton
			// 
			this.DurerStarButton.BackColor = System.Drawing.Color.White;
			this.DurerStarButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DurerStarButton.Location = new System.Drawing.Point(12, 211);
			this.DurerStarButton.Name = "DurerStarButton";
			this.DurerStarButton.Size = new System.Drawing.Size(167, 23);
			this.DurerStarButton.TabIndex = 5;
			this.DurerStarButton.Text = "Durer Star";
			this.DurerStarButton.UseVisualStyleBackColor = false;
			this.DurerStarButton.MouseLeave += new System.EventHandler(this.DurerStarButtonMouseLeave);
			this.DurerStarButton.Click += new System.EventHandler(this.DurerStarButtonClick);
			this.DurerStarButton.MouseEnter += new System.EventHandler(this.DurerStarButtonMouseEnter);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(310, 240);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "FractalPics";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button DurerStarButton;
		private System.Windows.Forms.Button PythagorasButton;
		private System.Windows.Forms.Panel panel1;
	}
}
