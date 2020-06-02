namespace MineSweeper
{
	partial class MineSweeperForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tileGrid = new MineSweeper.MineSweeperForm.TileGrid();
			this.gameButton = new System.Windows.Forms.PictureBox();
			this.flagCounter = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuStrip_Game = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Game_New = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Game_Break1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip_Game_Beginner = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Game_Intermediate = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Game_Expert = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Game_Break2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip_Game_Exit = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.gameButton)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tileGrid
			// 
			this.tileGrid.Location = new System.Drawing.Point(72, 107);
			this.tileGrid.Name = "tileGrid";
			this.tileGrid.Size = new System.Drawing.Size(400, 249);
			this.tileGrid.TabIndex = 0;
			// 
			// gameButton
			// 
			this.gameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gameButton.BackgroundImage = global::MineSweeper.Properties.Resources.GameButton;
			this.gameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.gameButton.Location = new System.Drawing.Point(331, 40);
			this.gameButton.Name = "gameButton";
			this.gameButton.Size = new System.Drawing.Size(35, 35);
			this.gameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.gameButton.TabIndex = 0;
			this.gameButton.TabStop = false;
			this.gameButton.Click += new System.EventHandler(this.LoadGame);
			// 
			// flagCounter
			// 
			this.flagCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flagCounter.AutoSize = true;
			this.flagCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flagCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.flagCounter.Location = new System.Drawing.Point(389, 35);
			this.flagCounter.Name = "flagCounter";
			this.flagCounter.Size = new System.Drawing.Size(105, 40);
			this.flagCounter.TabIndex = 1;
			this.flagCounter.Text = "label1";
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(581, 28);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuStrip_Game
			// 
			this.menuStrip_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_New,
            this.menuStrip_Game_Break1,
            this.menuStrip_Game_Beginner,
            this.menuStrip_Game_Intermediate,
            this.menuStrip_Game_Expert,
            this.menuStrip_Game_Break2,
            this.menuStrip_Game_Exit});
			this.menuStrip_Game.Name = "menuStrip_Game";
			this.menuStrip_Game.Size = new System.Drawing.Size(62, 26);
			this.menuStrip_Game.Text = "Game";
			// 
			// menuStrip_Game_New
			// 
			this.menuStrip_Game_New.Name = "menuStrip_Game_New";
			this.menuStrip_Game_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuStrip_Game_New.Size = new System.Drawing.Size(224, 26);
			this.menuStrip_Game_New.Text = "New";
			this.menuStrip_Game_New.Click += new System.EventHandler(this.MenuStrip_Game_New_Click);
			// 
			// menuStrip_Game_Break1
			// 
			this.menuStrip_Game_Break1.Name = "menuStrip_Game_Break1";
			this.menuStrip_Game_Break1.Size = new System.Drawing.Size(221, 6);
			// 
			// menuStrip_Game_Beginner
			// 
			this.menuStrip_Game_Beginner.Name = "menuStrip_Game_Beginner";
			this.menuStrip_Game_Beginner.Size = new System.Drawing.Size(224, 26);
			this.menuStrip_Game_Beginner.Tag = "Beginner";
			this.menuStrip_Game_Beginner.Text = "Beginner";
			this.menuStrip_Game_Beginner.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
			// 
			// menuStrip_Game_Intermediate
			// 
			this.menuStrip_Game_Intermediate.Name = "menuStrip_Game_Intermediate";
			this.menuStrip_Game_Intermediate.Size = new System.Drawing.Size(224, 26);
			this.menuStrip_Game_Intermediate.Tag = "Intermediate";
			this.menuStrip_Game_Intermediate.Text = "Intermedate";
			this.menuStrip_Game_Intermediate.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
			// 
			// menuStrip_Game_Expert
			// 
			this.menuStrip_Game_Expert.Name = "menuStrip_Game_Expert";
			this.menuStrip_Game_Expert.Size = new System.Drawing.Size(224, 26);
			this.menuStrip_Game_Expert.Tag = "Expert";
			this.menuStrip_Game_Expert.Text = "Expert";
			this.menuStrip_Game_Expert.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
			// 
			// menuStrip_Game_Break2
			// 
			this.menuStrip_Game_Break2.Name = "menuStrip_Game_Break2";
			this.menuStrip_Game_Break2.Size = new System.Drawing.Size(221, 6);
			// 
			// menuStrip_Game_Exit
			// 
			this.menuStrip_Game_Exit.Name = "menuStrip_Game_Exit";
			this.menuStrip_Game_Exit.Size = new System.Drawing.Size(224, 26);
			this.menuStrip_Game_Exit.Tag = "Exit";
			this.menuStrip_Game_Exit.Text = "Exit";
			this.menuStrip_Game_Exit.Click += new System.EventHandler(this.MenuStrip_Game_Exit_Click);
			// 
			// MineSweeperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 460);
			this.Controls.Add(this.flagCounter);
			this.Controls.Add(this.tileGrid);
			this.Controls.Add(this.gameButton);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MineSweeperForm";
			this.Text = "MineSweeper";
			((System.ComponentModel.ISupportInitialize)(this.gameButton)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TileGrid tileGrid;
		private System.Windows.Forms.PictureBox gameButton;
		private System.Windows.Forms.Label flagCounter;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Game;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_New;
		private System.Windows.Forms.ToolStripSeparator menuStrip_Game_Break1;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Beginner;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Intermediate;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Expert;
		private System.Windows.Forms.ToolStripSeparator menuStrip_Game_Break2;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Exit;
	}
}

