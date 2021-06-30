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
        float num = 0;
        bool btn_clicked = false;
        String arithmetic = "";

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

        private void AC_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Clear();
        }

        private void ERASE_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Text = TEXTBOX1.Text.Substring(0, TEXTBOX1.Text.Length - 1);
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Clear();
            TEXTBOX1.Text = "0";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (TEXTBOX1.Text == "0" | btn_clicked)
            {
                TEXTBOX1.Clear();
            }
            Button n = (Button)sender;
            TEXTBOX1.Text = TEXTBOX1.Text + n.Text;
            num = float.Parse(TEXTBOX1.Text);
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            arithmetic = n.Text;
            btn_clicked = true;
        }
    }
}
