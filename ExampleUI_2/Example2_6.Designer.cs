namespace ExampleUI_2
{
    partial class Example2_6
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
            this.gboSize = new System.Windows.Forms.GroupBox();
            this.gboFlavor = new System.Windows.Forms.GroupBox();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optChoc = new System.Windows.Forms.RadioButton();
            this.gboToppings = new System.Windows.Forms.GroupBox();
            this.optNuts = new System.Windows.Forms.CheckBox();
            this.optRaisins = new System.Windows.Forms.CheckBox();
            this.optChocolateChips = new System.Windows.Forms.CheckBox();
            this.gboSize.SuspendLayout();
            this.gboFlavor.SuspendLayout();
            this.gboToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Checked = true;
            this.optSmall.Location = new System.Drawing.Point(34, 72);
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
            this.optMedium.Location = new System.Drawing.Point(34, 145);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(119, 29);
            this.optMedium.TabIndex = 1;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            // 
            // optLarge
            // 
            this.optLarge.AutoSize = true;
            this.optLarge.Location = new System.Drawing.Point(34, 227);
            this.optLarge.Name = "optLarge";
            this.optLarge.Size = new System.Drawing.Size(98, 29);
            this.optLarge.TabIndex = 2;
            this.optLarge.Text = "Large";
            this.optLarge.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(39, 948);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(255, 85);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Get Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.optSmall);
            this.gboSize.Controls.Add(this.optLarge);
            this.gboSize.Controls.Add(this.optMedium);
            this.gboSize.Location = new System.Drawing.Point(39, 32);
            this.gboSize.Name = "gboSize";
            this.gboSize.Size = new System.Drawing.Size(352, 308);
            this.gboSize.TabIndex = 4;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // gboFlavor
            // 
            this.gboFlavor.Controls.Add(this.optStrawberry);
            this.gboFlavor.Controls.Add(this.optChoc);
            this.gboFlavor.Location = new System.Drawing.Point(39, 376);
            this.gboFlavor.Name = "gboFlavor";
            this.gboFlavor.Size = new System.Drawing.Size(352, 230);
            this.gboFlavor.TabIndex = 5;
            this.gboFlavor.TabStop = false;
            this.gboFlavor.Text = "Flavor";
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(34, 163);
            this.optStrawberry.Name = "optStrawberry";
            this.optStrawberry.Size = new System.Drawing.Size(146, 29);
            this.optStrawberry.TabIndex = 1;
            this.optStrawberry.Text = "Strawberry";
            this.optStrawberry.UseVisualStyleBackColor = true;
            // 
            // optChoc
            // 
            this.optChoc.AutoSize = true;
            this.optChoc.Checked = true;
            this.optChoc.Location = new System.Drawing.Point(34, 76);
            this.optChoc.Name = "optChoc";
            this.optChoc.Size = new System.Drawing.Size(140, 29);
            this.optChoc.TabIndex = 0;
            this.optChoc.TabStop = true;
            this.optChoc.Text = "Chocolate";
            this.optChoc.UseVisualStyleBackColor = true;
            // 
            // gboToppings
            // 
            this.gboToppings.Controls.Add(this.optChocolateChips);
            this.gboToppings.Controls.Add(this.optRaisins);
            this.gboToppings.Controls.Add(this.optNuts);
            this.gboToppings.Location = new System.Drawing.Point(39, 640);
            this.gboToppings.Name = "gboToppings";
            this.gboToppings.Size = new System.Drawing.Size(352, 266);
            this.gboToppings.TabIndex = 6;
            this.gboToppings.TabStop = false;
            this.gboToppings.Text = "Toppings";
            // 
            // optNuts
            // 
            this.optNuts.AutoSize = true;
            this.optNuts.Location = new System.Drawing.Point(34, 54);
            this.optNuts.Name = "optNuts";
            this.optNuts.Size = new System.Drawing.Size(88, 29);
            this.optNuts.TabIndex = 0;
            this.optNuts.Text = "Nuts";
            this.optNuts.UseVisualStyleBackColor = true;
            // 
            // optRaisins
            // 
            this.optRaisins.AutoSize = true;
            this.optRaisins.Location = new System.Drawing.Point(34, 122);
            this.optRaisins.Name = "optRaisins";
            this.optRaisins.Size = new System.Drawing.Size(115, 29);
            this.optRaisins.TabIndex = 1;
            this.optRaisins.Text = "Raisins";
            this.optRaisins.UseVisualStyleBackColor = true;
            // 
            // optChocolateChips
            // 
            this.optChocolateChips.AutoSize = true;
            this.optChocolateChips.Location = new System.Drawing.Point(34, 194);
            this.optChocolateChips.Name = "optChocolateChips";
            this.optChocolateChips.Size = new System.Drawing.Size(202, 29);
            this.optChocolateChips.TabIndex = 2;
            this.optChocolateChips.Text = "Chocolate Chips";
            this.optChocolateChips.UseVisualStyleBackColor = true;
            // 
            // Example2_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 1107);
            this.Controls.Add(this.gboToppings);
            this.Controls.Add(this.gboFlavor);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gboSize);
            this.Name = "Example2_6";
            this.Text = "Example2_5";
            this.gboSize.ResumeLayout(false);
            this.gboSize.PerformLayout();
            this.gboFlavor.ResumeLayout(false);
            this.gboFlavor.PerformLayout();
            this.gboToppings.ResumeLayout(false);
            this.gboToppings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optSmall;
        private System.Windows.Forms.RadioButton optMedium;
        private System.Windows.Forms.RadioButton optLarge;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.GroupBox gboFlavor;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optChoc;
        private System.Windows.Forms.GroupBox gboToppings;
        private System.Windows.Forms.CheckBox optChocolateChips;
        private System.Windows.Forms.CheckBox optRaisins;
        private System.Windows.Forms.CheckBox optNuts;
    }
}