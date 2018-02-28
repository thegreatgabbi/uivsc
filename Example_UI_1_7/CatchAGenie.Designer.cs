namespace Example_UI_1_3a
{
    partial class CatchAGenie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchAGenie));
            this.Lamp = new System.Windows.Forms.PictureBox();
            this.Genie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genie)).BeginInit();
            this.SuspendLayout();
            // 
            // Lamp
            // 
            this.Lamp.Image = ((System.Drawing.Image)(resources.GetObject("Lamp.Image")));
            this.Lamp.Location = new System.Drawing.Point(527, 558);
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(146, 97);
            this.Lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lamp.TabIndex = 0;
            this.Lamp.TabStop = false;
            this.Lamp.Click += new System.EventHandler(this.Lamp_Click);
            this.Lamp.DoubleClick += new System.EventHandler(this.Lamp_DoubleClick);
            // 
            // Genie
            // 
            this.Genie.Image = ((System.Drawing.Image)(resources.GetObject("Genie.Image")));
            this.Genie.Location = new System.Drawing.Point(877, 174);
            this.Genie.Name = "Genie";
            this.Genie.Size = new System.Drawing.Size(258, 348);
            this.Genie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Genie.TabIndex = 1;
            this.Genie.TabStop = false;
            this.Genie.Visible = false;
            this.Genie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Genie_MouseMove);
            // 
            // CatchAGenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1288, 773);
            this.Controls.Add(this.Genie);
            this.Controls.Add(this.Lamp);
            this.Name = "CatchAGenie";
            this.Text = "CatchAGenie";
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Lamp;
        private System.Windows.Forms.PictureBox Genie;
    }
}