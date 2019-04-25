namespace Homework2_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.폼생성ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.두번째폼열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼생성ToolStripMenuItem,
            this.폼제거ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 폼생성ToolStripMenuItem
            // 
            this.폼생성ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.두번째폼열기ToolStripMenuItem});
            this.폼생성ToolStripMenuItem.Name = "폼생성ToolStripMenuItem";
            this.폼생성ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.폼생성ToolStripMenuItem.Text = "폼 생성";
            // 
            // 폼제거ToolStripMenuItem
            // 
            this.폼제거ToolStripMenuItem.Name = "폼제거ToolStripMenuItem";
            this.폼제거ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.폼제거ToolStripMenuItem.Text = "폼 제거";
            this.폼제거ToolStripMenuItem.Click += new System.EventHandler(this.폼제거ToolStripMenuItem_Click);
            // 
            // 두번째폼열기ToolStripMenuItem
            // 
            this.두번째폼열기ToolStripMenuItem.Name = "두번째폼열기ToolStripMenuItem";
            this.두번째폼열기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.두번째폼열기ToolStripMenuItem.Text = "두번째 폼 열기";
            this.두번째폼열기ToolStripMenuItem.Click += new System.EventHandler(this.두번째폼열기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 폼생성ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 두번째폼열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼제거ToolStripMenuItem;
    }
}

