namespace DataBaseProgram
{
    partial class fmIntermediateStation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnISCancel = new System.Windows.Forms.Button();
            this.dtpIS3 = new System.Windows.Forms.DateTimePicker();
            this.btnISAddStation = new System.Windows.Forms.Button();
            this.lbIS4 = new System.Windows.Forms.Label();
            this.lbIS1 = new System.Windows.Forms.Label();
            this.dtpIS4 = new System.Windows.Forms.DateTimePicker();
            this.lbIS2 = new System.Windows.Forms.Label();
            this.dtpIS2 = new System.Windows.Forms.DateTimePicker();
            this.dtpIS1 = new System.Windows.Forms.DateTimePicker();
            this.lbIS3 = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.dgvIS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnISCancel);
            this.panel1.Controls.Add(this.dtpIS3);
            this.panel1.Controls.Add(this.btnISAddStation);
            this.panel1.Controls.Add(this.lbIS4);
            this.panel1.Controls.Add(this.lbIS1);
            this.panel1.Controls.Add(this.dtpIS4);
            this.panel1.Controls.Add(this.lbIS2);
            this.panel1.Controls.Add(this.dtpIS2);
            this.panel1.Controls.Add(this.dtpIS1);
            this.panel1.Controls.Add(this.lbIS3);
            this.panel1.Controls.Add(this.cbStation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 142);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Показать промежуточные станции",
            "Добавить промежуточную станцию"});
            this.listBox1.Location = new System.Drawing.Point(15, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 30);
            this.listBox1.TabIndex = 54;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnISCancel
            // 
            this.btnISCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnISCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnISCancel.Location = new System.Drawing.Point(535, 88);
            this.btnISCancel.Name = "btnISCancel";
            this.btnISCancel.Size = new System.Drawing.Size(102, 28);
            this.btnISCancel.TabIndex = 53;
            this.btnISCancel.Text = "Выход";
            this.btnISCancel.UseVisualStyleBackColor = true;
            // 
            // dtpIS3
            // 
            this.dtpIS3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIS3.Location = new System.Drawing.Point(407, 96);
            this.dtpIS3.Name = "dtpIS3";
            this.dtpIS3.ShowUpDown = true;
            this.dtpIS3.Size = new System.Drawing.Size(77, 20);
            this.dtpIS3.TabIndex = 47;
            this.dtpIS3.Visible = false;
            // 
            // btnISAddStation
            // 
            this.btnISAddStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnISAddStation.Location = new System.Drawing.Point(535, 40);
            this.btnISAddStation.Name = "btnISAddStation";
            this.btnISAddStation.Size = new System.Drawing.Size(102, 28);
            this.btnISAddStation.TabIndex = 52;
            this.btnISAddStation.Text = "Добавить";
            this.btnISAddStation.UseVisualStyleBackColor = true;
            this.btnISAddStation.Visible = false;
            this.btnISAddStation.Click += new System.EventHandler(this.btnISAddStation_Click);
            // 
            // lbIS4
            // 
            this.lbIS4.AutoSize = true;
            this.lbIS4.Location = new System.Drawing.Point(12, 22);
            this.lbIS4.Name = "lbIS4";
            this.lbIS4.Size = new System.Drawing.Size(107, 13);
            this.lbIS4.TabIndex = 50;
            this.lbIS4.Text = "Выберите действие";
            // 
            // lbIS1
            // 
            this.lbIS1.AutoSize = true;
            this.lbIS1.Location = new System.Drawing.Point(270, 29);
            this.lbIS1.Name = "lbIS1";
            this.lbIS1.Size = new System.Drawing.Size(101, 13);
            this.lbIS1.TabIndex = 49;
            this.lbIS1.Text = "Название станции";
            this.lbIS1.Visible = false;
            // 
            // dtpIS4
            // 
            this.dtpIS4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIS4.Location = new System.Drawing.Point(273, 96);
            this.dtpIS4.Name = "dtpIS4";
            this.dtpIS4.Size = new System.Drawing.Size(105, 20);
            this.dtpIS4.TabIndex = 48;
            this.dtpIS4.Visible = false;
            // 
            // lbIS2
            // 
            this.lbIS2.AutoSize = true;
            this.lbIS2.Location = new System.Drawing.Point(270, 80);
            this.lbIS2.Name = "lbIS2";
            this.lbIS2.Size = new System.Drawing.Size(190, 13);
            this.lbIS2.TabIndex = 46;
            this.lbIS2.Text = "Дата и время прибытия на станцию";
            this.lbIS2.Visible = false;
            // 
            // dtpIS2
            // 
            this.dtpIS2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIS2.Location = new System.Drawing.Point(15, 96);
            this.dtpIS2.Name = "dtpIS2";
            this.dtpIS2.Size = new System.Drawing.Size(105, 20);
            this.dtpIS2.TabIndex = 45;
            this.dtpIS2.Visible = false;
            // 
            // dtpIS1
            // 
            this.dtpIS1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIS1.Location = new System.Drawing.Point(149, 96);
            this.dtpIS1.Name = "dtpIS1";
            this.dtpIS1.ShowUpDown = true;
            this.dtpIS1.Size = new System.Drawing.Size(77, 20);
            this.dtpIS1.TabIndex = 44;
            this.dtpIS1.Visible = false;
            // 
            // lbIS3
            // 
            this.lbIS3.AutoSize = true;
            this.lbIS3.Location = new System.Drawing.Point(12, 80);
            this.lbIS3.Name = "lbIS3";
            this.lbIS3.Size = new System.Drawing.Size(204, 13);
            this.lbIS3.TabIndex = 43;
            this.lbIS3.Text = "Дата и время отправления со станции";
            this.lbIS3.Visible = false;
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(273, 45);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(211, 21);
            this.cbStation.TabIndex = 1;
            this.cbStation.Visible = false;
            // 
            // dgvIS
            // 
            this.dgvIS.AllowUserToAddRows = false;
            this.dgvIS.AllowUserToDeleteRows = false;
            this.dgvIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvIS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvIS.Location = new System.Drawing.Point(0, 141);
            this.dgvIS.Name = "dgvIS";
            this.dgvIS.ReadOnly = true;
            this.dgvIS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIS.Size = new System.Drawing.Size(663, 222);
            this.dgvIS.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Station";
            this.Column1.HeaderText = "Название станции";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id_id_Trip";
            this.Column2.HeaderText = "Номер рейса";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DepartureDate";
            this.Column3.HeaderText = "Дата прибытия";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DepartureTime";
            this.Column4.HeaderText = "Время прибытия";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ArrivalDate";
            this.Column5.HeaderText = "Дата отправления";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ArrivalTime";
            this.Column6.HeaderText = "Время отправления";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // fmIntermediateStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 363);
            this.Controls.Add(this.dgvIS);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(679, 402);
            this.MinimumSize = new System.Drawing.Size(679, 402);
            this.Name = "fmIntermediateStation";
            this.Text = "Промежуточные_станции";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.DataGridView dgvIS;
        private System.Windows.Forms.Label lbIS4;
        private System.Windows.Forms.Label lbIS1;
        private System.Windows.Forms.DateTimePicker dtpIS4;
        private System.Windows.Forms.DateTimePicker dtpIS3;
        private System.Windows.Forms.Label lbIS2;
        private System.Windows.Forms.DateTimePicker dtpIS2;
        private System.Windows.Forms.DateTimePicker dtpIS1;
        private System.Windows.Forms.Label lbIS3;
        private System.Windows.Forms.Button btnISCancel;
        private System.Windows.Forms.Button btnISAddStation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}