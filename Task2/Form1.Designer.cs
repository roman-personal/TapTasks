namespace Task2 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.butRun = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(12, 14);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(94, 29);
            this.butRun.TabIndex = 0;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(112, 14);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(94, 29);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(776, 364);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butRun);
            this.Name = "Form1";
            this.Text = "Task2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ListBox listBox1;
    }
}
