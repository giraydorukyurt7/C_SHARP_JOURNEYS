namespace _001_Label_And_TextBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Your Name:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("WarHeliosCondCBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 62);
            button1.Name = "button1";
            button1.Size = new Size(136, 55);
            button1.TabIndex = 1;
            button1.Text = "PRINT!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 13);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Location = new Point(401, 182);
            button2.Name = "button2";
            button2.Size = new Size(154, 29);
            button2.TabIndex = 3;
            button2.Text = "GET INFO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Univers Condensed", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(433, 13);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 4;
            label3.Text = "NAME:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Univers Condensed", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(401, 59);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 5;
            label4.Text = "SURNAME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Univers Condensed", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(447, 117);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 6;
            label5.Text = "JOB:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Univers Condensed", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(499, 13);
            label6.Name = "label6";
            label6.Size = new Size(56, 24);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Univers Condensed", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(499, 59);
            label7.Name = "label7";
            label7.Size = new Size(56, 24);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Univers Condensed", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(499, 117);
            label8.Name = "label8";
            label8.Size = new Size(56, 24);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 39);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(12, 236);
            button3.Name = "button3";
            button3.Size = new Size(290, 29);
            button3.TabIndex = 11;
            button3.Text = "SEND!";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 303);
            label9.Name = "label9";
            label9.Size = new Size(127, 37);
            label9.TabIndex = 12;
            label9.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(712, 448);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Label And TextBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Button button3;
        private Label label9;
    }
}
