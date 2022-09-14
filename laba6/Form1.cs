using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected_ind = listBox1.SelectedIndex;
            string str = listBox1.Items[selected_ind].ToString();
            label1.Text = str.Replace("А", "*");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, "АВОВА");
            listBox1.Items.Insert(0, "АВОВА");
        }

    }
}
