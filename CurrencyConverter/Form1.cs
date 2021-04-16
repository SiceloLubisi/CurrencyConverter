using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Convert from South African rands to United States dollars
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                txtAmount.Focus();
                errorProvider1.SetError(txtAmount, "Please enter a valid amount!");
            }

            else
            {
                double i = double.Parse(txtAmount.Text);

                if (cmbFrom.SelectedItem == "South African Rand" && cmbTo.SelectedItem == "United States Dollar") //Rand - Dollar
                {
                    //int i = int.Parse(txtAmount.Text);
                    double con = (double)(i * 0.069);
                    lblConvertedAmount.Text = "Converted Sicelo : " + con + "\t $";
                    MessageBox.Show("Converted Amount: " + con + "$");
                }
                else if (cmbFrom.SelectedItem == "United States Dollar" && cmbTo.SelectedItem == "South African Rand") //Dollar - Rand
                {
                    double con = (double)(i / 0.0692);
                    double dcon = Math.Round(con, 2); // Convert answer to 2 decimal places 
                    lblConvertedAmount.Text = "Converted Amount : R" + dcon;
                    MessageBox.Show("Converted Amount: R" + dcon);
                }
                else if (cmbFrom.SelectedItem == "Euro" && cmbTo.SelectedItem == "South African Rand") // Euro - Rand
                {
                    double con = (double)(i / 0.058);
                    double dcon = Math.Round(con, 2);
                    lblConvertedAmount.Text = "Convertet Amount: R" + dcon;
                    MessageBox.Show("Converted Amount: R" + dcon);

                }
                else if (cmbFrom.SelectedItem == "South African Rand" && cmbTo.SelectedItem == "Euro") // Rand - Euro
                {
                    double con = (double)(i * 0.058);
                    double dcon = Math.Round(con, 2);
                    lblConvertedAmount.Text = "Convertet Amount: R" + dcon;
                    MessageBox.Show("Converted Amount: E" + dcon);
                }

                else if ((cmbFrom.SelectedItem == "United States Dollar" && cmbTo.SelectedItem == "United States Dollar") || (cmbFrom.SelectedItem == "South African Rand" && cmbTo.SelectedItem == "South African Rand"))
                {
                    MessageBox.Show("Please choose different currencies to convert!");
                }
            }
        }
    }
}
