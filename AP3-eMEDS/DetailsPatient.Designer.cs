namespace AP3_eMEDS
{
    partial class DetailsPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsPatient));
            this.labelErrorNumSecu = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.NumSecuLabel = new System.Windows.Forms.Label();
            this.numSecuTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addAnBtn = new System.Windows.Forms.Button();
            this.addAlBtn = new System.Windows.Forms.Button();
            this.dataGridAn = new System.Windows.Forms.DataGridView();
            this.dataGridAl = new System.Windows.Forms.DataGridView();
            this.labelAn = new System.Windows.Forms.Label();
            this.comboAn = new System.Windows.Forms.ComboBox();
            this.labelAl = new System.Windows.Forms.Label();
            this.comboAl = new System.Windows.Forms.ComboBox();
            this.supprBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelErrorNumSecu
            // 
            this.labelErrorNumSecu.AutoSize = true;
            this.labelErrorNumSecu.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNumSecu.Location = new System.Drawing.Point(106, 266);
            this.labelErrorNumSecu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorNumSecu.Name = "labelErrorNumSecu";
            this.labelErrorNumSecu.Size = new System.Drawing.Size(176, 13);
            this.labelErrorNumSecu.TabIndex = 54;
            this.labelErrorNumSecu.Text = "Le champ doit comporter 15 chiffres";
            this.labelErrorNumSecu.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(16, 16);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(342, 20);
            this.labelError.TabIndex = 53;
            this.labelError.Text = "Attention ! Certains champs ont été mal remplis";
            this.labelError.Visible = false;
            // 
            // NumSecuLabel
            // 
            this.NumSecuLabel.AutoSize = true;
            this.NumSecuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSecuLabel.Location = new System.Drawing.Point(76, 219);
            this.NumSecuLabel.Name = "NumSecuLabel";
            this.NumSecuLabel.Size = new System.Drawing.Size(193, 18);
            this.NumSecuLabel.TabIndex = 52;
            this.NumSecuLabel.Text = "Numéro de Sécurité Sociale";
            // 
            // numSecuTxt
            // 
            this.numSecuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSecuTxt.Location = new System.Drawing.Point(80, 240);
            this.numSecuTxt.Name = "numSecuTxt";
            this.numSecuTxt.Size = new System.Drawing.Size(204, 26);
            this.numSecuTxt.TabIndex = 51;
            this.numSecuTxt.TextChanged += new System.EventHandler(this.numSecuTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Location = new System.Drawing.Point(79, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(6, 19);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(61, 17);
            this.radioMale.TabIndex = 37;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Homme";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(6, 42);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 38;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Femme";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Prénom";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.Location = new System.Drawing.Point(80, 185);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(204, 26);
            this.firstNameTxt.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nom";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.Location = new System.Drawing.Point(80, 129);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(204, 26);
            this.lastNameTxt.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ajout de patient";
            // 
            // addAnBtn
            // 
            this.addAnBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnBtn.Location = new System.Drawing.Point(680, 278);
            this.addAnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addAnBtn.Name = "addAnBtn";
            this.addAnBtn.Size = new System.Drawing.Size(33, 23);
            this.addAnBtn.TabIndex = 62;
            this.addAnBtn.Text = "+";
            this.addAnBtn.UseVisualStyleBackColor = false;
            // 
            // addAlBtn
            // 
            this.addAlBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlBtn.Location = new System.Drawing.Point(680, 40);
            this.addAlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addAlBtn.Name = "addAlBtn";
            this.addAlBtn.Size = new System.Drawing.Size(33, 23);
            this.addAlBtn.TabIndex = 61;
            this.addAlBtn.Text = "+";
            this.addAlBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridAn
            // 
            this.dataGridAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAn.Location = new System.Drawing.Point(428, 309);
            this.dataGridAn.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAn.Name = "dataGridAn";
            this.dataGridAn.RowHeadersWidth = 82;
            this.dataGridAn.RowTemplate.Height = 33;
            this.dataGridAn.Size = new System.Drawing.Size(285, 154);
            this.dataGridAn.TabIndex = 60;
            this.dataGridAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAn_CellContentClick);
            // 
            // dataGridAl
            // 
            this.dataGridAl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAl.Location = new System.Drawing.Point(428, 71);
            this.dataGridAl.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAl.Name = "dataGridAl";
            this.dataGridAl.RowHeadersWidth = 82;
            this.dataGridAl.RowTemplate.Height = 33;
            this.dataGridAl.Size = new System.Drawing.Size(285, 153);
            this.dataGridAl.TabIndex = 59;
            this.dataGridAl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAl_CellContentClick);
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Location = new System.Drawing.Point(428, 261);
            this.labelAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(73, 13);
            this.labelAn.TabIndex = 58;
            this.labelAn.Text = "Antécédent(s)";
            // 
            // comboAn
            // 
            this.comboAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAn.FormattingEnabled = true;
            this.comboAn.Location = new System.Drawing.Point(428, 277);
            this.comboAn.Margin = new System.Windows.Forms.Padding(2);
            this.comboAn.Name = "comboAn";
            this.comboAn.Size = new System.Drawing.Size(238, 28);
            this.comboAn.TabIndex = 57;
            this.comboAn.SelectedIndexChanged += new System.EventHandler(this.comboAn_SelectedIndexChanged);
            // 
            // labelAl
            // 
            this.labelAl.AutoSize = true;
            this.labelAl.Location = new System.Drawing.Point(428, 23);
            this.labelAl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAl.Name = "labelAl";
            this.labelAl.Size = new System.Drawing.Size(52, 13);
            this.labelAl.TabIndex = 56;
            this.labelAl.Text = "Allergie(s)";
            // 
            // comboAl
            // 
            this.comboAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAl.FormattingEnabled = true;
            this.comboAl.Location = new System.Drawing.Point(428, 39);
            this.comboAl.Margin = new System.Windows.Forms.Padding(2);
            this.comboAl.Name = "comboAl";
            this.comboAl.Size = new System.Drawing.Size(238, 28);
            this.comboAl.TabIndex = 55;
            this.comboAl.SelectedIndexChanged += new System.EventHandler(this.comboAl_SelectedIndexChanged);
            // 
            // supprBtn
            // 
            this.supprBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprBtn.ForeColor = System.Drawing.Color.Red;
            this.supprBtn.Location = new System.Drawing.Point(78, 433);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(204, 31);
            this.supprBtn.TabIndex = 64;
            this.supprBtn.Text = "Supprimer le patient";
            this.supprBtn.UseVisualStyleBackColor = true;
            this.supprBtn.Click += new System.EventHandler(this.supprBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmBtn.Location = new System.Drawing.Point(78, 375);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(204, 43);
            this.confirmBtn.TabIndex = 63;
            this.confirmBtn.Text = "Valider les modifications";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // DetailsPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 487);
            this.Controls.Add(this.supprBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.addAnBtn);
            this.Controls.Add(this.addAlBtn);
            this.Controls.Add(this.dataGridAn);
            this.Controls.Add(this.dataGridAl);
            this.Controls.Add(this.labelAn);
            this.Controls.Add(this.comboAn);
            this.Controls.Add(this.labelAl);
            this.Controls.Add(this.comboAl);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailsPatient";
            this.Text = "Détail patient - GSB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorNumSecu;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label NumSecuLabel;
        private System.Windows.Forms.TextBox numSecuTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addAnBtn;
        private System.Windows.Forms.Button addAlBtn;
        private System.Windows.Forms.DataGridView dataGridAn;
        private System.Windows.Forms.DataGridView dataGridAl;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.ComboBox comboAn;
        private System.Windows.Forms.Label labelAl;
        private System.Windows.Forms.ComboBox comboAl;
        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.Button confirmBtn;
    }
}