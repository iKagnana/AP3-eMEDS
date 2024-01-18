namespace AP3_eMEDS
{
    partial class ConsultOrdonnance
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
            this.labelInfos = new System.Windows.Forms.Label();
            this.dataGridMeds = new System.Windows.Forms.DataGridView();
            this.labelListMeds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InstruSpeTxt = new System.Windows.Forms.TextBox();
            this.dureeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posologieTxt = new System.Windows.Forms.TextBox();
            this.posologieLabel = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeds)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfos
            // 
            this.labelInfos.AutoSize = true;
            this.labelInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfos.Location = new System.Drawing.Point(36, 36);
            this.labelInfos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfos.Name = "labelInfos";
            this.labelInfos.Size = new System.Drawing.Size(173, 20);
            this.labelInfos.TabIndex = 0;
            this.labelInfos.Text = "Informations du patient";
            // 
            // dataGridMeds
            // 
            this.dataGridMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeds.Location = new System.Drawing.Point(413, 49);
            this.dataGridMeds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridMeds.Name = "dataGridMeds";
            this.dataGridMeds.RowHeadersWidth = 82;
            this.dataGridMeds.RowTemplate.Height = 33;
            this.dataGridMeds.Size = new System.Drawing.Size(436, 425);
            this.dataGridMeds.TabIndex = 1;
            // 
            // labelListMeds
            // 
            this.labelListMeds.AutoSize = true;
            this.labelListMeds.Location = new System.Drawing.Point(410, 23);
            this.labelListMeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListMeds.Name = "labelListMeds";
            this.labelListMeds.Size = new System.Drawing.Size(109, 13);
            this.labelListMeds.TabIndex = 2;
            this.labelListMeds.Text = "Liste de médicaments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Instructions spécifiques";
            // 
            // InstruSpeTxt
            // 
            this.InstruSpeTxt.BackColor = System.Drawing.SystemColors.Window;
            this.InstruSpeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruSpeTxt.Location = new System.Drawing.Point(39, 254);
            this.InstruSpeTxt.Multiline = true;
            this.InstruSpeTxt.Name = "InstruSpeTxt";
            this.InstruSpeTxt.Size = new System.Drawing.Size(285, 65);
            this.InstruSpeTxt.TabIndex = 35;
            // 
            // dureeTxt
            // 
            this.dureeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dureeTxt.Location = new System.Drawing.Point(39, 191);
            this.dureeTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dureeTxt.Name = "dureeTxt";
            this.dureeTxt.Size = new System.Drawing.Size(133, 26);
            this.dureeTxt.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Durée du traitement";
            // 
            // posologieTxt
            // 
            this.posologieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.posologieTxt.Location = new System.Drawing.Point(39, 126);
            this.posologieTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posologieTxt.Name = "posologieTxt";
            this.posologieTxt.Size = new System.Drawing.Size(133, 26);
            this.posologieTxt.TabIndex = 32;
            // 
            // posologieLabel
            // 
            this.posologieLabel.AutoSize = true;
            this.posologieLabel.Location = new System.Drawing.Point(39, 111);
            this.posologieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.posologieLabel.Name = "posologieLabel";
            this.posologieLabel.Size = new System.Drawing.Size(53, 13);
            this.posologieLabel.TabIndex = 31;
            this.posologieLabel.Text = "Posologie";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateBtn.Location = new System.Drawing.Point(39, 381);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(204, 43);
            this.generateBtn.TabIndex = 37;
            this.generateBtn.Text = "Générer le pdf";
            this.generateBtn.UseVisualStyleBackColor = false;
            // 
            // ConsultOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 495);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstruSpeTxt);
            this.Controls.Add(this.dureeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posologieTxt);
            this.Controls.Add(this.posologieLabel);
            this.Controls.Add(this.labelListMeds);
            this.Controls.Add(this.dataGridMeds);
            this.Controls.Add(this.labelInfos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultOrdonnance";
            this.Text = "Consultation de l\'ordonnance - GSB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfos;
        private System.Windows.Forms.DataGridView dataGridMeds;
        private System.Windows.Forms.Label labelListMeds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InstruSpeTxt;
        private System.Windows.Forms.TextBox dureeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox posologieTxt;
        private System.Windows.Forms.Label posologieLabel;
        private System.Windows.Forms.Button generateBtn;
    }
}