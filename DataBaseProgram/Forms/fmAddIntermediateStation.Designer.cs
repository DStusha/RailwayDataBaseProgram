namespace DataBaseProgram
{
    partial class fmAddIntermediateStation
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
            this.dtpAD = new System.Windows.Forms.DateTimePicker();
            this.dtpAT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrips = new System.Windows.Forms.Button();
            this.dtpDD = new System.Windows.Forms.DateTimePicker();
            this.dtpDT = new System.Windows.Forms.DateTimePicker();
            this.lbRealDT = new System.Windows.Forms.Label();
            this.cbS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpAD
            // 
            this.dtpAD.Location = new System.Drawing.Point(36, 148);
            this.dtpAD.Name = "dtpAD";
            this.dtpAD.Size = new System.Drawing.Size(142, 20);
            this.dtpAD.TabIndex = 47;
            // 
            // dtpAT
            // 
            this.dtpAT.CustomFormat = "";
            this.dtpAT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAT.Location = new System.Drawing.Point(184, 148);
            this.dtpAT.Name = "dtpAT";
            this.dtpAT.ShowUpDown = true;
            this.dtpAT.Size = new System.Drawing.Size(72, 20);
            this.dtpAT.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Дата и время отправления";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(37, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 28);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTrips
            // 
            this.btnAddTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrips.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddTrips.Location = new System.Drawing.Point(153, 204);
            this.btnAddTrips.Name = "btnAddTrips";
            this.btnAddTrips.Size = new System.Drawing.Size(102, 28);
            this.btnAddTrips.TabIndex = 43;
            this.btnAddTrips.Text = "Добавить";
            this.btnAddTrips.UseVisualStyleBackColor = true;
            this.btnAddTrips.Click += new System.EventHandler(this.btnAddTrips_Click);
            // 
            // dtpDD
            // 
            this.dtpDD.Location = new System.Drawing.Point(36, 99);
            this.dtpDD.Name = "dtpDD";
            this.dtpDD.Size = new System.Drawing.Size(142, 20);
            this.dtpDD.TabIndex = 42;
            // 
            // dtpDT
            // 
            this.dtpDT.CustomFormat = "";
            this.dtpDT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDT.Location = new System.Drawing.Point(184, 99);
            this.dtpDT.Name = "dtpDT";
            this.dtpDT.ShowUpDown = true;
            this.dtpDT.Size = new System.Drawing.Size(72, 20);
            this.dtpDT.TabIndex = 41;
            // 
            // lbRealDT
            // 
            this.lbRealDT.AutoSize = true;
            this.lbRealDT.Location = new System.Drawing.Point(35, 83);
            this.lbRealDT.Name = "lbRealDT";
            this.lbRealDT.Size = new System.Drawing.Size(129, 13);
            this.lbRealDT.TabIndex = 40;
            this.lbRealDT.Text = "Дата и время прибытия";
            // 
            // cbS
            // 
            this.cbS.FormattingEnabled = true;
            this.cbS.Location = new System.Drawing.Point(36, 49);
            this.cbS.Name = "cbS";
            this.cbS.Size = new System.Drawing.Size(218, 21);
            this.cbS.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Станция ";
            // 
            // fmAddIntermediateStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 263);
            this.Controls.Add(this.dtpAD);
            this.Controls.Add(this.dtpAT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrips);
            this.Controls.Add(this.dtpDD);
            this.Controls.Add(this.dtpDT);
            this.Controls.Add(this.lbRealDT);
            this.Controls.Add(this.cbS);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(311, 302);
            this.MinimumSize = new System.Drawing.Size(311, 302);
            this.Name = "fmAddIntermediateStation";
            this.Text = "Промежуточные станции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAD;
        private System.Windows.Forms.DateTimePicker dtpAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTrips;
        private System.Windows.Forms.DateTimePicker dtpDD;
        private System.Windows.Forms.DateTimePicker dtpDT;
        private System.Windows.Forms.Label lbRealDT;
        private System.Windows.Forms.ComboBox cbS;
        private System.Windows.Forms.Label label10;
    }
}