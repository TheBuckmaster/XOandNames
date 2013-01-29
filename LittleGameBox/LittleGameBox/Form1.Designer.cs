namespace LittleGameBox
{
    partial class Form1
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
            this.UpLeft = new System.Windows.Forms.Button();
            this.UpCenter = new System.Windows.Forms.Button();
            this.UpRight = new System.Windows.Forms.Button();
            this.MidLeft = new System.Windows.Forms.Button();
            this.MidCenter = new System.Windows.Forms.Button();
            this.MidRight = new System.Windows.Forms.Button();
            this.LowLeft = new System.Windows.Forms.Button();
            this.LowCenter = new System.Windows.Forms.Button();
            this.LowRight = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpLeft
            // 
            this.UpLeft.Location = new System.Drawing.Point(26, 27);
            this.UpLeft.Name = "UpLeft";
            this.UpLeft.Size = new System.Drawing.Size(101, 98);
            this.UpLeft.TabIndex = 0;
            this.UpLeft.UseVisualStyleBackColor = true;
            this.UpLeft.Click += new System.EventHandler(this.UpLeft_Click);
            // 
            // UpCenter
            // 
            this.UpCenter.Location = new System.Drawing.Point(133, 27);
            this.UpCenter.Name = "UpCenter";
            this.UpCenter.Size = new System.Drawing.Size(101, 98);
            this.UpCenter.TabIndex = 1;
            this.UpCenter.UseVisualStyleBackColor = true;
            this.UpCenter.Click += new System.EventHandler(this.UpCenter_Click);
            // 
            // UpRight
            // 
            this.UpRight.Location = new System.Drawing.Point(240, 27);
            this.UpRight.Name = "UpRight";
            this.UpRight.Size = new System.Drawing.Size(101, 98);
            this.UpRight.TabIndex = 2;
            this.UpRight.UseVisualStyleBackColor = true;
            this.UpRight.Click += new System.EventHandler(this.UpRight_Click);
            // 
            // MidLeft
            // 
            this.MidLeft.Location = new System.Drawing.Point(26, 131);
            this.MidLeft.Name = "MidLeft";
            this.MidLeft.Size = new System.Drawing.Size(101, 98);
            this.MidLeft.TabIndex = 3;
            this.MidLeft.UseVisualStyleBackColor = true;
            this.MidLeft.Click += new System.EventHandler(this.MidLeft_Click);
            // 
            // MidCenter
            // 
            this.MidCenter.Location = new System.Drawing.Point(133, 131);
            this.MidCenter.Name = "MidCenter";
            this.MidCenter.Size = new System.Drawing.Size(101, 98);
            this.MidCenter.TabIndex = 4;
            this.MidCenter.UseVisualStyleBackColor = true;
            this.MidCenter.Click += new System.EventHandler(this.MidCenter_Click);
            // 
            // MidRight
            // 
            this.MidRight.Location = new System.Drawing.Point(240, 131);
            this.MidRight.Name = "MidRight";
            this.MidRight.Size = new System.Drawing.Size(101, 98);
            this.MidRight.TabIndex = 5;
            this.MidRight.UseVisualStyleBackColor = true;
            this.MidRight.Click += new System.EventHandler(this.MidRight_Click);
            // 
            // LowLeft
            // 
            this.LowLeft.Location = new System.Drawing.Point(26, 235);
            this.LowLeft.Name = "LowLeft";
            this.LowLeft.Size = new System.Drawing.Size(101, 98);
            this.LowLeft.TabIndex = 6;
            this.LowLeft.UseVisualStyleBackColor = true;
            this.LowLeft.Click += new System.EventHandler(this.LowLeft_Click);
            // 
            // LowCenter
            // 
            this.LowCenter.Location = new System.Drawing.Point(133, 235);
            this.LowCenter.Name = "LowCenter";
            this.LowCenter.Size = new System.Drawing.Size(101, 98);
            this.LowCenter.TabIndex = 7;
            this.LowCenter.UseVisualStyleBackColor = true;
            this.LowCenter.Click += new System.EventHandler(this.LowCenter_Click);
            // 
            // LowRight
            // 
            this.LowRight.Location = new System.Drawing.Point(240, 235);
            this.LowRight.Name = "LowRight";
            this.LowRight.Size = new System.Drawing.Size(101, 98);
            this.LowRight.TabIndex = 8;
            this.LowRight.UseVisualStyleBackColor = true;
            this.LowRight.Click += new System.EventHandler(this.LowRight_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setPlayersToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Enabled = false;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // setPlayersToolStripMenuItem
            // 
            this.setPlayersToolStripMenuItem.Name = "setPlayersToolStripMenuItem";
            this.setPlayersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setPlayersToolStripMenuItem.Text = "Set Players";
            this.setPlayersToolStripMenuItem.Click += new System.EventHandler(this.setPlayersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 345);
            this.Controls.Add(this.LowRight);
            this.Controls.Add(this.LowCenter);
            this.Controls.Add(this.LowLeft);
            this.Controls.Add(this.MidRight);
            this.Controls.Add(this.MidCenter);
            this.Controls.Add(this.MidLeft);
            this.Controls.Add(this.UpRight);
            this.Controls.Add(this.UpCenter);
            this.Controls.Add(this.UpLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpLeft;
        private System.Windows.Forms.Button UpCenter;
        private System.Windows.Forms.Button UpRight;
        private System.Windows.Forms.Button MidLeft;
        private System.Windows.Forms.Button MidCenter;
        private System.Windows.Forms.Button MidRight;
        private System.Windows.Forms.Button LowLeft;
        private System.Windows.Forms.Button LowCenter;
        private System.Windows.Forms.Button LowRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPlayersToolStripMenuItem;
    }
}

