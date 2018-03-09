using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class Form1 : Form
    {
        Controller controller;

        public Form1()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controller.setSideA(textHandler(label5, textBox1.Text));
            label4.Text = controller.getDescription();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            controller.setSideB(textHandler(label6, textBox2.Text));
            label4.Text = controller.getDescription();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            controller.setSideC(textHandler(label7, textBox3.Text));
            label4.Text = controller.getDescription();
        }

        // Takes a string and a warning label. Sets warning label if text is non-numeric.
        // Returns 0 if string is empty or non-numeric. Otherwise, returns numeric value of string.
        private double textHandler(Label warning, string text)
        {
            double result = 0;
            if(text == "")
            {
                warning.Text = "";
            }
            else
            {
                try
                {
                    result = Convert.ToDouble(text);
                    warning.Text = "";
                }
                catch
                {
                    warning.Text = "Invalid Input";
                }
            }

            return result;
        }
    }
}
