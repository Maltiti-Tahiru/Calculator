///////////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer -- Description
// 2024-01-22   Maltiti      Completed the physical look of all the buttons 
// Also completed the arithmetic buttons +,-.x,/
// 2024-01-24   Maltiti      Completed the rest of the buttons. erase, decimal point
// 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        // storage for the left hand side of a math operation so the calc can
        // complete the operations
        private double leftOperand = 0.0;

        //storage for the selected operator until the right operand is chosen
        private string mathOperation = "0.0";

        // this is a signal that will tell us if the user
        private bool beginMathOp = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void subtraction_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "-";
        }
        private void CE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            //CE is to clean all numbers include memory.
        }

        private void num1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(display.Text.Length > 1)
            {
            display.Text = display.Text.Substring(0, display.Text.Length - 1);

            }
            else
            {
                // otherwise set it back to 0
                display.Text = "0";
            }
            // nominal cas
        }

        private void num00_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "00";
        }

        private void num_Click(object sender, EventArgs e)
        {
            if(display.Text == "0" || beginMathOp && display.Text != ".")
            {
            // clear the display if
            // 1) there is a leading zero and its the ONLY thing in the display OR
            // 2) the user has indicated the beginning of a  math op (flag is true) AND NOT 
            // 3) the text in display is not a single decimal pt "." by itself
                display.Clear();
            }

            //here we are casting the sender parameter in to something
            //of type Button for temp getting the text off of the buttom.
           // Button num = (Button)sender;
            //display.Text = display.Text + num.Text;
            display.Text += ((Button)sender).Text;
        }

        private void mathOpBtn_Click(object sender, EventArgs e)
        {
            // grab left operand and store for later
            leftOperand = double.Parse(display.Text);
            
            // save the actual selected operator
            mathOperation = ((Button)sender).Text;

            // test to make sure this code is executing properly
            display.Clear();

        }

        private void equal_Click(object sender, EventArgs e)
        {

            switch (mathOperation) 
            {
                case "+":
                    display.Text = (leftOperand + double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (leftOperand - double.Parse(display.Text)).ToString();
                    break; 
                case "x":
                    display.Text = (leftOperand * double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (leftOperand / double.Parse(display.Text)).ToString();
                    break;
                default:
                    // compiler cant reach this as unreachable code because the case statement
                    // is matcching string literals.
                    MessageBox.Show("ERROR: this code should be unreachable");
                    break;
            }
        }

        private void posNegBtn_Click(object sender, EventArgs e)
        {
            // when an inverse val is desried the val must be entered first
            // then the negative button is applied
            display.Text = (-double.Parse(display.Text)).ToString();
        }

        private void decimalPt_Click1(object sender, EventArgs e)
        {
            // ternarary operator
            // single line if statement
            // abc = (xyz > 5) ? 5 : 50

            // if the display does not contain a decimal pnt add one
            display.Text = display.Text.Contains(".") ? display.Text : display.Text + "."; 
        }

        // lambda expression
        private void decimalPt_Click(object sender, EventArgs e) =>
            display.Text = display.Text.Contains(".") ? display.Text : display.Text + ".";
        
    }
}
