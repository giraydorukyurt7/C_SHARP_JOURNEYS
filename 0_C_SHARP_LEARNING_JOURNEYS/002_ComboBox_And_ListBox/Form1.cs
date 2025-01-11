namespace _002_ComboBox_And_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Businees");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                label3.Text = listBox1.SelectedItem.ToString();
            else
                MessageBox.Show("Please select before pressing the button!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((comboBox2.SelectedItem != null) && (comboBox1.SelectedItem != null) && (textBox2.Text != null) && (textBox3.Text != null))
                listBox2.Items.Add(textBox2.Text + "|" +
                               textBox3.Text + "|" +
                               comboBox2.SelectedItem.ToString() + "|" +
                               comboBox1.SelectedItem.ToString());
            else
                MessageBox.Show("Please completely fill the form!");
        }
    }
}
