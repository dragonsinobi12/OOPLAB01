using System.Xml.Linq;

namespace LAB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + " KKU";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCLear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "9";
        }
        string number1 = string.Empty;
        string output = string.Empty;
        private void button1_Click_3(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "+";
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "-";
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "*";
        }

        private void answerBottom_Click(object sender, EventArgs e)
        {
            string number2 = textBoxInput.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            int output = 0;
            if (operation == "+")
            {
               output = num1 + num2;
            }
            if (operation == "-")
            {
                output = num1 - num2;
            }
            if (operation == "*")
            {
                output = num1 * num2;
            }
            if (operation == "/")
            {
                output = num1 / num2;
            }
            textBoxInput.Text = output.ToString();
        }

        private void divisionBottom_Click(object sender, EventArgs e)
        {
            number1 = textBoxInput.Text;
            textBoxInput.Text = string.Empty;
            operation = "/";
        }
    }
}
