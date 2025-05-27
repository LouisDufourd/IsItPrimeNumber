using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IsItPrimeNumberWindowsForm
{
    public partial class Form1: Form
    {
        const String NUMBER_REGEX = "[0-9]*";
        String PreviousText;
        public Form1()
        {
            InitializeComponent();
        }

        public static bool isPrimeNumber(long number, out int divisable)
        {
            divisable = -1;

            int sqrt = (int)Math.Round(Math.Sqrt(number));

            for (int i = 2; i <= sqrt; i++)
            {
                long reste = number % i;
                if (reste == 0)
                {
                    divisable = i;
                    break;
                }
            }

            return divisable == -1;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            inputTextBox.Text = Regex.Match(inputTextBox.Text, NUMBER_REGEX).Value;

            Console.WriteLine(!Regex.Match(inputTextBox.Text, NUMBER_REGEX).Success);

            if (inputTextBox.Text == "")
            {
                PreviousText = inputTextBox.Text;
                resultLabel.Text = "";
                return;
            }

            long number = long.Parse(inputTextBox.Text);
            bool success = isPrimeNumber(number, out int divisable);
            if (success)
            {
                resultLabel.Text = $"{number} est un nombre premier.";
                resultLabel.ForeColor = Color.Green;
            } else
            {
                resultLabel.Text = $"{number} n'est pas un nombre premier et est divisible par {divisable}.";
                resultLabel.ForeColor = Color.Red;
            }

            PreviousText = inputTextBox.Text;
        }
    }
}
