using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class contact_tracing_app : Form
    {
        public contact_tracing_app()
        {
            InitializeComponent();
        }

        private void START_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("contact_tracing.txt");
            outputFile.WriteLine(nametxt);
            outputFile.WriteLine(addresstxt);
            outputFile.WriteLine(temperaturetxt);
            outputFile.WriteLine("=================");
            outputFile.Close();
        }

        private void contact_tracing_app_Load(object sender, EventArgs e)
        {

        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            nametxt.Clear();
            addresstxt.Clear();
            temperaturetxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            starting.Visible = false;
            name.Visible = true;
            address.Visible = true;
            temperature.Visible = true;
            nametxt.Visible = true;
            addresstxt.Visible = true;
            temperaturetxt.Visible = true;
            welcome.Visible = true;
            DONE.Visible = true;
            clear.Visible = true;
        }
    }
}
