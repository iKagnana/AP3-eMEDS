namespace AP3_eMEDS
{
    partial class AddOrdonnanceForm
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
            this.patientInfos = new System.Windows.Forms.Label();
            this.comboMeds = new System.Windows.Forms.ComboBox();
            this.medLabel = new System.Windows.Forms.Label();
            this.dataGridListO = new System.Windows.Forms.DataGridView();
            this.ordonnanceListLabel = new System.Windows.Forms.Label();
            this.dataGridMeds = new System.Windows.Forms.DataGridView();
            this.addMedBtn = new System.Windows.Forms.Button();
            this.posologieLabel = new System.Windows.Forms.Label();
            this.posologieTxt = new System.Windows.Forms.TextBox();
            this.dureeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InstruSpeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.nbDate = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.warningText = new System.Windows.Forms.Label();
            this.warningMedsTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDate)).BeginInit();
            this.SuspendLayout();
            // 
            // patientInfos
            // 
            this.patientInfos.AutoSize = true;
            this.patientInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInfos.Location = new System.Drawing.Point(36, 35);
            this.patientInfos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientInfos.Name = "patientInfos";
            this.patientInfos.Size = new System.Drawing.Size(173, 20);
            this.patientInfos.TabIndex = 0;
            this.patientInfos.Text = "Informations du patient";
            // 
            // comboMeds
            // 
            this.comboMeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboMeds.FormattingEnabled = true;
            this.comboMeds.Location = new System.Drawing.Point(39, 103);
            this.comboMeds.Margin = new System.Windows.Forms.Padding(2);
            this.comboMeds.Name = "comboMeds";
            this.comboMeds.Size = new System.Drawing.Size(342, 28);
            this.comboMeds.TabIndex = 1;
            this.comboMeds.SelectedIndexChanged += new System.EventHandler(this.comboMeds_SelectedIndexChanged);
            // 
            // medLabel
            // 
            this.medLabel.AutoSize = true;
            this.medLabel.Location = new System.Drawing.Point(39, 87);
            this.medLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medLabel.Name = "medLabel";
            this.medLabel.Size = new System.Drawing.Size(76, 13);
            this.medLabel.TabIndex = 2;
            this.medLabel.Text = "Médicament(s)";
            // 
            // dataGridListO
            // 
            this.dataGridListO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListO.Location = new System.Drawing.Point(541, 65);
            this.dataGridListO.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridListO.Name = "dataGridListO";
            this.dataGridListO.RowHeadersWidth = 82;
            this.dataGridListO.RowTemplate.Height = 33;
            this.dataGridListO.Size = new System.Drawing.Size(535, 493);
            this.dataGridListO.TabIndex = 3;
            // 
            // ordonnanceListLabel
            // 
            this.ordonnanceListLabel.AutoSize = true;
            this.ordonnanceListLabel.Location = new System.Drawing.Point(538, 50);
            this.ordonnanceListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordonnanceListLabel.Name = "ordonnanceListLabel";
            this.ordonnanceListLabel.Size = new System.Drawing.Size(114, 13);
            this.ordonnanceListLabel.TabIndex = 4;
            this.ordonnanceListLabel.Text = "Liste des ordonnances";
            // 
            // dataGridMeds
            // 
            this.dataGridMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeds.Location = new System.Drawing.Point(39, 134);
            this.dataGridMeds.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMeds.Name = "dataGridMeds";
            this.dataGridMeds.RowHeadersWidth = 82;
            this.dataGridMeds.RowTemplate.Height = 33;
            this.dataGridMeds.Size = new System.Drawing.Size(379, 96);
            this.dataGridMeds.TabIndex = 5;
            this.dataGridMeds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMeds_CellContentClick);
            // 
            // addMedBtn
            // 
            this.addMedBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addMedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMedBtn.Location = new System.Drawing.Point(385, 102);
            this.addMedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addMedBtn.Name = "addMedBtn";
            this.addMedBtn.Size = new System.Drawing.Size(33, 28);
            this.addMedBtn.TabIndex = 7;
            this.addMedBtn.Text = "+";
            this.addMedBtn.UseVisualStyleBackColor = false;
            this.addMedBtn.Click += new System.EventHandler(this.addMedBtn_Click);
            // 
            // posologieLabel
            // 
            this.posologieLabel.AutoSize = true;
            this.posologieLabel.Location = new System.Drawing.Point(42, 296);
            this.posologieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.posologieLabel.Name = "posologieLabel";
            this.posologieLabel.Size = new System.Drawing.Size(53, 13);
            this.posologieLabel.TabIndex = 8;
            this.posologieLabel.Text = "Posologie";
            // 
            // posologieTxt
            // 
            this.posologieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.posologieTxt.Location = new System.Drawing.Point(42, 311);
            this.posologieTxt.Margin = new System.Windows.Forms.Padding(2);
            this.posologieTxt.Name = "posologieTxt";
            this.posologieTxt.Size = new System.Drawing.Size(133, 26);
            this.posologieTxt.TabIndex = 9;
            // 
            // dureeTxt
            // 
            this.dureeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dureeTxt.Location = new System.Drawing.Point(194, 311);
            this.dureeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.dureeTxt.Name = "dureeTxt";
            this.dureeTxt.Size = new System.Drawing.Size(133, 26);
            this.dureeTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Durée du traitement";
            // 
            // InstruSpeTxt
            // 
            this.InstruSpeTxt.BackColor = System.Drawing.SystemColors.Window;
            this.InstruSpeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruSpeTxt.Location = new System.Drawing.Point(42, 371);
            this.InstruSpeTxt.Multiline = true;
            this.InstruSpeTxt.Name = "InstruSpeTxt";
            this.InstruSpeTxt.Size = new System.Drawing.Size(285, 65);
            this.InstruSpeTxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Instructions spécifiques";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(85, 465);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(204, 43);
            this.addBtn.TabIndex = 27;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nbDate
            // 
            this.nbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nbDate.Location = new System.Drawing.Point(194, 311);
            this.nbDate.Margin = new System.Windows.Forms.Padding(2);
            this.nbDate.Name = "nbDate";
            this.nbDate.Size = new System.Drawing.Size(41, 26);
            this.nbDate.TabIndex = 28;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(238, 311);
            this.comboBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(89, 28);
            this.comboBoxDate.TabIndex = 29;
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(246, 341);
            this.checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(81, 17);
            this.checkBox.TabIndex = 30;
            this.checkBox.Text = "Champ libre";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.BackColor = System.Drawing.SystemColors.Control;
            this.warningText.ForeColor = System.Drawing.Color.Red;
            this.warningText.Location = new System.Drawing.Point(27, 439);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(312, 13);
            this.warningText.TabIndex = 31;
            this.warningText.Text = "Attention certains médicaments sont incompatible avec le patient";
            // 
            // warningMedsTxt
            // 
            this.warningMedsTxt.AutoSize = true;
            this.warningMedsTxt.ForeColor = System.Drawing.Color.Red;
            this.warningMedsTxt.Location = new System.Drawing.Point(36, 232);
            this.warningMedsTxt.Name = "warningMedsTxt";
            this.warningMedsTxt.Size = new System.Drawing.Size(291, 13);
            this.warningMedsTxt.TabIndex = 32;
            this.warningMedsTxt.Text = "Attention certains médicaments sont incompatibles entre eux";
            // 
            // AddOrdonnanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 618);
            this.Controls.Add(this.warningMedsTxt);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.nbDate);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstruSpeTxt);
            this.Controls.Add(this.dureeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posologieTxt);
            this.Controls.Add(this.posologieLabel);
            this.Controls.Add(this.addMedBtn);
            this.Controls.Add(this.dataGridMeds);
            this.Controls.Add(this.ordonnanceListLabel);
            this.Controls.Add(this.dataGridListO);
            this.Controls.Add(this.medLabel);
            this.Controls.Add(this.comboMeds);
            this.Controls.Add(this.patientInfos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddOrdonnanceForm";
            this.Text = "AddOrdonnanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientInfos;
        private System.Windows.Forms.ComboBox comboMeds;
        private System.Windows.Forms.Label medLabel;
        private System.Windows.Forms.DataGridView dataGridListO;
        private System.Windows.Forms.Label ordonnanceListLabel;
        private System.Windows.Forms.DataGridView dataGridMeds;
        private System.Windows.Forms.Button addMedBtn;
        private System.Windows.Forms.Label posologieLabel;
        private System.Windows.Forms.TextBox posologieTxt;
        private System.Windows.Forms.TextBox dureeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InstruSpeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown nbDate;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label warningText;
        private System.Windows.Forms.Label warningMedsTxt;
    }
}