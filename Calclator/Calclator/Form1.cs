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

        string firstInputNumber = "";
        string secondInputNumber = "";
        string inputOperator = "";     
       
               
        private void ButtonEqual_Click(object sender, EventArgs e)
        {

        }               

        
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            calcWindow.Text = "";
            firstInputNumber = calcWindow.Text;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string s1 = firstInputNumber.Remove(1);
            calcWindow.Text= firstInputNumber;
           
        }

        private void ButtonNumber_Click_1(object sender, EventArgs e)
        {
            Button ButtonNumber = (Button)sender;
            string text = ButtonNumber.Text;
            if (inputOperator == "")
            {
                firstInputNumber += text;
                calcWindow.Text = firstInputNumber;
            }
            else if(inputOperator != "")
            {
                secondInputNumber += text;
                calcWindow.Text = secondInputNumber;
            }
        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            Button ButtonOperator = (Button)sender;
            string text = ButtonOperator.Text;
            inputOperator = text;
            calcWindow.Text = inputOperator;
        }
    }
}
