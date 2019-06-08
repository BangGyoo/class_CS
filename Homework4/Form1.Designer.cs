namespace Homework4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Origin = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftShift = new System.Windows.Forms.Button();
            this.rightShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Orig_2 = new System.Windows.Forms.TextBox();
            this.Orig_16 = new System.Windows.Forms.TextBox();
            this.Orig_10 = new System.Windows.Forms.TextBox();
            this.Change_2 = new System.Windows.Forms.TextBox();
            this.Change_16 = new System.Windows.Forms.TextBox();
            this.Change_10 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Origin
            // 
            this.Origin.Location = new System.Drawing.Point(98, 27);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(100, 21);
            this.Origin.TabIndex = 0;
            this.Origin.TextChanged += new System.EventHandler(this.Origin_TextChanged);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(256, 27);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(100, 21);
            this.Change.TabIndex = 1;
            this.Change.TextChanged += new System.EventHandler(this.Change_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Orig_10);
            this.groupBox1.Controls.Add(this.Orig_16);
            this.groupBox1.Controls.Add(this.Orig_2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(98, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "원래 수";
            // 
            // leftShift
            // 
            this.leftShift.Location = new System.Drawing.Point(376, 27);
            this.leftShift.Name = "leftShift";
            this.leftShift.Size = new System.Drawing.Size(75, 23);
            this.leftShift.TabIndex = 3;
            this.leftShift.Text = "<<";
            this.leftShift.UseVisualStyleBackColor = true;
            this.leftShift.Click += new System.EventHandler(this.leftShift_Click);
            // 
            // rightShift
            // 
            this.rightShift.Location = new System.Drawing.Point(376, 57);
            this.rightShift.Name = "rightShift";
            this.rightShift.Size = new System.Drawing.Size(75, 23);
            this.rightShift.TabIndex = 4;
            this.rightShift.Text = ">>";
            this.rightShift.UseVisualStyleBackColor = true;
            this.rightShift.Click += new System.EventHandler(this.rightShift_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "원래수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "몇 비트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "이진수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "16진수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "십진수";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Change_10);
            this.groupBox2.Controls.Add(this.Change_16);
            this.groupBox2.Controls.Add(this.Change_2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(304, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "십진수";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "16진수";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "이진수";
            // 
            // Orig_2
            // 
            this.Orig_2.Location = new System.Drawing.Point(79, 14);
            this.Orig_2.Name = "Orig_2";
            this.Orig_2.Size = new System.Drawing.Size(100, 21);
            this.Orig_2.TabIndex = 7;
            // 
            // Orig_16
            // 
            this.Orig_16.Location = new System.Drawing.Point(79, 45);
            this.Orig_16.Name = "Orig_16";
            this.Orig_16.Size = new System.Drawing.Size(100, 21);
            this.Orig_16.TabIndex = 8;
            // 
            // Orig_10
            // 
            this.Orig_10.Location = new System.Drawing.Point(79, 72);
            this.Orig_10.Name = "Orig_10";
            this.Orig_10.Size = new System.Drawing.Size(100, 21);
            this.Orig_10.TabIndex = 9;
            // 
            // Change_2
            // 
            this.Change_2.Location = new System.Drawing.Point(51, 14);
            this.Change_2.Name = "Change_2";
            this.Change_2.Size = new System.Drawing.Size(100, 21);
            this.Change_2.TabIndex = 10;
            // 
            // Change_16
            // 
            this.Change_16.Location = new System.Drawing.Point(51, 45);
            this.Change_16.Name = "Change_16";
            this.Change_16.Size = new System.Drawing.Size(100, 21);
            this.Change_16.TabIndex = 11;
            // 
            // Change_10
            // 
            this.Change_10.Location = new System.Drawing.Point(51, 71);
            this.Change_10.Name = "Change_10";
            this.Change_10.Size = new System.Drawing.Size(100, 21);
            this.Change_10.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightShift);
            this.Controls.Add(this.leftShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Origin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Origin;
        private System.Windows.Forms.TextBox Change;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button leftShift;
        private System.Windows.Forms.Button rightShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Orig_10;
        private System.Windows.Forms.TextBox Orig_16;
        private System.Windows.Forms.TextBox Orig_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Change_10;
        private System.Windows.Forms.TextBox Change_16;
        private System.Windows.Forms.TextBox Change_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

