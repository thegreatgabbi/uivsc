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
    public partial class Example2_10 : Form
    {
        public Example2_10()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string s, f, t;

            if (comboSize.Text == "Small")
            {
                s = "small";
            } else if (comboSize.Text == "Medium")
            {
                s = "medium";
            }
            else // (comboSize.Text == "Large")
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

            if (optToppings.SelectedItems.Count == 0)
            {
                t = "with no toppings ";
            }
            else
            {
                t = "with ";
                foreach (object i in optToppings.SelectedItems)
                {
                    t += i.ToString() + " ";
                }
            }

            MessageBox.Show("A " + s + ", " + f + " ice cream " + t + "is selected.");
        }

        private void optToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
