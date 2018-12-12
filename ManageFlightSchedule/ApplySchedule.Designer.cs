namespace ManageFlightSchedule
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file with the changes";
            // 
            // textBoxImport
            // 
            this.textBoxImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxImport.Location = new System.Drawing.Point(15, 57);
            this.textBoxImport.Name = "textBoxImport";
            this.textBoxImport.Size = new System.Drawing.Size(319, 23);
            this.textBoxImport.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(340, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
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
            this.groupBox.Location = new System.Drawing.Point(15, 99);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 149);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Results";
            // 
            // labelMissing
            // 
            this.labelMissing.AutoSize = true;
            this.labelMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMissing.Location = new System.Drawing.Point(264, 106);
            this.labelMissing.Name = "labelMissing";
            this.labelMissing.Size = new System.Drawing.Size(39, 16);
            this.labelMissing.TabIndex = 0;
            this.labelMissing.Text = "[xxx]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Record with missing fields discarded :";
            // 
            // labelDuplicate
            // 
            this.labelDuplicate.AutoSize = true;
            this.labelDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuplicate.Location = new System.Drawing.Point(264, 72);
            this.labelDuplicate.Name = "labelDuplicate";
            this.labelDuplicate.Size = new System.Drawing.Size(39, 16);
            this.labelDuplicate.TabIndex = 0;
            this.labelDuplicate.Text = "[xxx]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Duplicate Records Discarced : ";
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.Location = new System.Drawing.Point(264, 35);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(39, 16);
            this.labelSuccess.TabIndex = 0;
            this.labelSuccess.Text = "[xxx]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Successful Changes Applied :";
            // 
            // ApplySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 260);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxImport);
            this.Controls.Add(this.label1);
            this.Name = "ApplySchedule";
            this.Text = "ApplySchedule";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelMissing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDuplicate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label label2;
    }
}