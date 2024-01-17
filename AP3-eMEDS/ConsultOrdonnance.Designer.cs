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
            this.labelInfos.Location = new System.Drawing.Point(71, 70);
            this.labelInfos.Name = "labelInfos";
            this.labelInfos.Size = new System.Drawing.Size(344, 37);
            this.labelInfos.TabIndex = 0;
            this.labelInfos.Text = "Informations du patient";
            // 
            // dataGridMeds
            // 
            this.dataGridMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMeds.Location = new System.Drawing.Point(939, 94);
            this.dataGridMeds.Name = "dataGridMeds";
            this.dataGridMeds.RowHeadersWidth = 82;
            this.dataGridMeds.RowTemplate.Height = 33;
            this.dataGridMeds.Size = new System.Drawing.Size(758, 818);
            this.dataGridMeds.TabIndex = 1;
            // 
            // labelListMeds
            // 
            this.labelListMeds.AutoSize = true;
            this.labelListMeds.Location = new System.Drawing.Point(939, 46);
            this.labelListMeds.Name = "labelListMeds";
            this.labelListMeds.Size = new System.Drawing.Size(221, 25);
            this.labelListMeds.TabIndex = 2;
            this.labelListMeds.Text = "Liste de médicaments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Instructions spécifiques";
            // 
            // InstruSpeTxt
            // 
            this.InstruSpeTxt.BackColor = System.Drawing.SystemColors.Window;
            this.InstruSpeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruSpeTxt.Location = new System.Drawing.Point(78, 488);
            this.InstruSpeTxt.Margin = new System.Windows.Forms.Padding(6);
            this.InstruSpeTxt.Multiline = true;
            this.InstruSpeTxt.Name = "InstruSpeTxt";
            this.InstruSpeTxt.Size = new System.Drawing.Size(566, 121);
            this.InstruSpeTxt.TabIndex = 35;
            // 
            // dureeTxt
            // 
            this.dureeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dureeTxt.Location = new System.Drawing.Point(78, 367);
            this.dureeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.dureeTxt.Name = "dureeTxt";
            this.dureeTxt.Size = new System.Drawing.Size(262, 44);
            this.dureeTxt.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Durée du traitement";
            // 
            // posologieTxt
            // 
            this.posologieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.posologieTxt.Location = new System.Drawing.Point(78, 243);
            this.posologieTxt.Margin = new System.Windows.Forms.Padding(4);
            this.posologieTxt.Name = "posologieTxt";
            this.posologieTxt.Size = new System.Drawing.Size(262, 44);
            this.posologieTxt.TabIndex = 32;
            // 
            // posologieLabel
            // 
            this.posologieLabel.AutoSize = true;
            this.posologieLabel.Location = new System.Drawing.Point(78, 214);
            this.posologieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.posologieLabel.Name = "posologieLabel";
            this.posologieLabel.Size = new System.Drawing.Size(107, 25);
            this.posologieLabel.TabIndex = 31;
            this.posologieLabel.Text = "Posologie";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateBtn.Location = new System.Drawing.Point(78, 733);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(6);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(408, 83);
            this.generateBtn.TabIndex = 37;
            this.generateBtn.Text = "Générer le pdf";
            this.generateBtn.UseVisualStyleBackColor = false;
            // 
            // ConsultOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 952);
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