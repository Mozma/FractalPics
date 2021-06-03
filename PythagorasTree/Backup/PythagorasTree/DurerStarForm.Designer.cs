/*
 * Created by SharpDevelop.
 * User: user
 * Date: 29.11.2019
 * Time: 21:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PythagorasTree
{
	partial class DurerStarForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurerStarForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.penColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DurerStarButton = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.backButton = new System.Windows.Forms.Button();
			this.SizeLabel = new System.Windows.Forms.Label();
			this.DurerStarTrackBar = new System.Windows.Forms.TrackBar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.DepthLabel = new System.Windows.Forms.Label();
			this.DepthTrackBar = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DurerStarTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DepthTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(636, 630);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 10;
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
			this.penColorToolStripMenuItem.Text = "Brush color";
			this.penColorToolStripMenuItem.Click += new System.EventHandler(this.PenColorToolStripMenuItemClick);
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.backgroundColorToolStripMenuItem.Text = "Background color";
			this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.BackgroundColorToolStripMenuItemClick);
			// 
			// DurerStarButton
			// 
			this.DurerStarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DurerStarButton.BackColor = System.Drawing.Color.White;
			this.DurerStarButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DurerStarButton.Location = new System.Drawing.Point(650, 52);
			this.DurerStarButton.Name = "DurerStarButton";
			this.DurerStarButton.Size = new System.Drawing.Size(122, 23);
			this.DurerStarButton.TabIndex = 11;
			this.DurerStarButton.Text = "Durer Star";
			this.DurerStarButton.UseVisualStyleBackColor = false;
			this.DurerStarButton.Click += new System.EventHandler(this.DurerStarButtonClick);
			// 
			// backButton
			// 
			this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.backButton.BackColor = System.Drawing.Color.White;
			this.backButton.Location = new System.Drawing.Point(650, 619);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(122, 23);
			this.backButton.TabIndex = 12;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// SizeLabel
			// 
			this.SizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SizeLabel.BackColor = System.Drawing.Color.White;
			this.SizeLabel.Location = new System.Drawing.Point(650, 111);
			this.SizeLabel.Name = "SizeLabel";
			this.SizeLabel.Size = new System.Drawing.Size(122, 15);
			this.SizeLabel.TabIndex = 14;
			this.SizeLabel.Text = "Size:";
			this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DurerStarTrackBar
			// 
			this.DurerStarTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DurerStarTrackBar.BackColor = System.Drawing.Color.White;
			this.DurerStarTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DurerStarTrackBar.Location = new System.Drawing.Point(650, 81);
			this.DurerStarTrackBar.Maximum = 500;
			this.DurerStarTrackBar.Minimum = 100;
			this.DurerStarTrackBar.Name = "DurerStarTrackBar";
			this.DurerStarTrackBar.Size = new System.Drawing.Size(122, 45);
			this.DurerStarTrackBar.TabIndex = 13;
			this.DurerStarTrackBar.TickFrequency = 15;
			this.DurerStarTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.DurerStarTrackBar.Value = 100;
			this.DurerStarTrackBar.Scroll += new System.EventHandler(this.DurerStarTrackBarScroll);
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.checkBox1.Location = new System.Drawing.Point(650, 183);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(122, 24);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "Контур";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// DepthLabel
			// 
			this.DepthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DepthLabel.BackColor = System.Drawing.Color.White;
			this.DepthLabel.Location = new System.Drawing.Point(650, 162);
			this.DepthLabel.Name = "DepthLabel";
			this.DepthLabel.Size = new System.Drawing.Size(122, 15);
			this.DepthLabel.TabIndex = 17;
			this.DepthLabel.Text = "Depth:";
			this.DepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DepthTrackBar
			// 
			this.DepthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DepthTrackBar.BackColor = System.Drawing.Color.White;
			this.DepthTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DepthTrackBar.Location = new System.Drawing.Point(650, 132);
			this.DepthTrackBar.Maximum = 6;
			this.DepthTrackBar.Minimum = 1;
			this.DepthTrackBar.Name = "DepthTrackBar";
			this.DepthTrackBar.Size = new System.Drawing.Size(122, 45);
			this.DepthTrackBar.TabIndex = 16;
			this.DepthTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.DepthTrackBar.Value = 1;
			this.DepthTrackBar.Scroll += new System.EventHandler(this.TrackBar1Scroll);
			// 
			// DurerStarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(784, 654);
			this.Controls.Add(this.DepthLabel);
			this.Controls.Add(this.DepthTrackBar);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.SizeLabel);
			this.Controls.Add(this.DurerStarTrackBar);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.DurerStarButton);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.Name = "DurerStarForm";
			this.Text = "DurerStarForm";
			this.Load += new System.EventHandler(this.DurerStarFormLoad);
			this.Resize += new System.EventHandler(this.DurerStarFormResize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DurerStarTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DepthTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label DepthLabel;
		private System.Windows.Forms.TrackBar DepthTrackBar;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label SizeLabel;
		private System.Windows.Forms.TrackBar DurerStarTrackBar;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button DurerStarButton;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem penColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		
	}
}
