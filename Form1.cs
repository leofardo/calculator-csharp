using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public float division1;
        public float division2;
        public float sum1;
        public float sum2;
        public float multiplication1;
        public float multiplication2;
        public float subtraction1;
        public float subtraction2;
        public float answer;
        public double squareRoot;
        public float percentageResponse;
        public bool bugZeroMultiplication=false;
        public bool bugZeroDivision=false;
        public bool bugZeroSubtraction=false;
        public bool bugZeroSum=false;
        public string limit;


        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(0);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(0);
                }
            }
            else
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(1);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(1);
                }
            }
            else
            {
                return;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(2);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(2);
                }
            }
            else
            {
                return;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(3);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(3);
                }
            }
            else
            {
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(4);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(4);
                }
            }
            else
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(5);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(5);
                }
            }
            else
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(6);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(6);
                }
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(7);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(7);
                }
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(8);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(8);
                }
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength < 7 || bugZeroMultiplication == true || bugZeroDivision == true || bugZeroSum == true || bugZeroSubtraction == true)
            {
                if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
                {
                    answer = 0;
                    textBox1.Text = Convert.ToString(9);
                    bugZeroMultiplication = false;
                    bugZeroSum = false;
                    bugZeroSubtraction = false;
                    bugZeroDivision = false;
                }
                else
                {
                    textBox1.Text += Convert.ToString(9);
                }
            }
            else
            {
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == Convert.ToString(0) || textBox1.Text == division1.ToString() || textBox1.Text == subtraction1.ToString() || textBox1.Text == multiplication1.ToString() || textBox1.Text == sum1.ToString() || textBox1.Text == answer.ToString() || textBox1.Text == squareRoot.ToString() || textBox1.Text == percentageResponse.ToString())
            {
                answer = 0;
                textBox1.Text = Convert.ToString("0,");
            }
            else if (textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text += Convert.ToString(",");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, 30);
            textBox1.Text = Convert.ToString(0);
            division1=0;
            division2=0;
            sum1=0;
            sum2=0;
            multiplication1=0;
            multiplication2=0;
            subtraction1=0;
            subtraction2=0;
            answer=0;
            squareRoot=0;
            percentageResponse=0;
    }

        private void button12_Click(object sender, EventArgs e)
        {
            bugZeroDivision = true;
            division1 = float.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(division1);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            bugZeroMultiplication = true;
            if (float.Parse(textBox1.Text) != 0)
            {
                multiplication1 = float.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(multiplication1);
            }
            else
            {
                multiplication1 = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bugZeroSum = true;
            if (float.Parse(textBox1.Text) != 0)
            {
                sum1 = float.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(sum1);
            }
            else
            {
                sum1 = 0;
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            bugZeroSubtraction = true;
            subtraction1 = float.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(subtraction1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (division1 != 0)
            {
                division2 = float.Parse(textBox1.Text);

                answer = division1 / division2;

                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }

                sum1 = 0;
                sum2 = 0;
                division1 = 0;
                division2 = 0;
                multiplication1 = 0;
                multiplication2 = 0;
                subtraction1 = 0;
                subtraction2 = 0;

            }
            else if (sum1 != 0)
            {

                sum2 = float.Parse(textBox1.Text);

                answer = sum1 + sum2;

                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }

                sum1 = 0;
                sum2 = 0;
                division1 = 0;
                division2 = 0;
                multiplication1 = 0;
                multiplication2 = 0;
                subtraction1 = 0;
                subtraction2 = 0;

            }
            else if (multiplication1 != 0)
            {
                multiplication2 = float.Parse(textBox1.Text);

                answer = multiplication1 * multiplication2;

                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }

                sum1 = 0;
                sum2 = 0;
                division1 = 0;
                division2 = 0;
                multiplication1 = 0;
                multiplication2 = 0;
                subtraction1 = 0;
                subtraction2 = 0;

            }

            else if (subtraction1 != 0)
            {
                subtraction2 = float.Parse(textBox1.Text);

                answer = subtraction1 - subtraction2;

                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }

                sum1 = 0;
                sum2 = 0;
                division1 = 0;
                division2 = 0;
                multiplication1 = 0;
                multiplication2 = 0;
                subtraction1 = 0;
                subtraction2 = 0;

            }
            //calculations with 0
            else if(bugZeroMultiplication == true)
            {
                answer = 0;
                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }
                bugZeroMultiplication = false;
            }
            else if (bugZeroDivision == true)
            {
                answer = 0;
                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }
                bugZeroDivision = false;
            }
            else if (bugZeroSubtraction == true)
            {
                answer = float.Parse(textBox1.Text) * (-1);
                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }
                bugZeroSubtraction = false;
            }
            else if (bugZeroSum == true)
            {
                answer = float.Parse(textBox1.Text);
                if (answer >= 10000000)
                {
                    limit = "Above the limit";
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    textBox1.Text = limit;
                }
                else if (Convert.ToString(answer).Contains('-'))
                {
                    if (answer <= -10000000)
                    {
                        limit = "Below the limit";
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                        textBox1.Text = limit;
                    }
                    else
                    {
                        textBox1.Text = answer.ToString();
                    }
                }
                else
                {
                    textBox1.Text = answer.ToString();
                }
                bugZeroSum = false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            squareRoot = Math.Sqrt(double.Parse(textBox1.Text));

            if (Convert.ToString(squareRoot).Length > 8)
            {
                limit = "Limit reached";
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                textBox1.Text = limit;
            }
            else
            {
                textBox1.Text = squareRoot.ToString();
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            percentageResponse = multiplication1 * float.Parse(textBox1.Text) / 100;
            textBox1.Text = percentageResponse.ToString();

            sum1 = 0;
            sum2 = 0;
            division1 = 0;
            division2 = 0;
            multiplication1 = 0;
            multiplication2 = 0;
            subtraction1 = 0;
            subtraction2 = 0;
            squareRoot = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(float.Parse(textBox1.Text) * (-1));
        }

        private void button21_Click(object sender, EventArgs e)
        {


            answer = 0;

            if (limit == "Above the limit")
            {
                textBox1.Text = textBox1.Text;
            }
            else if (limit == "Below the limit" || limit == "Limit reached")
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                if (textBox1.Text.Length > 1)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
                else if (textBox1.Text.Length == 1)
                {
                    textBox1.Text = 0.ToString();
                }

                //-----------------------------

                if (textBox1.Text.Length == 1)
                {
                    if (textBox1.Text == "-")
                    {
                        textBox1.Text = 0.ToString();

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
