
namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double first, second, cle;

        string operation;

        public Form1()
        {
            InitializeComponent();

        }

        private void Entervalue(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = "";
            {
                if (button.Text == ",")
                {
                    if (!textBox1.Text.Contains(","))
                    {
                        textBox1.Text = textBox1.Text + button.Text;
                    }
                }
                else if (button.Text == "%")
                {
                    textBox1.Text = (Convert.ToDouble(textBox1.Text) / 100).ToString();
                }
                else if (button.Text == "e")
                {
                    textBox1.Text = Math.E.ToString();
                }
                else if (button.Text == "π")
                {
                    textBox1.Text = Math.PI.ToString();
                }
                else
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }

            }
        }

        private void Simple_operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (cle == 0)
            {
                first = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                first = cle;
            }

            operation = button.Text;

            textBox1.Text = "";
        }

        private void Equal(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                second = Convert.ToDouble(textBox1.Text);

                switch (operation)
                {

                    case "xʸ":
                        textBox1.Text = (Math.Pow(first, second)).ToString();
                        listView1.Items.Add(first.ToString() + "^" + second.ToString() + "=" + textBox1.Text);
                        break;
                    case "+":
                        textBox1.Text = (first + second).ToString();
                        listView1.Items.Add(first.ToString() + "+" + second.ToString() + "=" + textBox1.Text);
                        break;
                    case "-":
                        textBox1.Text = (first - second).ToString();
                        listView1.Items.Add(first.ToString() + "-" + second.ToString() + "=" + textBox1.Text);
                        break;
                    case "×":
                        textBox1.Text = (first * second).ToString();
                        listView1.Items.Add(first.ToString() + "*" + second.ToString() + "=" + textBox1.Text);
                        break;
                    case "÷":
                        textBox1.Text = (first / second).ToString();
                        listView1.Items.Add(first.ToString() + "/" + second.ToString() + "=" + textBox1.Text);
                        break;
                    case "log":
                        textBox1.Text = (Math.Log(first, second)).ToString();
                        listView1.Items.Add("Log(" + first.ToString() + "," + second.ToString() + ") = " + textBox1.Text);
                        break;
                    case "ʸ√x":
                        textBox1.Text = (Math.Round(Math.Pow(first, 1 / second), 5)).ToString();
                        listView1.Items.Add(first.ToString() + "^1/" + second.ToString() + " = " + textBox1.Text);
                        break;
                    case "mod":
                        textBox1.Text = (first % second).ToString();
                        listView1.Items.Add(first.ToString() + " mod " + second.ToString() + " = " + textBox1.Text);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            cle = first;
        }

        private void negative_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textBox1.Text);
            if (q == 0)
            {

            }
            else
            {
                textBox1.Text = Convert.ToString(-q);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void fraction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (1 / x).ToString();
                listView1.Items.Add("1/" + x + " = " + textBox1.Text);
            }
        }

        private void squared_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (x * x).ToString();
                listView1.Items.Add(x + "^2 = " + textBox1.Text);
            }
        }

        private void square_root_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Sqrt(x)).ToString();
                listView1.Items.Add("Sqrt(" + x + ")" + " = " + textBox1.Text);
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 340;
            this.textBox1.Width = 318;
            this.listView1.Width = 318;
            listView1.Columns[0].Width = listView1.Width -4;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 583;
            this.textBox1.Width = 561;
            this.listView1.Width = 561;
            listView1.Columns[0].Width = listView1.Width -4;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Abs(x)).ToString();
                listView1.Items.Add("|" + x + "|" + " = " + textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (1 / Math.Cos(x)).ToString();
                listView1.Items.Add("sec(" + x + ") = " + textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (1 / Math.Sin(x)).ToString();
                listView1.Items.Add("csc(" + x + ") = " + textBox1.Text);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Exp(x)).ToString();
                listView1.Items.Add("e^" + x + "=" + textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double y = 1;
                double x = Math.Round(Convert.ToDouble(textBox1.Text));
                while (x != 1)
                {
                    y = y * x;
                    x = x - 1;
                }
                textBox1.Text = y.ToString();
                listView1.Items.Add(x + "! = " + textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Log(x, 2.7182818284)).ToString();
                listView1.Items.Add("Log(" + x + ",e" + ") = " + textBox1.Text);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Sin(x)).ToString();
                listView1.Items.Add("sin(" + x + ") = " + textBox1.Text);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Cos(x)).ToString();
                listView1.Items.Add("cos(" + x + ") = " + textBox1.Text);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (Math.Tan(x)).ToString();
                listView1.Items.Add("tg(" + x + ") = " + textBox1.Text);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (1 / Math.Tan(x)).ToString();
                listView1.Items.Add("ctg(" + x + ") = " + textBox1.Text);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = (Math.PI / 180) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = x.ToString();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                double x = (180 / Math.PI) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = x.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            listView1.Clear();

            first = 0;
            second = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 340;
            this.textBox1.Width = 318;
            this.listView1.Width = 318;
            listView1.View = View.Details;
            listView1.Columns[0].Width = listView1.Width - 4;
        }


    }
}