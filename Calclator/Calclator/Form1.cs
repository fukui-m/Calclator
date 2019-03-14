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

        string inputNumber = "";
        string inputOperator = "";     
       
               
        private void ButtonEqual_Click(object sender, EventArgs e)
        {

        }               

        
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            calcWindow.Text = "";
            inputNumber = calcWindow.Text;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string s1 = inputNumber.Remove(1);
            calcWindow.Text= inputNumber;
           
        }

        private void ButtonNumber_Click_1(object sender, EventArgs e)
        {
            Button ButtonNumber = (Button)sender;
            string text = ButtonNumber.Text;
            inputNumber += text;
            calcWindow.Text = inputNumber;
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
