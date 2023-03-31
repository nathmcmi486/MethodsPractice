using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            /// TODO - Place method calls here

            PrintSignature();
            RectangleArea();
            GetInputSum();
            GetCircleArea();
            CheckLargestValue();
        }

        /// 1. Print a signature to the screen

        public void PrintSignature()
        {
            q1Output.Text = "Your's truly, \n\nGrace Hopper.";
        }

        /// 2. Create a method to calculate the area of a rectangle with
        /// dimensions 5x7, and then use the variables to display:
        /// 
        /// The area of a 5 x 7 rectangle is 35 units squared

        public void RectangleArea()
        {
            q2Output.Text = $"The area of 5x7 rectangle is {5 * 7} units squared";
        }

        /// 3. Create a method to get numbers from q3Num1Input and q3Num2Input,
        /// add them together, and then display output as follows:
        /// 
        /// 5 + 4 = 9 
        public void GetInputSum()
        {
            int sum = Convert.ToInt32(this.q3Num1Input.Text) + Convert.ToInt32(this.q3Num2Input.Text);
            this.q3Output.Text = $"{q3Num1Input.Text} + {q3Num2Input.Text} = {sum}";
        }

        
        /// 4. Create a method to calculate the area of a circle based on  
        /// the radius entered in radiusInput, then display output as follows:
        /// 
        /// The area of a circle with radius of 4 is 50.24 units squared
        public void GetCircleArea()
        {
            double pi = 3.14159;
            double r = 4.0;

            this.q4Output.Text = $"The area of a circle with a radius of 4 is ~{pi * (r * r)} units squared";
        }



        /// 5. 3U Only - Create a method that will determine and display
        /// the maximum of 3 values entered into q5Num1Input, q5Num2Input,
        /// and q5Num3Input. Sample input and output is shown below:
        /// 
        /// Inputs: 5, 7, 2
        /// he largest value is 7
        public void CheckLargestValue()
        {
            int num1 = Convert.ToInt32(this.q5Num1Input.Text);
            int num2 = Convert.ToInt32(this.q5Num2Input.Text);
            int num3 = Convert.ToInt32(this.q5Num3Input.Text);
            int largest_value = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                largest_value = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                largest_value = num2;
            } else { largest_value = num3; }

            this.q5Output.Text = $"The largest value is {largest_value}";
        }


    }
}
