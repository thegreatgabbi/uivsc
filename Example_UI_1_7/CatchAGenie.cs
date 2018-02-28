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
    public partial class CatchAGenie : Form
    {
        public CatchAGenie()
        {
            InitializeComponent();
        }

        private void Lamp_Click(object sender, EventArgs e)
        {
            this.Genie.Visible = true;
        }

        private void Genie_MouseMove(object sender, MouseEventArgs e)
        {
            this.Genie.Visible = false;
        }

        private void Lamp_DoubleClick(object sender, EventArgs e)
        {
            this.Genie.Size = new System.Drawing.Size(this.Genie.Size.Width * 2, this.Genie.Size.Height * 2);
        }
    }
}
