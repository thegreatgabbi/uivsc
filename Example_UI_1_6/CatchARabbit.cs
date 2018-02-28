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
    public partial class CatchARabbit : Form
    {
        public CatchARabbit()
        {
            InitializeComponent();
        }

        private void btnRabbit_Click(object sender, EventArgs e)
        {
            this.btnRabbit.Location = new System.Drawing.Point(100, 150);
        }
    }
}
