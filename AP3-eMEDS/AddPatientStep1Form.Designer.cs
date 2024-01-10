namespace AP3_eMEDS
{
    partial class AddPatientStep1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientStep1Form));
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumSecuLabel = new System.Windows.Forms.Label();
            this.numSecuTxt = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorNumSecu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nom";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.Location = new System.Drawing.Point(175, 307);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(404, 44);
            this.lastNameTxt.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 63);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ajout de patient";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(174, 808);
            this.addBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(408, 83);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "Prénom";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.Location = new System.Drawing.Point(175, 415);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(404, 44);
            this.firstNameTxt.TabIndex = 35;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(12, 37);
            this.radioMale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(116, 29);
            this.radioMale.TabIndex = 37;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Homme";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(12, 81);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(114, 29);
            this.radioFemale.TabIndex = 38;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Femme";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Location = new System.Drawing.Point(174, 619);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // NumSecuLabel
            // 
            this.NumSecuLabel.AutoSize = true;
            this.NumSecuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSecuLabel.Location = new System.Drawing.Point(169, 480);
            this.NumSecuLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NumSecuLabel.Name = "NumSecuLabel";
            this.NumSecuLabel.Size = new System.Drawing.Size(384, 36);
            this.NumSecuLabel.TabIndex = 41;
            this.NumSecuLabel.Text = "Numéro de Sécurité Sociale";
            // 
            // numSecuTxt
            // 
            this.numSecuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSecuTxt.Location = new System.Drawing.Point(175, 521);
            this.numSecuTxt.Margin = new System.Windows.Forms.Padding(6);
            this.numSecuTxt.Name = "numSecuTxt";
            this.numSecuTxt.Size = new System.Drawing.Size(404, 44);
            this.numSecuTxt.TabIndex = 40;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(47, 90);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(691, 37);
            this.labelError.TabIndex = 42;
            this.labelError.Text = "Attention ! Certains champs ont été mal remplis";
            this.labelError.Visible = false;
            // 
            // labelErrorNumSecu
            // 
            this.labelErrorNumSecu.AutoSize = true;
            this.labelErrorNumSecu.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNumSecu.Location = new System.Drawing.Point(227, 571);
            this.labelErrorNumSecu.Name = "labelErrorNumSecu";
            this.labelErrorNumSecu.Size = new System.Drawing.Size(355, 25);
            this.labelErrorNumSecu.TabIndex = 43;
            this.labelErrorNumSecu.Text = "Le champ doit comporter 15 chiffres";
            this.labelErrorNumSecu.Visible = false;
            // 
            // AddPatientStep1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 1188);
            this.Controls.Add(this.labelErrorNumSecu);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.NumSecuLabel);
            this.Controls.Add(this.numSecuTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddPatientStep1Form";
            this.Text = "Ajout du patient étape 1 - GSB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NumSecuLabel;
        private System.Windows.Forms.TextBox numSecuTxt;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorNumSecu;
    }
}