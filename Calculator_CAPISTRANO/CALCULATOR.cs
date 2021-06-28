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

        private void AC_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Clear();
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

        private void btn_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            TEXTBOX1.Text = TEXTBOX1.Text + n; 
        }
    }
}
