using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kalkulator
{
    public partial class Form1 : Form
    {

        double angka1, angka2, hasil;
        string operasi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input tidak boleh kosong!");
                return;
            }
            operasi = "+";
            angka1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input tidak boleh kosong!");
                return;
            }
            operasi = "-";
            angka1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input tidak boleh kosong!");
                return;
            }
            operasi = "/";
            angka1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input tidak boleh kosong!");
                return;
            }
            operasi = "*";
            angka1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input tidak boleh kosong!");
                return;
            }
            angka2 = double.Parse(textBox1.Text);
            switch (operasi)
            {
                case "+":
                    hasil = angka1 + angka2;
                    textBox1.Text = hasil.ToString();
                    break;

                case "-":
                    hasil = angka1 - angka2;
                    textBox1.Text = hasil.ToString();
                    break;

                case "/":
                    hasil = angka1 / angka2;
                    textBox1.Text = hasil.ToString();
                    break;

                case "*":
                    hasil = angka1 * angka2;
                    textBox1.Text = hasil.ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        //artha_walnut

    }
}
