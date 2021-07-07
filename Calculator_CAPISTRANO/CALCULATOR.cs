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
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btn_clicked)
            {
                TEXTBOX1.Clear();
            }
            btn_clicked = false;
            Button n = (Button)sender;
            TEXTBOX1.Text = TEXTBOX1.Text + n.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            arithmetic = c.Text;
            num = float.Parse(TEXTBOX1.Text);
            btn_clicked = true;
        }

        private void memorycalc_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutcal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Roselle Bianca Capistrano of BSCOE 1-3", "About Calculator");
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (arithmetic)
            {
                case "+":
                    TEXTBOX1.Text = (num + float.Parse(TEXTBOX1.Text)).ToString();
                    break;

                case "x":
                    TEXTBOX1.Text = (num * float.Parse(TEXTBOX1.Text)).ToString();
                    break;

                case "/":
                    TEXTBOX1.Text = (num / float.Parse(TEXTBOX1.Text)).ToString();
                    break;

                case "-":
                    TEXTBOX1.Text = (num - float.Parse(TEXTBOX1.Text)).ToString();
                    break;
                default:
                    break;
            }
            btn_clicked = false;
        }
    }
}
