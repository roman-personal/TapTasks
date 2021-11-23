namespace Task3 {
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblNumeric = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblBoolean = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butRun
            // 
            this.butRun.Location = new System.Drawing.Point(12, 12);
            this.butRun.Name = "butRun";
            this.butRun.Size = new System.Drawing.Size(75, 23);
            this.butRun.TabIndex = 0;
            this.butRun.Text = "Run";
            this.butRun.UseVisualStyleBackColor = true;
            this.butRun.Click += new System.EventHandler(this.butRun_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: unknown";
            // 
            // lblFormulas
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(12, 110);
            this.lblFormula.Name = "lblFormulas";
            this.lblFormula.Size = new System.Drawing.Size(112, 15);
            this.lblFormula.TabIndex = 2;
            this.lblFormula.Text = "Formula: unknown";
            // 
            // lblStrings
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 140);
            this.lblText.Name = "lblStrings";
            this.lblText.Size = new System.Drawing.Size(99, 15);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text: unknown";
            // 
            // lblNumerics
            // 
            this.lblNumeric.AutoSize = true;
            this.lblNumeric.Location = new System.Drawing.Point(12, 170);
            this.lblNumeric.Name = "lblNumerics";
            this.lblNumeric.Size = new System.Drawing.Size(114, 15);
            this.lblNumeric.TabIndex = 4;
            this.lblNumeric.Text = "Numeric: unknown";
            // 
            // lblErrors
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 200);
            this.lblError.Name = "lblErrors";
            this.lblError.Size = new System.Drawing.Size(93, 15);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error: unknown";
            // 
            // lblBooleans
            // 
            this.lblBoolean.AutoSize = true;
            this.lblBoolean.Location = new System.Drawing.Point(12, 230);
            this.lblBoolean.Name = "lblBooleans";
            this.lblBoolean.Size = new System.Drawing.Size(111, 15);
            this.lblBoolean.TabIndex = 6;
            this.lblBoolean.Text = "Boolean: unknown";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.Filter = "Excel files|*.xlsx;*.xls;*.xlsb;*.csv";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(103, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 50);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(81, 15);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "File: unknown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 267);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblBoolean);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblNumeric);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.butRun);
            this.Name = "Form1";
            this.Text = "Task3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRun;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblNumeric;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblBoolean;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFile;
    }
}
