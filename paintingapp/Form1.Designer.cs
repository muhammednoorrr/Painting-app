namespace paintingapp
{
    partial class MyPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Black_Btn = new System.Windows.Forms.ToolStripButton();
            this.Red_Btn = new System.Windows.Forms.ToolStripButton();
            this.Yellow_Btn = new System.Windows.Forms.ToolStripButton();
            this.Blue_Btn = new System.Windows.Forms.ToolStripButton();
            this.PenSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.PenSize_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.Board_PB = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Open});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "File";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(224, 26);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(224, 26);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Black_Btn,
            this.Red_Btn,
            this.Yellow_Btn,
            this.Blue_Btn,
            this.PenSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Black_Btn
            // 
            this.Black_Btn.AutoSize = false;
            this.Black_Btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Black_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Black_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Black_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black_Btn.Name = "Black_Btn";
            this.Black_Btn.Size = new System.Drawing.Size(50, 28);
            this.Black_Btn.Text = "Black";
            this.Black_Btn.Click += new System.EventHandler(this.Black_Btn_Click);
            // 
            // Red_Btn
            // 
            this.Red_Btn.AutoSize = false;
            this.Red_Btn.BackColor = System.Drawing.Color.Red;
            this.Red_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Red_Btn.ForeColor = System.Drawing.Color.White;
            this.Red_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red_Btn.Name = "Red_Btn";
            this.Red_Btn.Size = new System.Drawing.Size(50, 28);
            this.Red_Btn.Text = "Red";
            this.Red_Btn.Click += new System.EventHandler(this.Red_Btn_Click);
            // 
            // Yellow_Btn
            // 
            this.Yellow_Btn.AutoSize = false;
            this.Yellow_Btn.BackColor = System.Drawing.Color.Yellow;
            this.Yellow_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Yellow_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Yellow_Btn.Name = "Yellow_Btn";
            this.Yellow_Btn.Size = new System.Drawing.Size(50, 28);
            this.Yellow_Btn.Text = "Yellow";
            this.Yellow_Btn.Click += new System.EventHandler(this.Yellow_Btn_Click);
            // 
            // Blue_Btn
            // 
            this.Blue_Btn.AutoSize = false;
            this.Blue_Btn.BackColor = System.Drawing.Color.Blue;
            this.Blue_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Blue_Btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Blue_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue_Btn.Name = "Blue_Btn";
            this.Blue_Btn.Size = new System.Drawing.Size(50, 28);
            this.Blue_Btn.Text = "Blue";
            this.Blue_Btn.Click += new System.EventHandler(this.Blue_Btn_Click);
            // 
            // PenSize
            // 
            this.PenSize.AutoSize = false;
            this.PenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenSize_5,
            this.PenSize_10,
            this.PenSize_15});
            this.PenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(90, 28);
            this.PenSize.Text = "PenSize";
            this.PenSize.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // PenSize_5
            // 
            this.PenSize_5.Name = "PenSize_5";
            this.PenSize_5.Size = new System.Drawing.Size(224, 26);
            this.PenSize_5.Text = "5";
            this.PenSize_5.Click += new System.EventHandler(this.PenSize_5_Click);
            // 
            // PenSize_10
            // 
            this.PenSize_10.Name = "PenSize_10";
            this.PenSize_10.Size = new System.Drawing.Size(224, 26);
            this.PenSize_10.Text = "10";
            this.PenSize_10.Click += new System.EventHandler(this.PenSize_10_Click);
            // 
            // PenSize_15
            // 
            this.PenSize_15.Name = "PenSize_15";
            this.PenSize_15.Size = new System.Drawing.Size(224, 26);
            this.PenSize_15.Text = "15";
            this.PenSize_15.Click += new System.EventHandler(this.PenSize_15_Click);
            // 
            // Board_PB
            // 
            this.Board_PB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Board_PB.Location = new System.Drawing.Point(0, 81);
            this.Board_PB.Name = "Board_PB";
            this.Board_PB.Size = new System.Drawing.Size(800, 369);
            this.Board_PB.TabIndex = 3;
            this.Board_PB.TabStop = false;
            this.Board_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseDown);
            this.Board_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseMove);
            this.Board_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseDown);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Board_PB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Black_Btn;
        private System.Windows.Forms.ToolStripButton Red_Btn;
        private System.Windows.Forms.ToolStripButton Yellow_Btn;
        private System.Windows.Forms.ToolStripButton Blue_Btn;
        private System.Windows.Forms.ToolStripDropDownButton PenSize;
        private System.Windows.Forms.ToolStripMenuItem PenSize_5;
        private System.Windows.Forms.ToolStripMenuItem PenSize_10;
        private System.Windows.Forms.ToolStripMenuItem PenSize_15;
        private System.Windows.Forms.PictureBox Board_PB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

