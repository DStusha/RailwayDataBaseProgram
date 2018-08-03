namespace DataBaseProgram
{
    partial class fmAddTrip
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
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumTrain = new System.Windows.Forms.Label();
            this.cbTrain = new System.Windows.Forms.ComboBox();
            this.lbRealDT = new System.Windows.Forms.Label();
            this.dtpTime1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpTime2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Id_DepartureStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_ArrivalStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrips = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDriver
            // 
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(74, 38);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(211, 21);
            this.cbDriver.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фамилия машиниста";
            // 
            // lbNumTrain
            // 
            this.lbNumTrain.AutoSize = true;
            this.lbNumTrain.Location = new System.Drawing.Point(375, 23);
            this.lbNumTrain.Name = "lbNumTrain";
            this.lbNumTrain.Size = new System.Drawing.Size(80, 13);
            this.lbNumTrain.TabIndex = 13;
            this.lbNumTrain.Text = "Номер поезда";
            // 
            // cbTrain
            // 
            this.cbTrain.FormattingEnabled = true;
            this.cbTrain.Location = new System.Drawing.Point(378, 39);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(211, 21);
            this.cbTrain.TabIndex = 14;
            // 
            // lbRealDT
            // 
            this.lbRealDT.AutoSize = true;
            this.lbRealDT.Location = new System.Drawing.Point(71, 80);
            this.lbRealDT.Name = "lbRealDT";
            this.lbRealDT.Size = new System.Drawing.Size(214, 13);
            this.lbRealDT.TabIndex = 16;
            this.lbRealDT.Text = "Фактические дата и время отправления";
            // 
            // dtpTime1
            // 
            this.dtpTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime1.Location = new System.Drawing.Point(208, 96);
            this.dtpTime1.Name = "dtpTime1";
            this.dtpTime1.ShowUpDown = true;
            this.dtpTime1.Size = new System.Drawing.Size(77, 20);
            this.dtpTime1.TabIndex = 27;
            // 
            // dtpDate1
            // 
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate1.Location = new System.Drawing.Point(74, 96);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(105, 20);
            this.dtpDate1.TabIndex = 29;
            // 
            // dtpDate2
            // 
            this.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate2.Location = new System.Drawing.Point(378, 96);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(105, 20);
            this.dtpDate2.TabIndex = 32;
            // 
            // dtpTime2
            // 
            this.dtpTime2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime2.Location = new System.Drawing.Point(512, 96);
            this.dtpTime2.Name = "dtpTime2";
            this.dtpTime2.ShowUpDown = true;
            this.dtpTime2.Size = new System.Drawing.Size(77, 20);
            this.dtpTime2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Фактические дата и время прибытия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = " Выберите строку в расписании";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_DepartureStation,
            this.DepartureDate,
            this.DepartureTime,
            this.Id_ArrivalStation,
            this.ArrivalDate,
            this.ArrivalTime});
            this.dgvTable.Location = new System.Drawing.Point(-5, 169);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 40;
            this.dgvTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTable.Size = new System.Drawing.Size(694, 264);
            this.dgvTable.TabIndex = 54;
            this.dgvTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_RowHeaderMouseClick);
            // 
            // Id_DepartureStation
            // 
            this.Id_DepartureStation.DataPropertyName = "DepartureStation";
            this.Id_DepartureStation.HeaderText = "Станция отправления";
            this.Id_DepartureStation.Name = "Id_DepartureStation";
            this.Id_DepartureStation.ReadOnly = true;
            this.Id_DepartureStation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_DepartureStation.Width = 109;
            // 
            // DepartureDate
            // 
            this.DepartureDate.DataPropertyName = "DepartureDate";
            this.DepartureDate.HeaderText = "Дата отправления";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DepartureDate.Width = 109;
            // 
            // DepartureTime
            // 
            this.DepartureTime.DataPropertyName = "DepartureTime";
            this.DepartureTime.HeaderText = "Время отправления";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            this.DepartureTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DepartureTime.Width = 109;
            // 
            // Id_ArrivalStation
            // 
            this.Id_ArrivalStation.DataPropertyName = "ArrivalStation";
            this.Id_ArrivalStation.HeaderText = "Станция прибытия";
            this.Id_ArrivalStation.Name = "Id_ArrivalStation";
            this.Id_ArrivalStation.ReadOnly = true;
            this.Id_ArrivalStation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_ArrivalStation.Width = 109;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.DataPropertyName = "ArrivalDate";
            this.ArrivalDate.HeaderText = "Дата прибытия";
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.ReadOnly = true;
            this.ArrivalDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrivalDate.Width = 109;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "Время прибытия";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            this.ArrivalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrivalTime.Width = 109;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(442, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 28);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTrips
            // 
            this.btnAddTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrips.Location = new System.Drawing.Point(562, 448);
            this.btnAddTrips.Name = "btnAddTrips";
            this.btnAddTrips.Size = new System.Drawing.Size(102, 28);
            this.btnAddTrips.TabIndex = 55;
            this.btnAddTrips.Text = "Добавить рейс";
            this.btnAddTrips.UseVisualStyleBackColor = true;
            this.btnAddTrips.Click += new System.EventHandler(this.btnAddTrips_Click);
            // 
            // fmAddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 488);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrips);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate2);
            this.Controls.Add(this.dtpTime2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate1);
            this.Controls.Add(this.dtpTime1);
            this.Controls.Add(this.lbRealDT);
            this.Controls.Add(this.cbTrain);
            this.Controls.Add(this.lbNumTrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDriver);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 527);
            this.MinimumSize = new System.Drawing.Size(705, 527);
            this.Name = "fmAddTrip";
            this.Text = "Добавление рейса";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumTrain;
        private System.Windows.Forms.ComboBox cbTrain;
        private System.Windows.Forms.Label lbRealDT;
        private System.Windows.Forms.DateTimePicker dtpTime1;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpTime2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_DepartureStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ArrivalStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTrips;
    }
}