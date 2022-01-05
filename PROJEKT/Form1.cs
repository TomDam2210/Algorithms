using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zid zid = new Zid();
        
        private void button1_Click(object sender, EventArgs e)
        {

            string reez = zid.Police(int.Parse(txtZid.Text), int.Parse(txtPolica1.Text), int.Parse(txtPolica2.Text));
            richTextBox1.AppendText(reez);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtZid.Text = "";
            txtPolica1.Text = "";
            txtPolica2.Text = "";
            richTextBox1.Clear();

        }
    }
}
