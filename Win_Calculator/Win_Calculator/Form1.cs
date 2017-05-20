using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calculator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        //Button click function
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }
        //Clear result funtion
        private void clearEverything(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
        }

        private void equal_Click (object sender, EventArgs e)
        {
            switch (operation)
            {
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
              
            }//end of switch
            operation_pressed = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            
        }

        
    }
}
     
        
    

