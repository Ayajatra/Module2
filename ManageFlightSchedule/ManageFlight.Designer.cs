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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancelFlight = new System.Windows.Forms.Button();
            this.buttonImportChange = new System.Windows.Forms.Button();
            this.buttonEditFlight = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.groupBox.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.groupBox.Location = new System.Drawing.Point(14, 14);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox.Size = new System.Drawing.Size(856, 146);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filter by";
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.buttonApply.Location = new System.Drawing.Point(666, 72);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(129, 25);
            this.buttonApply.TabIndex = 5;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Outbound:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.textBoxFlightNumber.Location = new System.Drawing.Point(425, 74);
            this.textBoxFlightNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(90, 25);
            this.textBoxFlightNumber.TabIndex = 3;
            // 
            // dateTimePickerOutbound
            // 
            this.dateTimePickerOutbound.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOutbound.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.dateTimePickerOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOutbound.Location = new System.Drawing.Point(100, 76);
            this.dateTimePickerOutbound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePickerOutbound.Name = "dateTimePickerOutbound";
            this.dateTimePickerOutbound.Size = new System.Drawing.Size(139, 25);
            this.dateTimePickerOutbound.TabIndex = 1;
            this.dateTimePickerOutbound.Value = new System.DateTime(2018, 12, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label4.Location = new System.Drawing.Point(311, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Flight Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label5.Location = new System.Drawing.Point(595, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sort by:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label3.Location = new System.Drawing.Point(311, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(666, 33);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(130, 27);
            this.comboBoxSortBy.TabIndex = 4;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(367, 33);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(139, 27);
            this.comboBoxTo.TabIndex = 2;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(92, 33);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(139, 27);
            this.comboBoxFrom.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(14, 192);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Size = new System.Drawing.Size(856, 329);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView_CellStateChanged);
            // 
            // buttonCancelFlight
            // 
            this.buttonCancelFlight.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelFlight.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.buttonCancelFlight.ForeColor = System.Drawing.Color.White;
            this.buttonCancelFlight.Location = new System.Drawing.Point(14, 527);
            this.buttonCancelFlight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancelFlight.Name = "buttonCancelFlight";
            this.buttonCancelFlight.Size = new System.Drawing.Size(143, 44);
            this.buttonCancelFlight.TabIndex = 1;
            this.buttonCancelFlight.Text = "Cancel Flight";
            this.buttonCancelFlight.UseVisualStyleBackColor = false;
            this.buttonCancelFlight.Click += new System.EventHandler(this.buttonCancelFlight_Click);
            // 
            // buttonImportChange
            // 
            this.buttonImportChange.BackColor = System.Drawing.Color.Green;
            this.buttonImportChange.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.buttonImportChange.ForeColor = System.Drawing.Color.White;
            this.buttonImportChange.Location = new System.Drawing.Point(684, 527);
            this.buttonImportChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonImportChange.Name = "buttonImportChange";
            this.buttonImportChange.Size = new System.Drawing.Size(187, 44);
            this.buttonImportChange.TabIndex = 3;
            this.buttonImportChange.Text = "Import Changes";
            this.buttonImportChange.UseVisualStyleBackColor = false;
            this.buttonImportChange.Click += new System.EventHandler(this.buttonImportChange_Click);
            // 
            // buttonEditFlight
            // 
            this.buttonEditFlight.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEditFlight.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.buttonEditFlight.ForeColor = System.Drawing.Color.White;
            this.buttonEditFlight.Location = new System.Drawing.Point(173, 527);
            this.buttonEditFlight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEditFlight.Name = "buttonEditFlight";
            this.buttonEditFlight.Size = new System.Drawing.Size(143, 44);
            this.buttonEditFlight.TabIndex = 2;
            this.buttonEditFlight.Text = "Edit Flight";
            this.buttonEditFlight.UseVisualStyleBackColor = false;
            this.buttonEditFlight.Click += new System.EventHandler(this.buttonEditFlight_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label6.Location = new System.Drawing.Point(730, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "= Cancelled Flight";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label7.Location = new System.Drawing.Point(707, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "   ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label8.Location = new System.Drawing.Point(563, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "= Confirmed Flight";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.label9.Location = new System.Drawing.Point(540, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "   ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ManageFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 582);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonEditFlight);
            this.Controls.Add(this.buttonImportChange);
            this.Controls.Add(this.buttonCancelFlight);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Flight";
            this.Load += new System.EventHandler(this.ManageFlight_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCancelFlight;
        private System.Windows.Forms.Button buttonImportChange;
        private System.Windows.Forms.Button buttonEditFlight;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

