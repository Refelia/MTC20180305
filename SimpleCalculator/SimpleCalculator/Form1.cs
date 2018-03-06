using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstvalue = 0;
            double secondvalue = 0;
            bool numeric = true;

            numeric = (double.TryParse(textBox1.Text, out firstvalue) && double.TryParse(textBox2.Text, out secondvalue));

            if (textBox1.Text != null && textBox2 != null && numeric)
            {
                if (radioButton1.Checked)

                {
                    textBox3.Text = (firstvalue + secondvalue).ToString();
                }

                if (radioButton2.Checked)
                {
                    textBox3.Text = (firstvalue - secondvalue).ToString();
                }

                if (radioButton3.Checked)
                {
                    textBox3.Text = (firstvalue * secondvalue).ToString();
                }

                if (radioButton4.Checked)
                {
                    textBox3.Text = (firstvalue / secondvalue).ToString();
                }
            }
            else
            {
                MessageBox.Show("Numeric value required");
            }

            }
        }
    }
