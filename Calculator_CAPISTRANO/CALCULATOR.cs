using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_CAPISTRANO
{
    public partial class CALCULATOR : Form
    {
        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            TEXTBOX1.AppendText("+");
        }

        private void TWO_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "2";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Clear();
        }

        private void ONE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "1";
        }

        private void THREE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "3";
        }

        private void FOUR_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "4";
        }

        private void FIVE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "5";
        }

        private void SIX_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "6";
        }

        private void SEVEN_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "7";
        }

        private void EIGHT_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "8";
        }

        private void NINE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text + "9";
        }

        private void ERASE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text.Remove(0, TEXTBOX1.Text.Length - 1);
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Clear();
        }

        private void TIMES_Click(object sender, EventArgs e)
        {
            TEXTBOX1.AppendText("*");
        }

        private void MINUS_Click(object sender, EventArgs e)
        {
            TEXTBOX1.AppendText("-");
        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.AppendText("/");
        }

        private void POINT_Click(object sender, EventArgs e)
        {
            TEXTBOX1.AppendText(".");
        }

        private void TEXTBOX1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
