namespace AP3_eMEDS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createCBtn = new System.Windows.Forms.Button();
            this.loginCBtn = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginEBtn = new System.Windows.Forms.Button();
            this.Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Customer.Controls.Add(this.label2);
            this.Customer.Controls.Add(this.pictureBox1);
            this.Customer.Controls.Add(this.createCBtn);
            this.Customer.Controls.Add(this.loginCBtn);
            resources.ApplyResources(this.Customer, "Customer");
            this.Customer.Name = "Customer";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AP3_eMEDS.Properties.Resources.icons8_bâtiment_50;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // createCBtn
            // 
            resources.ApplyResources(this.createCBtn, "createCBtn");
            this.createCBtn.ForeColor = System.Drawing.Color.White;
            this.createCBtn.Name = "createCBtn";
            this.createCBtn.UseVisualStyleBackColor = true;
            this.createCBtn.Click += new System.EventHandler(this.createCBtn_Click);
            // 
            // loginCBtn
            // 
            resources.ApplyResources(this.loginCBtn, "loginCBtn");
            this.loginCBtn.ForeColor = System.Drawing.Color.White;
            this.loginCBtn.Name = "loginCBtn";
            this.loginCBtn.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Employee.Controls.Add(this.label3);
            this.Employee.Controls.Add(this.pictureBox2);
            this.Employee.Controls.Add(this.loginEBtn);
            resources.ApplyResources(this.Employee, "Employee");
            this.Employee.Name = "Employee";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AP3_eMEDS.Properties.Resources.icons8_utilisateur_50;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // loginEBtn
            // 
            resources.ApplyResources(this.loginEBtn, "loginEBtn");
            this.loginEBtn.ForeColor = System.Drawing.Color.White;
            this.loginEBtn.Name = "loginEBtn";
            this.loginEBtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LoginForm";
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Employee.ResumeLayout(false);
            this.Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Customer;
        private System.Windows.Forms.Button loginCBtn;
        private System.Windows.Forms.Panel Employee;
        private System.Windows.Forms.Button createCBtn;
        private System.Windows.Forms.Button loginEBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}