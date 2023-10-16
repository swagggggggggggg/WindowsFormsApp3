using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float weight = Convert.ToInt16(textBox1.Text);
                float height = Convert.ToInt16(textBox2.Text);

                float bmi =  703 * weight / (height * height);

                if (Math.Round(bmi, 2) < 18.5)
                {
                    textBox3.Text = "BMI: " + Convert.ToString(Math.Round(bmi, 2)) + Environment.NewLine + "Status: underweight";
                }else if((Math.Round(bmi, 2) > 25))
                {
                    textBox3.Text = "BMI: " + Convert.ToString(Math.Round(bmi, 2)) + Environment.NewLine + "Status: overweight";
                }
                else
                {
                    textBox3.Text = "BMI: " + Convert.ToString(Math.Round(bmi, 2)) + Environment.NewLine + "Status: normal weight";
                }

            }
            catch
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;

                MessageBox.Show("Invalid value");
            }
            
        }
    }
}
