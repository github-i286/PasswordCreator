namespace PasswordCreator
{
    partial class PasswordCreatorDialog
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
            PasswordCreator.Properties.Settings settings1 = new PasswordCreator.Properties.Settings();
            PasswordCreator.Config config1 = new PasswordCreator.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordCreatorDialog));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYZ = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbInclLowercase = new System.Windows.Forms.CheckBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(319, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 127);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(320, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create && Copy to Clipboard";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Include special characters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length";
            // 
            // cbYZ
            // 
            this.cbYZ.AutoSize = true;
            settings1.InclDigits = true;
            settings1.InclEasy = true;
            settings1.InclLowercase = true;
            settings1.NumberOfChars = new decimal(new int[] {
            8,
            0,
            0,
            0});
            settings1.SettingsKey = "";
            this.cbYZ.Checked = settings1.InclEasy;
            this.cbYZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbYZ.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "InclEasy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbYZ.Location = new System.Drawing.Point(13, 96);
            this.cbYZ.Name = "cbYZ";
            this.cbYZ.Size = new System.Drawing.Size(189, 17);
            this.cbYZ.TabIndex = 6;
            this.cbYZ.Text = "Incl. easily mistaken chars (YZIO0)";
            this.cbYZ.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = settings1.InclDigits;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "InclDigits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNumbers.Location = new System.Drawing.Point(116, 73);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(73, 17);
            this.cbNumbers.TabIndex = 0;
            this.cbNumbers.Text = "Incl. digits";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbInclLowercase
            // 
            this.cbInclLowercase.AutoSize = true;
            this.cbInclLowercase.Checked = settings1.InclLowercase;
            this.cbInclLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInclLowercase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "InclLowercase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbInclLowercase.Location = new System.Drawing.Point(13, 73);
            this.cbInclLowercase.Name = "cbInclLowercase";
            this.cbInclLowercase.Size = new System.Drawing.Size(97, 17);
            this.cbInclLowercase.TabIndex = 4;
            this.cbInclLowercase.Text = "Incl. lowercase";
            this.cbInclLowercase.UseVisualStyleBackColor = true;
            // 
            // numLength
            // 
            this.numLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", settings1, "NumberOfChars", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numLength.Location = new System.Drawing.Point(147, 16);
            this.numLength.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(44, 20);
            this.numLength.TabIndex = 1;
            this.numLength.Value = settings1.NumberOfChars;
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(147, 42);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(184, 20);
            this.txtSpecial.TabIndex = 3;
            config1.SettingsKey = "";
            this.txtSpecial.Text = config1.Special;
            // 
            // PasswordCreatorDialog
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 181);
            this.Controls.Add(this.cbYZ);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbInclLowercase);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSpecial);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordCreatorDialog";
            this.Text = "Password Creator";
            this.Load += new System.EventHandler(this.PasswordCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.CheckBox cbInclLowercase;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.CheckBox cbYZ;
    }
}

