using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TICTACTOE : Form
    {
        bool player = true;
        byte player_count = 0;

        public TICTACTOE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void box_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (player)
                n.Text = "X";
            else
                n.Text = "O";

            player = !player;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by Roselle + her Taeil Photocards that inspires her to do this", "About Tic Tac Toe");
        }
    }
}
