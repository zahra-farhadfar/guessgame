using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form2 : Form
    {
        int guessedNumber = 0;
        static int computernumber = 0;
        static string msg;
        static int difference = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guessedNumber = Convert.ToInt32(txtUserNumber.Text);
            if (Math.Abs(computernumber - guessedNumber) < difference)
                txtUserNumber.BackColor = Color.Blue;
            else
                txtUserNumber.BackColor = Color.Red;
            difference = computernumber - guessedNumber;

            if (guessedNumber > computernumber)
            {
                msg = "too High";
                txtUserNumber.Focus();
            }

            else if (guessedNumber < computernumber)
            {
                msg = "too Low";
                txtUserNumber.Focus();
            }
            else
            {
                msg = "correct!";
                txtUserNumber.BackColor = Color.Green;
                btnGuess.Enabled = false;
            }
            lblHighLow.Text = msg;
            difference = Math.Abs(computernumber - guessedNumber);

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            var rand = new Random();
            computernumber = rand.Next(1, 1001);
            btnGuess.Enabled = true;
            txtUserNumber.Clear();
            txtUserNumber.BackColor = Color.White;
            lblHighLow.Text = "";
            txtUserNumber.Focus();
        }
    }
}
