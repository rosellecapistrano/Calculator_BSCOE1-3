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
            TEXTBOX1.AppendText("0");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PLUS_Click(object sender, EventArgs e)
        {

        }

        private void TEXTBOX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TWO_Click(object sender, EventArgs e)
        {

        }

        private void AC_Click(object sender, EventArgs e)
        {
            TEXTBOX1.Clear();
        }
    }
}
