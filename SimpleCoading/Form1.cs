using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCoading
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string n1;
            
                if (txtWords.Text == "")
                {

                    MessageBox.Show("Please Provide a Value");
                }
                else
                {
                    n1 = Convert.ToString(txtWords.Text);

                    lblText.Text = n1;
                    lblText.Font = new Font("Times New Roman", 20);
                }
            

         }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string n2;
            n2 = cmbColores.Text;

            if (cmbColores.Text == "")
            {
                MessageBox.Show("Please Select color");

            }
            else
            {
                switch (n2)
                { 
                    case "Red" :
                        lblText.BackColor = Color.Red;
                        break;
                    case "Blue":
                        lblText.BackColor = Color.Blue;
                        break;

                    case "Black":
                        lblText.BackColor = Color.Black;
                        break;
                    default:
                        break; 
                                                                
                }
            
            
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int h;
            try
            {
                a = Convert.ToInt32(txtN1.Text);
                b = Convert.ToInt32(txtN2.Text);
                h = a * b;
                lblAns.Text = a + " X " + b + " = " + h ;
            }
            catch
            {
                MessageBox.Show("Please Enter a Number");
            
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlColore.Visible = false;
            plnMulitipy.Visible = false;

        }

        private void letsChangeColorsInTheBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlColore.Visible = true;
            label1.Visible = false;
        }

        private void letsMultiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plnMulitipy.Visible = true;
            label1.Visible = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
