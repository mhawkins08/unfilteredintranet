using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unfiliteredintranet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS IS A SECURE BROWSER AND IS NOT MEANT FOR DAY TO DAY USE, JAVASCRIPT IS NOT SUPPORTED AND NOR IS ANYTHING ELSE.");
            MessageBox.Show("Make sure that your VPN is enabled before using this web-browserw");
            browser bs = new browser();
            bs.Show();
            
        
        }
    }
}
