/*
 * Created by SharpDevelop.
 * User: user
 * Date: 24.11.2019
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PythagorasTree
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SimpleTreeButton = new System.Windows.Forms.Button();
			this.STreeWithBlowButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.STreeBlowTrackBar = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.trackBar4 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.trackBar5 = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label6 = new System.Windows.Forms.Label();
			this.trackBar6 = new System.Windows.Forms.TrackBar();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.STreeBlowTrackBar)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.MinimumSize = new System.Drawing.Size(500, 500);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(784, 586);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Resize += new System.EventHandler(this.PictureBox1Resize);
			// 
			// SimpleTreeButton
			// 
			this.SimpleTreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SimpleTreeButton.BackColor = System.Drawing.Color.White;
			this.SimpleTreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SimpleTreeButton.Location = new System.Drawing.Point(790, 27);
			this.SimpleTreeButton.Name = "SimpleTreeButton";
			this.SimpleTreeButton.Size = new System.Drawing.Size(125, 23);
			this.SimpleTreeButton.TabIndex = 1;
			this.SimpleTreeButton.Text = "Simple tree";
			this.SimpleTreeButton.UseVisualStyleBackColor = false;
			this.SimpleTreeButton.Click += new System.EventHandler(this.SimpleTreeButtonClick);
			// 
			// STreeWithBlowButton
			// 
			this.STreeWithBlowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.STreeWithBlowButton.BackColor = System.Drawing.Color.White;
			this.STreeWithBlowButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.STreeWithBlowButton.Location = new System.Drawing.Point(790, 56);
			this.STreeWithBlowButton.Name = "STreeWithBlowButton";
			this.STreeWithBlowButton.Size = new System.Drawing.Size(125, 23);
			this.STreeWithBlowButton.TabIndex = 2;
			this.STreeWithBlowButton.Text = "Simple tree with blow";
			this.STreeWithBlowButton.UseVisualStyleBackColor = false;
			this.STreeWithBlowButton.Click += new System.EventHandler(this.STreeWithBlowButtonClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.trackBar2);
			this.groupBox1.Controls.Add(this.STreeBlowTrackBar);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(790, 86);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(125, 171);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "blow";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(62, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ang: 0";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar2
			// 
			this.trackBar2.AccessibleDescription = "";
			this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBar2.Location = new System.Drawing.Point(74, 36);
			this.trackBar2.Maximum = 90;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar2.Size = new System.Drawing.Size(45, 129);
			this.trackBar2.TabIndex = 2;
			this.trackBar2.TickFrequency = 10;
			this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2Scroll);
			// 
			// STreeBlowTrackBar
			// 
			this.STreeBlowTrackBar.AccessibleDescription = "";
			this.STreeBlowTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.STreeBlowTrackBar.Location = new System.Drawing.Point(11, 36);
			this.STreeBlowTrackBar.Maximum = 90;
			this.STreeBlowTrackBar.Name = "STreeBlowTrackBar";
			this.STreeBlowTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.STreeBlowTrackBar.Size = new System.Drawing.Size(45, 129);
			this.STreeBlowTrackBar.TabIndex = 4;
			this.STreeBlowTrackBar.Scroll += new System.EventHandler(this.STreeBlowTrackBarScroll);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ang: 0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Location = new System.Drawing.Point(790, 582);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Back";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Location = new System.Drawing.Point(790, 317);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(125, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Tree";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.trackBar3);
			this.groupBox2.Controls.Add(this.trackBar4);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(790, 346);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(125, 171);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Param";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(70, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Dep: 0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar3
			// 
			this.trackBar3.AccessibleDescription = "";
			this.trackBar3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBar3.Location = new System.Drawing.Point(74, 36);
			this.trackBar3.Maximum = 15;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar3.Size = new System.Drawing.Size(45, 129);
			this.trackBar3.TabIndex = 2;
			this.trackBar3.Value = 11;
			this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3Scroll);
			// 
			// trackBar4
			// 
			this.trackBar4.AccessibleDescription = "";
			this.trackBar4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBar4.Location = new System.Drawing.Point(11, 36);
			this.trackBar4.Maximum = 90;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar4.Size = new System.Drawing.Size(45, 129);
			this.trackBar4.TabIndex = 1;
			this.trackBar4.TickFrequency = 10;
			this.trackBar4.Value = 50;
			this.trackBar4.Scroll += new System.EventHandler(this.TrackBar4Scroll);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Alph: 0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar5
			// 
			this.trackBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar5.BackColor = System.Drawing.Color.White;
			this.trackBar5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBar5.Location = new System.Drawing.Point(790, 523);
			this.trackBar5.Maximum = 200;
			this.trackBar5.Minimum = 50;
			this.trackBar5.Name = "trackBar5";
			this.trackBar5.Size = new System.Drawing.Size(125, 45);
			this.trackBar5.TabIndex = 7;
			this.trackBar5.TickFrequency = 10;
			this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar5.Value = 50;
			this.trackBar5.Scroll += new System.EventHandler(this.TrackBar5Scroll);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(790, 553);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Size:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(924, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.saveAsToolStripMenuItem.Text = "Save as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.penColorToolStripMenuItem,
									this.backgroundColorToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// penColorToolStripMenuItem
			// 
			this.penColorToolStripMenuItem.Name = "penColorToolStripMenuItem";
			this.penColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.penColorToolStripMenuItem.Text = "Pen color";
			this.penColorToolStripMenuItem.Click += new System.EventHandler(this.PenColorToolStripMenuItemClick);
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.backgroundColorToolStripMenuItem.Text = "Background color";
			this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.BackgroundColorToolStripMenuItemClick);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(790, 293);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Size:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar6
			// 
			this.trackBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar6.BackColor = System.Drawing.Color.White;
			this.trackBar6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBar6.Location = new System.Drawing.Point(790, 263);
			this.trackBar6.Maximum = 370;
			this.trackBar6.Minimum = 100;
			this.trackBar6.Name = "trackBar6";
			this.trackBar6.Size = new System.Drawing.Size(125, 45);
			this.trackBar6.TabIndex = 10;
			this.trackBar6.TickFrequency = 10;
			this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar6.Value = 100;
			this.trackBar6.Scroll += new System.EventHandler(this.TrackBar6Scroll);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(924, 610);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.trackBar6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.trackBar5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.STreeWithBlowButton);
			this.Controls.Add(this.SimpleTreeButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(940, 649);
			this.Name = "Form1";
			this.Text = "PythagorasTree";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.STreeBlowTrackBar)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TrackBar STreeBlowTrackBar;
		private System.Windows.Forms.Button STreeWithBlowButton;
		private System.Windows.Forms.Button SimpleTreeButton;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.TrackBar trackBar6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar trackBar5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar trackBar4;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		
	}
}
