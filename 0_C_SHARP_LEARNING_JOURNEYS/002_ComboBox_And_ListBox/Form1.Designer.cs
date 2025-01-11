namespace _002_ComboBox_And_ListBox
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            listBox2 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "adana", "adiyaman", "afyonkarahisar", "agri", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin", "aydin", "balikesir", "bartin", "batman", "bayburt", "bilecik", "bingol", "bitlis", "bolu", "burdur", "bursa", "canakkale", "cankiri", "corum", "denizli", "diyarbakir", "duzce", "edirne", "elazig", "erzincan", "erzurum", "eskisehir", "gaziantep", "giresun", "gumushane", "hakkâri", "hatay", "igdir", "isparta", "istanbul", "izmir", "kahramanmaras", "karabuk", "karaman", "kars", "kastamonu", "kayseri", "kilis", "kirikkale", "kirklareli", "kirsehir", "kocaeli", "konya", "kutahya", "malatya", "manisa", "mardin", "mersin", "mugla", "mus", "nevsehir", "nigde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "sanliurfa", "siirt", "sinop", "sivas", "sirnak", "tekirdag", "tokat", "trabzon", "tunceli", "usak", "van", "yalova", "yozgat", "zonguldak" });
            comboBox1.Location = new Point(745, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 42);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(357, 46);
            button1.TabIndex = 1;
            button1.Text = "ADD BUSINESS MAJOR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Software Engineer", "Data Scientist", "Backend Developer", "Frontend Developer", "Fullstack Developer" });
            comboBox2.Location = new Point(745, 217);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 42);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(475, 74);
            button2.Name = "button2";
            button2.Size = new Size(183, 42);
            button2.TabIndex = 3;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(188, 34);
            label1.TabIndex = 4;
            label1.Text = "Add New Job:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 42);
            textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Bob", "George", "Isaac", "Zed" });
            listBox1.Location = new Point(12, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(152, 140);
            listBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 458);
            label2.Name = "label2";
            label2.Size = new Size(247, 34);
            label2.TabIndex = 7;
            label2.Text = "Selected Student is:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 458);
            label3.Name = "label3";
            label3.Size = new Size(180, 34);
            label3.TabIndex = 8;
            label3.Text = "Student-name";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 283);
            button3.Name = "button3";
            button3.Size = new Size(152, 44);
            button3.TabIndex = 9;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(475, 442);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(756, 140);
            listBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(692, 368);
            label4.Name = "label4";
            label4.Size = new Size(207, 34);
            label4.TabIndex = 11;
            label4.Text = "---People List---";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(652, 402);
            label5.Name = "label5";
            label5.Size = new Size(298, 34);
            label5.TabIndex = 12;
            label5.Text = "Name|Surname|Job|City";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(745, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 42);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(745, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 42);
            textBox3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(630, 124);
            label6.Name = "label6";
            label6.Size = new Size(94, 34);
            label6.TabIndex = 17;
            label6.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(595, 172);
            label7.Name = "label7";
            label7.Size = new Size(129, 34);
            label7.TabIndex = 18;
            label7.Text = "Surname:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 225);
            label8.Name = "label8";
            label8.Size = new Size(65, 34);
            label8.TabIndex = 19;
            label8.Text = "Job:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(652, 273);
            label9.Name = "label9";
            label9.Size = new Size(72, 34);
            label9.TabIndex = 20;
            label9.Text = "City:";
            // 
            // button4
            // 
            button4.Location = new Point(595, 323);
            button4.Name = "button4";
            button4.Size = new Size(418, 42);
            button4.TabIndex = 21;
            button4.Text = "ADD NEW PERSONEL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1483, 669);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "More ToolBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Button button3;
        private ListBox listBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button4;
    }
}
