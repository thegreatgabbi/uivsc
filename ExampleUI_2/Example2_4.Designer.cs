namespace ExampleUI_2
{
    partial class Example2_4
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
            this.optSmall = new System.Windows.Forms.RadioButton();
            this.optMedium = new System.Windows.Forms.RadioButton();
            this.optLarge = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Checked = true;
            this.optSmall.Location = new System.Drawing.Point(73, 54);
            this.optSmall.Name = "optSmall";
            this.optSmall.Size = new System.Drawing.Size(96, 29);
            this.optSmall.TabIndex = 0;
            this.optSmall.TabStop = true;
            this.optSmall.Text = "Small";
            this.optSmall.UseVisualStyleBackColor = true;
            // 
            // optMedium
            // 
            this.optMedium.AutoSize = true;
            this.optMedium.Location = new System.Drawing.Point(73, 127);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(119, 29);
            this.optMedium.TabIndex = 1;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            // 
            // optLarge
            // 
            this.optLarge.AutoSize = true;
            this.optLarge.Location = new System.Drawing.Point(73, 209);
            this.optLarge.Name = "optLarge";
            this.optLarge.Size = new System.Drawing.Size(98, 29);
            this.optLarge.TabIndex = 2;
            this.optLarge.Text = "Large";
            this.optLarge.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(73, 286);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(255, 85);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Get Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Example2_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 433);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.optLarge);
            this.Controls.Add(this.optMedium);
            this.Controls.Add(this.optSmall);
            this.Name = "Example2_4";
            this.Text = "Example2_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optSmall;
        private System.Windows.Forms.RadioButton optMedium;
        private System.Windows.Forms.RadioButton optLarge;
        private System.Windows.Forms.Button btnOrder;
    }
}