using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_UI_1_3a
{
    public partial class MySecondForm : Form
    {
        public MySecondForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(450, 350);
            MessageBox.Show("New Screen");
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye bye");
        }
    }
}
