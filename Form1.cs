using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtHouseNumbers4_TextChanged(object sender, EventArgs e)
        {

        }

        static Random _random = new Random();

        private int generateRandomNumber()
        {
            /**
             * Get random system from static new Random.
             */
            return _random.Next(10);
        }

        private string generateRandomNumberAndConvert()
        {
            return this.generateRandomNumber().ToString();
        }

        private void btnGenerateRnadomNumbers_Click(object sender, EventArgs e)
        {
            txtYourNumbers1.Text = this.generateRandomNumberAndConvert();
            txtYourNumbers2.Text = this.generateRandomNumberAndConvert();
            txtYourNumbers3.Text = this.generateRandomNumberAndConvert();
            txtYourNumbers4.Text = this.generateRandomNumberAndConvert();
            txtYourNumbers5.Text = this.generateRandomNumberAndConvert();
            txtYourNumbers6.Text = this.generateRandomNumberAndConvert();
            txtYourNumbers7.Text = this.generateRandomNumberAndConvert();
        }

        private void calculateUserSuccess()
        {
            int GainedMoney = 0;
            var successColor = System.Drawing.Color.Green;
            var errorColor = System.Drawing.Color.Red;

            if (txtYourNumbers1.Text == txtHouseNumbers1.Text)
            {
                GainedMoney += 25;
                txtYourNumbers1.BackColor = successColor;
                txtHouseNumbers1.BackColor = successColor;
            } else
            {
                txtYourNumbers1.BackColor = errorColor;
                txtHouseNumbers1.BackColor = errorColor;
            }
            if (txtYourNumbers2.Text == txtHouseNumbers2.Text)
            {
                GainedMoney += 25;
                txtYourNumbers2.BackColor = successColor;
                txtHouseNumbers2.BackColor = successColor;
            } else
            {
                txtYourNumbers2.BackColor = errorColor;
                txtHouseNumbers2.BackColor = errorColor;
            }

            if (txtYourNumbers3.Text == txtHouseNumbers3.Text)
            {
                GainedMoney += 25;
                txtYourNumbers3.BackColor = successColor;
                txtHouseNumbers3.BackColor = successColor;
            } else
            {
                txtYourNumbers3.BackColor = errorColor;
                txtHouseNumbers3.BackColor = errorColor;
            }
            if (txtYourNumbers4.Text == txtHouseNumbers4.Text)
            {
                GainedMoney += 25;
                txtYourNumbers4.BackColor = successColor;
                txtHouseNumbers4.BackColor = successColor;
            } else
            {
                txtYourNumbers4.BackColor = errorColor;
                txtHouseNumbers4.BackColor = errorColor;
            }
            if (txtYourNumbers5.Text == txtHouseNumbers5.Text)
            {
                GainedMoney += 25;
                txtYourNumbers5.BackColor = successColor;
                txtHouseNumbers5.BackColor = successColor;
            }
            else
            {
                txtYourNumbers5.BackColor = errorColor;
                txtHouseNumbers5.BackColor = errorColor;
            }
            if (txtYourNumbers6.Text == txtHouseNumbers6.Text)
            {
                GainedMoney += 25;
                txtYourNumbers6.BackColor = successColor;
                txtHouseNumbers6.BackColor = successColor;
            }
            else
            {
                txtYourNumbers6.BackColor = errorColor;
                txtHouseNumbers6.BackColor = errorColor;
            }
            if (txtYourNumbers7.Text == txtHouseNumbers7.Text)
            {
                GainedMoney += 25;
                txtYourNumbers7.BackColor = successColor;
                txtHouseNumbers7.BackColor = successColor;
            }
            else
            {
                txtYourNumbers7.BackColor = errorColor;
                txtHouseNumbers7.BackColor = errorColor;
            }

            this.writeFinishMessage(GainedMoney);
        }

        private void writeFinishMessage(int money)
        {
            string text = "";
            if (money == 0)
            {
              text = "You've never made any money";
            } else 
            {
              text = "You won " + money + " million Dollars.";
            }
            lblGainedMessage.Text = text;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            txtHouseNumbers1.Text = this.generateRandomNumberAndConvert();
            txtHouseNumbers2.Text = this.generateRandomNumberAndConvert();
            txtHouseNumbers3.Text = this.generateRandomNumberAndConvert();
            txtHouseNumbers4.Text = this.generateRandomNumberAndConvert();
            txtHouseNumbers5.Text = this.generateRandomNumberAndConvert();
            txtHouseNumbers6.Text = this.generateRandomNumberAndConvert();
            txtHouseNumbers7.Text = this.generateRandomNumberAndConvert();

            this.calculateUserSuccess();
            lblGainedMessage.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var emptyColor = System.Drawing.Color.DarkKhaki;
            lblGainedMessage.Visible = false;
            string zero = 0.ToString();

            txtYourNumbers1.Text = zero;
            txtHouseNumbers1.Text = zero;
            txtYourNumbers1.BackColor = emptyColor;
            txtHouseNumbers1.BackColor = emptyColor;

            txtYourNumbers2.Text = zero;
            txtHouseNumbers2.Text = zero;
            txtYourNumbers2.BackColor = emptyColor;
            txtHouseNumbers2.BackColor = emptyColor;

            txtYourNumbers3.Text = zero;
            txtHouseNumbers3.Text = zero;
            txtYourNumbers3.BackColor = emptyColor;
            txtHouseNumbers3.BackColor = emptyColor;

            txtYourNumbers4.Text = zero;
            txtHouseNumbers4.Text = zero;
            txtYourNumbers4.BackColor = emptyColor;
            txtHouseNumbers4.BackColor = emptyColor;

            txtYourNumbers5.Text = zero;
            txtHouseNumbers5.Text = zero;
            txtYourNumbers5.BackColor = emptyColor;
            txtHouseNumbers5.BackColor = emptyColor;

            txtYourNumbers6.Text = zero;
            txtHouseNumbers6.Text = zero;
            txtYourNumbers6.BackColor = emptyColor;
            txtHouseNumbers6.BackColor = emptyColor;

            txtYourNumbers7.Text = zero;
            txtHouseNumbers7.Text = zero;
            txtYourNumbers7.BackColor = emptyColor;
            txtHouseNumbers7.BackColor = emptyColor;
        }
    }
}
