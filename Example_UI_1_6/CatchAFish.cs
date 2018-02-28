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
    public partial class CatchAFish : Form
    {
        public CatchAFish()
        {
            InitializeComponent();
        }

        private void Fish_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            this.Fish.Location = new System.Drawing.Point(this.Fish.Location.X + r.Next(-50, 50), this.Fish.Location.Y + r.Next(-50, 50));
        }
    }
}
