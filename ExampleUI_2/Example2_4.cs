using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleUI_2
{
    public partial class Example2_4 : Form
    {
        public Example2_4()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s;
            if (this.optSmall.Checked == true)
            {
                s = this.optSmall.Text;
            }
            else if (this.optMedium.Checked == true)
            {
                s = this.optMedium.Text;
            }
            else // (this.optLarge.Checked == true)
            {
                s = this.optLarge.Text;
            }

            MessageBox.Show(s + " is selected.");
        }
    }
}
