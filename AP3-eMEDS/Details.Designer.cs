namespace AP3_eMEDS
{
    partial class Details
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.supprBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.targetTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.stocksField = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stocksField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(154, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détails du médicament :";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.Control;
            this.confirmBtn.Location = new System.Drawing.Point(193, 370);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(168, 23);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Valider les modifications";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // supprBtn
            // 
            this.supprBtn.ForeColor = System.Drawing.Color.Red;
            this.supprBtn.Location = new System.Drawing.Point(193, 412);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(168, 23);
            this.supprBtn.TabIndex = 6;
            this.supprBtn.Text = "Supprimer le médicament";
            this.supprBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cible";
            // 
            // targetTxt
            // 
            this.targetTxt.Location = new System.Drawing.Point(174, 179);
            this.targetTxt.Name = "targetTxt";
            this.targetTxt.Size = new System.Drawing.Size(204, 20);
            this.targetTxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 221);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nom";
            // 
            // descTxt
            // 
            this.descTxt.BackColor = System.Drawing.SystemColors.Window;
            this.descTxt.Location = new System.Drawing.Point(174, 237);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(204, 40);
            this.descTxt.TabIndex = 15;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(174, 124);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(204, 20);
            this.nameTxt.TabIndex = 14;
            // 
            // stocksField
            // 
            this.stocksField.Location = new System.Drawing.Point(285, 312);
            this.stocksField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stocksField.Name = "stocksField";
            this.stocksField.Size = new System.Drawing.Size(93, 20);
            this.stocksField.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Prix (à l\'unité)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stocks";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(174, 312);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(93, 20);
            this.priceTxt.TabIndex = 20;
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 527);
            this.Controls.Add(this.stocksField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.supprBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label1);
            this.Name = "Details";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.stocksField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.NumericUpDown stocksField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTxt;
    }
}