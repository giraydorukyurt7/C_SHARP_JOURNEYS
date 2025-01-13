namespace _006_Application_Plane_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route: " + comboBox1.Text + "-" + comboBox2.Text);
            listBox1.Items.Add("Date/Time: " + maskedTextBox1.Text + "-" + maskedTextBox2);
            listBox1.Items.Add("Passenger info: " + textBox5.Text + "-" + maskedTextBox3.Text + "-" + maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = x;
        }
    }
}
