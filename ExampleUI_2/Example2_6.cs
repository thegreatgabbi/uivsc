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
    public partial class Example2_6 : Form
    {
        public Example2_6()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s, f, t;

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
                f = "chocolate ";
            } else // optStrawberry.Checked
            {
                f = "strawberry ";
            }

            if (!optNuts.Checked && !optRaisins.Checked && !optRaisins.Checked )
            {
                t = "with no toppings ";
            }
            else
            {
                t = "with toppings: ";
                if (optNuts.Checked)
                {
                    t += "nuts ";
                }
                if (optRaisins.Checked)
                {
                    t += "raisins ";
                }
                if (optChocolateChips.Checked)
                {
                    t += "chocolate chips ";
                }
            }
            MessageBox.Show("A " + s + ", " + f + "ice cream with "+ t + "is selected.");
        }
    }
}
