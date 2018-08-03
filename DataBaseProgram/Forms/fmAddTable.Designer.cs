namespace DataBaseProgram
{
    partial class fmAddTableRow
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
            this.cbAT2 = new System.Windows.Forms.ComboBox();
            this.cbAT1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDD = new System.Windows.Forms.DateTimePicker();
            this.dtpDT = new System.Windows.Forms.DateTimePicker();
            this.lbRealDT = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrips = new System.Windows.Forms.Button();
            this.dtpAD = new System.Windows.Forms.DateTimePicker();
            this.dtpAT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAT2
            // 
            this.cbAT2.FormattingEnabled = true;
            this.cbAT2.Location = new System.Drawing.Point(47, 99);
            this.cbAT2.Name = "cbAT2";
            this.cbAT2.Size = new System.Drawing.Size(218, 21);
            this.cbAT2.TabIndex = 8;
            // 
            // cbAT1
            // 
            this.cbAT1.FormattingEnabled = true;
            this.cbAT1.Location = new System.Drawing.Point(47, 47);
            this.cbAT1.Name = "cbAT1";
            this.cbAT1.Size = new System.Drawing.Size(218, 21);
            this.cbAT1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Станция прибытия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Станция отправления";
            // 
            // dtpDD
            // 
            this.dtpDD.Location = new System.Drawing.Point(47, 149);
            this.dtpDD.Name = "dtpDD";
            this.dtpDD.Size = new System.Drawing.Size(142, 20);
            this.dtpDD.TabIndex = 32;
            // 
            // dtpDT
            // 
            this.dtpDT.CustomFormat = "";
            this.dtpDT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDT.Location = new System.Drawing.Point(195, 149);
            this.dtpDT.Name = "dtpDT";
            this.dtpDT.ShowUpDown = true;
            this.dtpDT.Size = new System.Drawing.Size(72, 20);
            this.dtpDT.TabIndex = 31;
            // 
            // lbRealDT
            // 
            this.lbRealDT.AutoSize = true;
            this.lbRealDT.Location = new System.Drawing.Point(46, 133);
            this.lbRealDT.Name = "lbRealDT";
            this.lbRealDT.Size = new System.Drawing.Size(129, 13);
            this.lbRealDT.TabIndex = 29;
            this.lbRealDT.Text = "Дата и время прибытия";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(49, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 28);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTrips
            // 
            this.btnAddTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrips.Location = new System.Drawing.Point(165, 254);
            this.btnAddTrips.Name = "btnAddTrips";
            this.btnAddTrips.Size = new System.Drawing.Size(102, 28);
            this.btnAddTrips.TabIndex = 33;
            this.btnAddTrips.Text = "Добавить";
            this.btnAddTrips.UseVisualStyleBackColor = true;
            this.btnAddTrips.Click += new System.EventHandler(this.btnAddTrips_Click);
            // 
            // dtpAD
            // 
            this.dtpAD.Location = new System.Drawing.Point(47, 198);
            this.dtpAD.Name = "dtpAD";
            this.dtpAD.Size = new System.Drawing.Size(142, 20);
            this.dtpAD.TabIndex = 37;
            // 
            // dtpAT
            // 
            this.dtpAT.CustomFormat = "";
            this.dtpAT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAT.Location = new System.Drawing.Point(195, 198);
            this.dtpAT.Name = "dtpAT";
            this.dtpAT.ShowUpDown = true;
            this.dtpAT.Size = new System.Drawing.Size(72, 20);
            this.dtpAT.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Дата и время отправления";
            // 
            // fmAddTableRow
            // 
            this.AcceptButton = this.btnAddTrips;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(319, 309);
            this.Controls.Add(this.dtpAD);
            this.Controls.Add(this.dtpAT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrips);
            this.Controls.Add(this.dtpDD);
            this.Controls.Add(this.dtpDT);
            this.Controls.Add(this.lbRealDT);
            this.Controls.Add(this.cbAT2);
            this.Controls.Add(this.cbAT1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 348);
            this.MinimumSize = new System.Drawing.Size(335, 348);
            this.Name = "fmAddTableRow";
            this.Text = "Добавить в расписание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAT2;
        private System.Windows.Forms.ComboBox cbAT1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDD;
        private System.Windows.Forms.DateTimePicker dtpDT;
        private System.Windows.Forms.Label lbRealDT;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTrips;
        private System.Windows.Forms.DateTimePicker dtpAD;
        private System.Windows.Forms.DateTimePicker dtpAT;
        private System.Windows.Forms.Label label1;
    }
}