namespace Example_UI_1_3a
{
    partial class CatchARabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchARabbit));
            this.btnRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRabbit
            // 
            this.btnRabbit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRabbit.BackgroundImage")));
            this.btnRabbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRabbit.Location = new System.Drawing.Point(527, 272);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(273, 181);
            this.btnRabbit.TabIndex = 0;
            this.btnRabbit.Text = "Rabbit";
            this.btnRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.Click += new System.EventHandler(this.btnRabbit_Click);
            // 
            // CatchARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.btnRabbit);
            this.Name = "CatchARabbit";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRabbit;
    }
}