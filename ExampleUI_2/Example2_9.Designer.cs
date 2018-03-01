namespace ExampleUI_2
{
    partial class Example2_9
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
            this.myListBox1 = new System.Windows.Forms.ListBox();
            this.myListBox2 = new System.Windows.Forms.ListBox();
            this.myListBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // myListBox1
            // 
            this.myListBox1.FormattingEnabled = true;
            this.myListBox1.ItemHeight = 25;
            this.myListBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j"});
            this.myListBox1.Location = new System.Drawing.Point(61, 54);
            this.myListBox1.Name = "myListBox1";
            this.myListBox1.Size = new System.Drawing.Size(198, 229);
            this.myListBox1.TabIndex = 0;
            // 
            // myListBox2
            // 
            this.myListBox2.FormattingEnabled = true;
            this.myListBox2.ItemHeight = 25;
            this.myListBox2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j"});
            this.myListBox2.Location = new System.Drawing.Point(313, 54);
            this.myListBox2.Name = "myListBox2";
            this.myListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.myListBox2.Size = new System.Drawing.Size(198, 229);
            this.myListBox2.TabIndex = 1;
            // 
            // myListBox3
            // 
            this.myListBox3.FormattingEnabled = true;
            this.myListBox3.ItemHeight = 25;
            this.myListBox3.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j"});
            this.myListBox3.Location = new System.Drawing.Point(61, 327);
            this.myListBox3.Name = "myListBox3";
            this.myListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.myListBox3.Size = new System.Drawing.Size(450, 229);
            this.myListBox3.TabIndex = 2;
            // 
            // Example2_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 693);
            this.Controls.Add(this.myListBox3);
            this.Controls.Add(this.myListBox2);
            this.Controls.Add(this.myListBox1);
            this.Name = "Example2_9";
            this.Text = "Example2_9";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox myListBox1;
        private System.Windows.Forms.ListBox myListBox2;
        private System.Windows.Forms.ListBox myListBox3;
    }
}