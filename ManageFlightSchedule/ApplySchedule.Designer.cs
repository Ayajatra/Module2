﻿namespace ManageFlightSchedule
{
    partial class ApplySchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImport = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelMissing = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDuplicate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file with the changes";
            // 
            // textBoxImport
            // 
            this.textBoxImport.Enabled = false;
            this.textBoxImport.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImport.Location = new System.Drawing.Point(19, 87);
            this.textBoxImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxImport.Name = "textBoxImport";
            this.textBoxImport.Size = new System.Drawing.Size(423, 25);
            this.textBoxImport.TabIndex = 1;
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.Green;
            this.buttonImport.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(453, 83);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(99, 44);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelMissing);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.labelDuplicate);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.labelSuccess);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox.Location = new System.Drawing.Point(19, 153);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Size = new System.Drawing.Size(533, 229);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Results";
            // 
            // labelMissing
            // 
            this.labelMissing.AutoSize = true;
            this.labelMissing.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMissing.Location = new System.Drawing.Point(352, 163);
            this.labelMissing.Name = "labelMissing";
            this.labelMissing.Size = new System.Drawing.Size(46, 19);
            this.labelMissing.TabIndex = 0;
            this.labelMissing.Text = "[xxx]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Record with missing fields discarded :";
            // 
            // labelDuplicate
            // 
            this.labelDuplicate.AutoSize = true;
            this.labelDuplicate.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuplicate.Location = new System.Drawing.Point(352, 111);
            this.labelDuplicate.Name = "labelDuplicate";
            this.labelDuplicate.Size = new System.Drawing.Size(46, 19);
            this.labelDuplicate.TabIndex = 0;
            this.labelDuplicate.Text = "[xxx]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Duplicate Records Discarced : ";
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.Location = new System.Drawing.Point(352, 54);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(46, 19);
            this.labelSuccess.TabIndex = 0;
            this.labelSuccess.Text = "[xxx]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Successful Changes Applied :";
            // 
            // ApplySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.textBoxImport);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplySchedule";
            this.Text = "ApplySchedule";
            this.Load += new System.EventHandler(this.ApplySchedule_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelMissing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDuplicate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label label2;
    }
}