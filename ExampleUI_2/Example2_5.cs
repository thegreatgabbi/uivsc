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
    public partial class Example2_5 : Form
    {
        public Example2_5()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s, f;

            if (optSmall.Checked)
            {
                s = "small";
            } else if (optMedium.Checked)
            {
                s = "medium";
            } else // (optLarge.Checked)
            {
                s = "large";
            }

            if (optChoc.Checked)
            {
                f = "chocolate";
            } else // optStrawberry.Checked
            {
                f = "strawberry";
            }
            
            MessageBox.Show("A " + s + " " + f + " flavored ice cream is selected.");
        }
    }
}
