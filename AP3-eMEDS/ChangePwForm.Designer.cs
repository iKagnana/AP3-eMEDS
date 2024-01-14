namespace AP3_eMEDS
{
    partial class ChangePwForm
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
            this.changePwBtn = new System.Windows.Forms.Button();
            this.PwLabel = new System.Windows.Forms.Label();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changePwBtn
            // 
            this.changePwBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePwBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.changePwBtn.Location = new System.Drawing.Point(94, 123);
            this.changePwBtn.Name = "changePwBtn";
            this.changePwBtn.Size = new System.Drawing.Size(204, 23);
            this.changePwBtn.TabIndex = 63;
            this.changePwBtn.Text = "Modifier le mot de passe";
            this.changePwBtn.UseVisualStyleBackColor = false;
            this.changePwBtn.Click += new System.EventHandler(this.changePwBtn_Click);
            // 
            // PwLabel
            // 
            this.PwLabel.AutoSize = true;
            this.PwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwLabel.Location = new System.Drawing.Point(91, 69);
            this.PwLabel.Name = "PwLabel";
            this.PwLabel.Size = new System.Drawing.Size(161, 18);
            this.PwLabel.TabIndex = 62;
            this.PwLabel.Text = "Nouveau mot de passe";
            // 
            // pwTxt
            // 
            this.pwTxt.Enabled = false;
            this.pwTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwTxt.Location = new System.Drawing.Point(94, 90);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.Size = new System.Drawing.Size(204, 26);
            this.pwTxt.TabIndex = 61;
            this.pwTxt.UseSystemPasswordChar = true;
            // 
            // ChangePwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 209);
            this.Controls.Add(this.changePwBtn);
            this.Controls.Add(this.PwLabel);
            this.Controls.Add(this.pwTxt);
            this.Name = "ChangePwForm";
            this.Text = "Changement de mot de passe - GSB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePwBtn;
        private System.Windows.Forms.Label PwLabel;
        private System.Windows.Forms.TextBox pwTxt;
    }
}