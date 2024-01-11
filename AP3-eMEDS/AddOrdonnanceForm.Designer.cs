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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeds)).BeginInit();
            this.SuspendLayout();
            // 
            // patientInfos
            // 
            this.patientInfos.AutoSize = true;
            this.patientInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInfos.Location = new System.Drawing.Point(71, 68);
            this.patientInfos.Name = "patientInfos";
            this.patientInfos.Size = new System.Drawing.Size(344, 37);
            this.patientInfos.TabIndex = 0;
            this.patientInfos.Text = "Informations du patient";
            // 
            // comboMeds
            // 
            this.comboMeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboMeds.FormattingEnabled = true;
            this.comboMeds.Location = new System.Drawing.Point(78, 204);
            this.comboMeds.Name = "comboMeds";
            this.comboMeds.Size = new System.Drawing.Size(473, 45);
            this.comboMeds.TabIndex = 1;
            // 
            // medLabel
            // 
            this.medLabel.AutoSize = true;
            this.medLabel.Location = new System.Drawing.Point(78, 173);
            this.medLabel.Name = "medLabel";
            this.medLabel.Size = new System.Drawing.Size(154, 25);
            this.medLabel.TabIndex = 2;
            this.medLabel.Text = "Médicament(s)";
            // 
            // dataGridListO
            // 
            this.dataGridListO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListO.Location = new System.Drawing.Point(1027, 68);
            this.dataGridListO.Name = "dataGridListO";
            this.dataGridListO.RowHeadersWidth = 82;
            this.dataGridListO.RowTemplate.Height = 33;
            this.dataGridListO.Size = new System.Drawing.Size(618, 800);
            this.dataGridListO.TabIndex = 3;
            // 
            // ordonnanceListLabel
            // 
            this.ordonnanceListLabel.AutoSize = true;
            this.ordonnanceListLabel.Location = new System.Drawing.Point(1022, 40);
            this.ordonnanceListLabel.Name = "ordonnanceListLabel";
            this.ordonnanceListLabel.Size = new System.Drawing.Size(230, 25);
            this.ordonnanceListLabel.TabIndex = 4;
            this.ordonnanceListLabel.Text = "Liste des ordonnances";
            // 
            // dataGridMeds
            // 
            this.dataGridMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeds.Location = new System.Drawing.Point(78, 264);
            this.dataGridMeds.Name = "dataGridMeds";
            this.dataGridMeds.RowHeadersWidth = 82;
            this.dataGridMeds.RowTemplate.Height = 33;
            this.dataGridMeds.Size = new System.Drawing.Size(566, 184);
            this.dataGridMeds.TabIndex = 5;
            // 
            // addMedBtn
            // 
            this.addMedBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addMedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMedBtn.Location = new System.Drawing.Point(578, 206);
            this.addMedBtn.Name = "addMedBtn";
            this.addMedBtn.Size = new System.Drawing.Size(66, 45);
            this.addMedBtn.TabIndex = 7;
            this.addMedBtn.Text = "+";
            this.addMedBtn.UseVisualStyleBackColor = false;
            // 
            // posologieLabel
            // 
            this.posologieLabel.AutoSize = true;
            this.posologieLabel.Location = new System.Drawing.Point(78, 504);
            this.posologieLabel.Name = "posologieLabel";
            this.posologieLabel.Size = new System.Drawing.Size(107, 25);
            this.posologieLabel.TabIndex = 8;
            this.posologieLabel.Text = "Posologie";
            // 
            // posologieTxt
            // 
            this.posologieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.posologieTxt.Location = new System.Drawing.Point(78, 532);
            this.posologieTxt.Name = "posologieTxt";
            this.posologieTxt.Size = new System.Drawing.Size(262, 44);
            this.posologieTxt.TabIndex = 9;
            // 
            // dureeTxt
            // 
            this.dureeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dureeTxt.Location = new System.Drawing.Point(382, 532);
            this.dureeTxt.Name = "dureeTxt";
            this.dureeTxt.Size = new System.Drawing.Size(262, 44);
            this.dureeTxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Durée du traitement";
            // 
            // InstruSpeTxt
            // 
            this.InstruSpeTxt.BackColor = System.Drawing.SystemColors.Window;
            this.InstruSpeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruSpeTxt.Location = new System.Drawing.Point(78, 648);
            this.InstruSpeTxt.Margin = new System.Windows.Forms.Padding(6);
            this.InstruSpeTxt.Multiline = true;
            this.InstruSpeTxt.Name = "InstruSpeTxt";
            this.InstruSpeTxt.Size = new System.Drawing.Size(566, 121);
            this.InstruSpeTxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Instructions spécifiques";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(163, 809);
            this.addBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(408, 83);
            this.addBtn.TabIndex = 27;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // AddOrdonnanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 936);
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
            this.Name = "AddOrdonnanceForm";
            this.Text = "AddOrdonnanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeds)).EndInit();
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
    }
}