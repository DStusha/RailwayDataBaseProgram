namespace DataBaseProgram
{
    partial class fmChangeTicket
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOldValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.cbNew = new System.Windows.Forms.ComboBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.nudNew = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNew)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Новое значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Старое значение";
            // 
            // tbOldValue
            // 
            this.tbOldValue.Location = new System.Drawing.Point(44, 57);
            this.tbOldValue.Name = "tbOldValue";
            this.tbOldValue.Size = new System.Drawing.Size(270, 20);
            this.tbOldValue.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(86, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 28);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChange.Location = new System.Drawing.Point(212, 157);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(102, 28);
            this.btnChange.TabIndex = 35;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cbNew
            // 
            this.cbNew.FormattingEnabled = true;
            this.cbNew.Location = new System.Drawing.Point(44, 109);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(270, 21);
            this.cbNew.TabIndex = 37;
            this.cbNew.Visible = false;
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(44, 109);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(270, 20);
            this.tbNew.TabIndex = 38;
            this.tbNew.Visible = false;
            // 
            // nudNew
            // 
            this.nudNew.Location = new System.Drawing.Point(44, 110);
            this.nudNew.Name = "nudNew";
            this.nudNew.Size = new System.Drawing.Size(82, 20);
            this.nudNew.TabIndex = 39;
            this.nudNew.Visible = false;
            // 
            // fmChangeTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 212);
            this.Controls.Add(this.nudNew);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.cbNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOldValue);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 251);
            this.MinimumSize = new System.Drawing.Size(372, 251);
            this.Name = "fmChangeTicket";
            ((System.ComponentModel.ISupportInitialize)(this.nudNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOldValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cbNew;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.NumericUpDown nudNew;
    }
}