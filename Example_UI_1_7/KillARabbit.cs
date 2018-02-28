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
    public partial class KillARabbit : Form
    {
        public KillARabbit()
        {
            InitializeComponent();
        }

        private void Rabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.Rabbit.BackColor = System.Drawing.SystemColors.Highlight;
            this.Rabbit.Image = Image.FromFile(@"Z:\gabrielwong On My Mac\Google Drive\Documents\Studies\SA46\SA4102\UIVSC\Image\sadRabbit.GIF");
        }
        private void Rabbit_MouseUp(object sender, MouseEventArgs e)
        {
            this.Rabbit.Location = new System.Drawing.Point(this.Rabbit.Location.X + 10, this.Rabbit.Location.Y + 10);
            this.Rabbit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Rabbit.Image = Image.FromFile(@"Z:\gabrielwong On My Mac\Google Drive\Documents\Studies\SA46\SA4102\UIVSC\Image\happyRabbit.GIF");
        }
    }
}
