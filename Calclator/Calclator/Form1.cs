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
               
        
        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }
               
        private void ButtonEqual_Click(object sender, EventArgs e)
        {

        }               

        private void ButtonDiv_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNumber_Click_1(object sender, EventArgs e)
        {
            Button ButtonNumber = (Button)sender;
            string text = ButtonNumber.Text;
            inputNumber += text;
            calcWindow.Text = inputNumber;
        }
    }
}
