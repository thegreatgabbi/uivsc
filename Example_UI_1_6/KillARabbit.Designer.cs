namespace Example_UI_1_3a
{
    partial class KillARabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KillARabbit));
            this.Rabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rabbit
            // 
            this.Rabbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rabbit.Image = ((System.Drawing.Image)(resources.GetObject("Rabbit.Image")));
            this.Rabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Rabbit.Location = new System.Drawing.Point(525, 448);
            this.Rabbit.Name = "Rabbit";
            this.Rabbit.Size = new System.Drawing.Size(163, 119);
            this.Rabbit.TabIndex = 0;
            this.Rabbit.Text = "Rabbit";
            this.Rabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rabbit.UseVisualStyleBackColor = true;
            this.Rabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseDown);
            this.Rabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseUp);
            // 
            // KillARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 827);
            this.Controls.Add(this.Rabbit);
            this.Name = "KillARabbit";
            this.Text = "KillARabbit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rabbit;
    }
}