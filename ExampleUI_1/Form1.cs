using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleUI_1_2a
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

        private void btnButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1 has been Clicked.");
            MessageBox.Show("Height is = " + btnButton1.Height + " and Width is " + btnButton1.Width);
        }
    }
}
