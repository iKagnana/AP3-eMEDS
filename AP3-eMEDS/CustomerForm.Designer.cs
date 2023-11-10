namespace AP3_eMEDS
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.labelSiret = new System.Windows.Forms.Label();
            this.siretTxt = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.helperTextPass = new System.Windows.Forms.Label();
            this.helperTextSiret = new System.Windows.Forms.Label();
            this.helperTextEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSiret
            // 
            this.labelSiret.AutoSize = true;
            this.labelSiret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSiret.Location = new System.Drawing.Point(287, 134);
            this.labelSiret.Name = "labelSiret";
            this.labelSiret.Size = new System.Drawing.Size(38, 18);
            this.labelSiret.TabIndex = 33;
            this.labelSiret.Text = "Siret";
            // 
            // siretTxt
            // 
            this.siretTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siretTxt.Location = new System.Drawing.Point(290, 155);
            this.siretTxt.Name = "siretTxt";
            this.siretTxt.Size = new System.Drawing.Size(204, 26);
            this.siretTxt.TabIndex = 32;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(63, 134);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 18);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Nom";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(66, 155);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(204, 26);
            this.nameTxt.TabIndex = 28;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmBtn.Location = new System.Drawing.Point(187, 408);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(204, 43);
            this.confirmBtn.TabIndex = 26;
            this.confirmBtn.Text = "Valider";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.title.Location = new System.Drawing.Point(215, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(111, 26);
            this.title.TabIndex = 25;
            this.title.Text = "Inscription";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(63, 210);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 18);
            this.labelEmail.TabIndex = 39;
            this.labelEmail.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(66, 231);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(204, 26);
            this.emailTxt.TabIndex = 38;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(287, 210);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 18);
            this.labelPassword.TabIndex = 41;
            this.labelPassword.Text = "Mot de passe";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(290, 231);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(204, 26);
            this.passwordTxt.TabIndex = 40;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Adresse";
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(107, 336);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(357, 26);
            this.addressTxt.TabIndex = 42;
            // 
            // helperTextPass
            // 
            this.helperTextPass.AutoSize = true;
            this.helperTextPass.ForeColor = System.Drawing.Color.Red;
            this.helperTextPass.Location = new System.Drawing.Point(291, 260);
            this.helperTextPass.MaximumSize = new System.Drawing.Size(204, 0);
            this.helperTextPass.Name = "helperTextPass";
            this.helperTextPass.Size = new System.Drawing.Size(0, 13);
            this.helperTextPass.TabIndex = 44;
            // 
            // helperTextSiret
            // 
            this.helperTextSiret.AutoSize = true;
            this.helperTextSiret.ForeColor = System.Drawing.Color.Red;
            this.helperTextSiret.Location = new System.Drawing.Point(290, 188);
            this.helperTextSiret.MaximumSize = new System.Drawing.Size(204, 0);
            this.helperTextSiret.Name = "helperTextSiret";
            this.helperTextSiret.Size = new System.Drawing.Size(0, 13);
            this.helperTextSiret.TabIndex = 45;
            // 
            // helperTextEmail
            // 
            this.helperTextEmail.AutoSize = true;
            this.helperTextEmail.ForeColor = System.Drawing.Color.Red;
            this.helperTextEmail.Location = new System.Drawing.Point(66, 260);
            this.helperTextEmail.MaximumSize = new System.Drawing.Size(204, 0);
            this.helperTextEmail.Name = "helperTextEmail";
            this.helperTextEmail.Size = new System.Drawing.Size(0, 13);
            this.helperTextEmail.TabIndex = 46;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 527);
            this.Controls.Add(this.helperTextEmail);
            this.Controls.Add(this.helperTextSiret);
            this.Controls.Add(this.helperTextPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.labelSiret);
            this.Controls.Add(this.siretTxt);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "Inscription Client - GSB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSiret;
        private System.Windows.Forms.TextBox siretTxt;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label helperTextPass;
        private System.Windows.Forms.Label helperTextSiret;
        private System.Windows.Forms.Label helperTextEmail;
    }
}