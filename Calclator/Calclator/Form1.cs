using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calclator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string firstInputNumber = "";
        static string secondInputNumber = "";
        static string inputOperator = "";
        static double calcResult = 0;
        

        delegate void DelegateProcessing();

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (secondInputNumber != "")
            {
                DP();

                calcWindow.Text = calcResult.ToString();
                firstInputNumber = calcResult.ToString();
                secondInputNumber = "";
            }
        }


        private void ButtonCE_Click(object sender, EventArgs e)
        {
            calcWindow.Text = "";
            firstInputNumber = "";
            secondInputNumber = "";
            inputOperator = "";
            calcResult = 0;
            
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (inputOperator == "" && firstInputNumber != "")
            {
                firstInputNumber = firstInputNumber.Remove(firstInputNumber.Length - 1, 1);
                calcWindow.Text = firstInputNumber;
            }
            else if (inputOperator != "" && secondInputNumber != "")
            {
                secondInputNumber = secondInputNumber.Remove(secondInputNumber.Length - 1, 1);
                calcWindow.Text = secondInputNumber;
            }
        }


        private void ButtonNumber_Click_1(object sender, EventArgs e)
        {
            if (calcWindow.Text == "0")
            {
                calcWindow.Text= "";
                firstInputNumber ="";
            }
                Button ButtonNumber = (Button)sender;
                string text = ButtonNumber.Text;
            if (inputOperator == "")
            {
                firstInputNumber += text;
                calcWindow.Text = firstInputNumber;
            }
            else if (inputOperator != "")
            {
                secondInputNumber += text;
                calcWindow.Text = secondInputNumber;
            }                     
        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {

            if (secondInputNumber != "")
            {
                DP();
                calcWindow.Text = calcResult.ToString();
                firstInputNumber = calcResult.ToString();
            }
            if (firstInputNumber != "")
            {
                Button ButtonOperator = (Button)sender;
                string text = ButtonOperator.Text;
                inputOperator = text;
                secondInputNumber = "";
            }
        }

        private void ButtonZeroth_Click_1(object sender, EventArgs e)
        {
            if (calcWindow.Text != "0")
            {
                string text = "0";
                if (inputOperator == "")
                {
                    firstInputNumber += text;
                    calcWindow.Text = firstInputNumber;
                }
                else if (inputOperator != "")
                {
                    secondInputNumber += text;
                    calcWindow.Text = secondInputNumber;
                }
            }
        }
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (calcWindow.Text != ""&&!calcWindow.Text.Any(a=>a.ToString()==".")) 
            {
                string text = ".";
                if (inputOperator == "")
                {
                    firstInputNumber += text;
                    calcWindow.Text = firstInputNumber;
                }
                else if (inputOperator != "")
                {
                    secondInputNumber += text;
                    calcWindow.Text = secondInputNumber;
                }
            }
        }

        static void Processing()
        {
            
            if (inputOperator == "+")
            {
                calcResult = double.Parse(firstInputNumber) + double.Parse(secondInputNumber);
            }
            else if (inputOperator == "-")
            {
                calcResult = double.Parse(firstInputNumber) - double.Parse(secondInputNumber);
            }
            else if (inputOperator == "*")
            {
                calcResult = double.Parse(firstInputNumber) * double.Parse(secondInputNumber);
            }
            else if (inputOperator == "/")
            {
                calcResult = double.Parse(firstInputNumber) / double.Parse(secondInputNumber);
            }
        }
        DelegateProcessing DP = new DelegateProcessing(Processing);
        
 
    }   
}
