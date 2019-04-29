namespace WinForm_DataInput
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPassportNo = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxGivenName = new System.Windows.Forms.TextBox();
            this.tbxNationality = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passport No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Given Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // tbxPassportNo
            // 
            this.tbxPassportNo.Location = new System.Drawing.Point(232, 24);
            this.tbxPassportNo.Name = "tbxPassportNo";
            this.tbxPassportNo.Size = new System.Drawing.Size(159, 24);
            this.tbxPassportNo.TabIndex = 5;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(232, 84);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(159, 24);
            this.tbxSurname.TabIndex = 6;
            // 
            // tbxGivenName
            // 
            this.tbxGivenName.Location = new System.Drawing.Point(232, 144);
            this.tbxGivenName.Name = "tbxGivenName";
            this.tbxGivenName.Size = new System.Drawing.Size(159, 24);
            this.tbxGivenName.TabIndex = 7;
            // 
            // tbxNationality
            // 
            this.tbxNationality.Location = new System.Drawing.Point(232, 210);
            this.tbxNationality.Name = "tbxNationality";
            this.tbxNationality.Size = new System.Drawing.Size(159, 24);
            this.tbxNationality.TabIndex = 8;
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(232, 264);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(159, 24);
            this.dtpDob.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 67);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 67);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 461);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.tbxNationality);
            this.Controls.Add(this.tbxGivenName);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxPassportNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Personal Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPassportNo;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxGivenName;
        private System.Windows.Forms.TextBox tbxNationality;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}

