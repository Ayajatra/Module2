namespace ManageFlightSchedule
{
    partial class ManageFlight
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerOutbound = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancelFlight = new System.Windows.Forms.Button();
            this.buttonImportChange = new System.Windows.Forms.Button();
            this.buttonEditFlight = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonApply);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.textBoxFlightNumber);
            this.groupBox.Controls.Add(this.dateTimePickerOutbound);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.comboBoxSortBy);
            this.groupBox.Controls.Add(this.comboBoxTo);
            this.groupBox.Controls.Add(this.comboBoxFrom);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox.Location = new System.Drawing.Point(16, 15);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(957, 156);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filter by";
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonApply.Location = new System.Drawing.Point(761, 76);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(148, 27);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Outbound:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFlightNumber.Location = new System.Drawing.Point(487, 78);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(103, 23);
            this.textBoxFlightNumber.TabIndex = 4;
            // 
            // dateTimePickerOutbound
            // 
            this.dateTimePickerOutbound.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOutbound.Location = new System.Drawing.Point(89, 80);
            this.dateTimePickerOutbound.Name = "dateTimePickerOutbound";
            this.dateTimePickerOutbound.Size = new System.Drawing.Size(159, 23);
            this.dateTimePickerOutbound.TabIndex = 3;
            this.dateTimePickerOutbound.Value = new System.DateTime(2018, 12, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(383, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Flight Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(702, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sort by:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(383, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(761, 34);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(148, 24);
            this.comboBoxSortBy.TabIndex = 2;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(431, 34);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(159, 24);
            this.comboBoxTo.TabIndex = 2;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(89, 34);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(159, 24);
            this.comboBoxFrom.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCancelFlight
            // 
            this.buttonCancelFlight.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancelFlight.ForeColor = System.Drawing.Color.White;
            this.buttonCancelFlight.Location = new System.Drawing.Point(16, 562);
            this.buttonCancelFlight.Name = "buttonCancelFlight";
            this.buttonCancelFlight.Size = new System.Drawing.Size(164, 47);
            this.buttonCancelFlight.TabIndex = 1;
            this.buttonCancelFlight.Text = "Cancel Flight";
            this.buttonCancelFlight.UseVisualStyleBackColor = false;
            // 
            // buttonImportChange
            // 
            this.buttonImportChange.BackColor = System.Drawing.Color.Green;
            this.buttonImportChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonImportChange.ForeColor = System.Drawing.Color.White;
            this.buttonImportChange.Location = new System.Drawing.Point(835, 562);
            this.buttonImportChange.Name = "buttonImportChange";
            this.buttonImportChange.Size = new System.Drawing.Size(138, 47);
            this.buttonImportChange.TabIndex = 1;
            this.buttonImportChange.Text = "Import Changes";
            this.buttonImportChange.UseVisualStyleBackColor = false;
            // 
            // buttonEditFlight
            // 
            this.buttonEditFlight.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEditFlight.ForeColor = System.Drawing.Color.White;
            this.buttonEditFlight.Location = new System.Drawing.Point(198, 562);
            this.buttonEditFlight.Name = "buttonEditFlight";
            this.buttonEditFlight.Size = new System.Drawing.Size(164, 47);
            this.buttonEditFlight.TabIndex = 1;
            this.buttonEditFlight.Text = "Edit Flight";
            this.buttonEditFlight.UseVisualStyleBackColor = false;
            // 
            // ManageFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 621);
            this.Controls.Add(this.buttonEditFlight);
            this.Controls.Add(this.buttonImportChange);
            this.Controls.Add(this.buttonCancelFlight);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "ManageFlight";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutbound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelFlight;
        private System.Windows.Forms.Button buttonImportChange;
        private System.Windows.Forms.Button buttonEditFlight;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
    }
}

