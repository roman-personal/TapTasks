﻿namespace Task3 {
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
            this.lblFormulas = new System.Windows.Forms.Label();
            this.lblStrings = new System.Windows.Forms.Label();
            this.lblNumerics = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblBooleans = new System.Windows.Forms.Label();
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
            this.lblFormulas.AutoSize = true;
            this.lblFormulas.Location = new System.Drawing.Point(12, 110);
            this.lblFormulas.Name = "lblFormulas";
            this.lblFormulas.Size = new System.Drawing.Size(112, 15);
            this.lblFormulas.TabIndex = 2;
            this.lblFormulas.Text = "Formulas: unknown";
            // 
            // lblStrings
            // 
            this.lblStrings.AutoSize = true;
            this.lblStrings.Location = new System.Drawing.Point(12, 140);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(99, 15);
            this.lblStrings.TabIndex = 3;
            this.lblStrings.Text = "Strings: unknown";
            // 
            // lblNumerics
            // 
            this.lblNumerics.AutoSize = true;
            this.lblNumerics.Location = new System.Drawing.Point(12, 170);
            this.lblNumerics.Name = "lblNumerics";
            this.lblNumerics.Size = new System.Drawing.Size(114, 15);
            this.lblNumerics.TabIndex = 4;
            this.lblNumerics.Text = "Numerics: unknown";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(12, 200);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(93, 15);
            this.lblErrors.TabIndex = 5;
            this.lblErrors.Text = "Errors: unknown";
            // 
            // lblBooleans
            // 
            this.lblBooleans.AutoSize = true;
            this.lblBooleans.Location = new System.Drawing.Point(12, 230);
            this.lblBooleans.Name = "lblBooleans";
            this.lblBooleans.Size = new System.Drawing.Size(111, 15);
            this.lblBooleans.TabIndex = 6;
            this.lblBooleans.Text = "Booleans: unknown";
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
            this.Controls.Add(this.lblBooleans);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblNumerics);
            this.Controls.Add(this.lblStrings);
            this.Controls.Add(this.lblFormulas);
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
        private System.Windows.Forms.Label lblFormulas;
        private System.Windows.Forms.Label lblStrings;
        private System.Windows.Forms.Label lblNumerics;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblBooleans;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFile;
    }
}