namespace DataBaseProgram
{
    partial class fmAddCancelledtrip
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
            this.cbNumTrip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbReason = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTrips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNumTrip
            // 
            this.cbNumTrip.FormattingEnabled = true;
            this.cbNumTrip.Location = new System.Drawing.Point(27, 49);
            this.cbNumTrip.Name = "cbNumTrip";
            this.cbNumTrip.Size = new System.Drawing.Size(240, 21);
            this.cbNumTrip.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Номер рейса";
            // 
            // cbReason
            // 
            this.cbReason.FormattingEnabled = true;
            this.cbReason.Location = new System.Drawing.Point(27, 102);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(240, 21);
            this.cbReason.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Причина отмены";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(87, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 28);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTrips
            // 
            this.btnAddTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrips.Location = new System.Drawing.Point(188, 146);
            this.btnAddTrips.Name = "btnAddTrips";
            this.btnAddTrips.Size = new System.Drawing.Size(79, 28);
            this.btnAddTrips.TabIndex = 45;
            this.btnAddTrips.Text = "Добавить";
            this.btnAddTrips.UseVisualStyleBackColor = true;
            this.btnAddTrips.Click += new System.EventHandler(this.btnAddTrips_Click);
            // 
            // fmAddCancelledtrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 198);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrips);
            this.Controls.Add(this.cbReason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNumTrip);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(309, 237);
            this.MinimumSize = new System.Drawing.Size(309, 237);
            this.Name = "fmAddCancelledtrip";
            this.Text = "Добавить рейс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNumTrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTrips;
    }
}