namespace DataBaseProgram
{
    partial class fmAddTicket
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
            this.cbFIO = new System.Windows.Forms.ComboBox();
            this.cbAS = new System.Windows.Forms.ComboBox();
            this.cbDS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nPlase = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrips = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNumTrip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nPlase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО Пассажира";
            // 
            // cbFIO
            // 
            this.cbFIO.FormattingEnabled = true;
            this.cbFIO.Location = new System.Drawing.Point(38, 55);
            this.cbFIO.Name = "cbFIO";
            this.cbFIO.Size = new System.Drawing.Size(180, 21);
            this.cbFIO.TabIndex = 1;
            // 
            // cbAS
            // 
            this.cbAS.FormattingEnabled = true;
            this.cbAS.Location = new System.Drawing.Point(260, 106);
            this.cbAS.Name = "cbAS";
            this.cbAS.Size = new System.Drawing.Size(180, 21);
            this.cbAS.TabIndex = 8;
            // 
            // cbDS
            // 
            this.cbDS.FormattingEnabled = true;
            this.cbDS.Location = new System.Drawing.Point(38, 106);
            this.cbDS.Name = "cbDS";
            this.cbDS.Size = new System.Drawing.Size(180, 21);
            this.cbDS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Станция высадки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Станция посадки";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(38, 160);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(180, 21);
            this.cbType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тип вагона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер места";
            // 
            // nPlase
            // 
            this.nPlase.Location = new System.Drawing.Point(260, 160);
            this.nPlase.Name = "nPlase";
            this.nPlase.Size = new System.Drawing.Size(180, 20);
            this.nPlase.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(74, 210);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(144, 20);
            this.tbPrice.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 28);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTrips
            // 
            this.btnAddTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrips.Location = new System.Drawing.Point(361, 205);
            this.btnAddTrips.Name = "btnAddTrips";
            this.btnAddTrips.Size = new System.Drawing.Size(79, 28);
            this.btnAddTrips.TabIndex = 35;
            this.btnAddTrips.Text = "Добавить";
            this.btnAddTrips.UseVisualStyleBackColor = true;
            this.btnAddTrips.Click += new System.EventHandler(this.btnAddTrips_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Номер рейса";
            // 
            // cbNumTrip
            // 
            this.cbNumTrip.FormattingEnabled = true;
            this.cbNumTrip.Location = new System.Drawing.Point(260, 55);
            this.cbNumTrip.Name = "cbNumTrip";
            this.cbNumTrip.Size = new System.Drawing.Size(180, 21);
            this.cbNumTrip.TabIndex = 40;
            // 
            // fmAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 266);
            this.Controls.Add(this.cbNumTrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrips);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nPlase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbAS);
            this.Controls.Add(this.cbDS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFIO);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 305);
            this.MinimumSize = new System.Drawing.Size(487, 305);
            this.Name = "fmAddTicket";
            this.Text = "Добавить билет";
            ((System.ComponentModel.ISupportInitialize)(this.nPlase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFIO;
        private System.Windows.Forms.ComboBox cbAS;
        private System.Windows.Forms.ComboBox cbDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nPlase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTrips;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbNumTrip;
    }
}