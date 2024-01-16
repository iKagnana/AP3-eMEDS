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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contreIndcTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.supprBtn = new System.Windows.Forms.Button();
            this.dataGridAl = new System.Windows.Forms.DataGridView();
            this.dataGridAn = new System.Windows.Forms.DataGridView();
            this.dataGridMed = new System.Windows.Forms.DataGridView();
            this.labelAl = new System.Windows.Forms.Label();
            this.labelAn = new System.Windows.Forms.Label();
            this.labelMed = new System.Windows.Forms.Label();
            this.addAlBtn = new System.Windows.Forms.Button();
            this.comboAl = new System.Windows.Forms.ComboBox();
            this.addAnBtn = new System.Windows.Forms.Button();
            this.comboAn = new System.Windows.Forms.ComboBox();
            this.addMedBtn = new System.Windows.Forms.Button();
            this.comboMed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détails du médicament :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contre-indications";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Libellé";
            // 
            // contreIndcTxt
            // 
            this.contreIndcTxt.BackColor = System.Drawing.SystemColors.Window;
            this.contreIndcTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contreIndcTxt.Location = new System.Drawing.Point(74, 206);
            this.contreIndcTxt.Multiline = true;
            this.contreIndcTxt.Name = "contreIndcTxt";
            this.contreIndcTxt.Size = new System.Drawing.Size(204, 65);
            this.contreIndcTxt.TabIndex = 16;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(74, 144);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(204, 26);
            this.nameTxt.TabIndex = 15;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmBtn.Location = new System.Drawing.Point(74, 296);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(204, 43);
            this.confirmBtn.TabIndex = 5;
            this.confirmBtn.Text = "Valider les modifications";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // supprBtn
            // 
            this.supprBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprBtn.ForeColor = System.Drawing.Color.Red;
            this.supprBtn.Location = new System.Drawing.Point(74, 354);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(204, 31);
            this.supprBtn.TabIndex = 6;
            this.supprBtn.Text = "Supprimer le médicament";
            this.supprBtn.UseVisualStyleBackColor = true;
            this.supprBtn.Click += new System.EventHandler(this.supprBtn_Click);
            // 
            // dataGridAl
            // 
            this.dataGridAl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAl.Location = new System.Drawing.Point(442, 107);
            this.dataGridAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridAl.Name = "dataGridAl";
            this.dataGridAl.RowHeadersWidth = 82;
            this.dataGridAl.RowTemplate.Height = 33;
            this.dataGridAl.Size = new System.Drawing.Size(391, 78);
            this.dataGridAl.TabIndex = 21;
            this.dataGridAl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAl_CellContentClick);
            // 
            // dataGridAn
            // 
            this.dataGridAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAn.Location = new System.Drawing.Point(442, 247);
            this.dataGridAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridAn.Name = "dataGridAn";
            this.dataGridAn.RowHeadersWidth = 82;
            this.dataGridAn.RowTemplate.Height = 33;
            this.dataGridAn.Size = new System.Drawing.Size(391, 78);
            this.dataGridAn.TabIndex = 22;
            this.dataGridAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAn_CellContentClick);
            // 
            // dataGridMed
            // 
            this.dataGridMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMed.Location = new System.Drawing.Point(442, 379);
            this.dataGridMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridMed.Name = "dataGridMed";
            this.dataGridMed.RowHeadersWidth = 82;
            this.dataGridMed.RowTemplate.Height = 33;
            this.dataGridMed.Size = new System.Drawing.Size(391, 78);
            this.dataGridMed.TabIndex = 23;
            this.dataGridMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMed_CellContentClick);
            // 
            // labelAl
            // 
            this.labelAl.AutoSize = true;
            this.labelAl.Location = new System.Drawing.Point(439, 66);
            this.labelAl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAl.Name = "labelAl";
            this.labelAl.Size = new System.Drawing.Size(113, 13);
            this.labelAl.TabIndex = 24;
            this.labelAl.Text = "Allergies incompatibles";
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Location = new System.Drawing.Point(439, 206);
            this.labelAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(134, 13);
            this.labelAn.TabIndex = 25;
            this.labelAn.Text = "Antécédents incompatibles";
            // 
            // labelMed
            // 
            this.labelMed.AutoSize = true;
            this.labelMed.Location = new System.Drawing.Point(439, 339);
            this.labelMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMed.Name = "labelMed";
            this.labelMed.Size = new System.Drawing.Size(137, 13);
            this.labelMed.TabIndex = 26;
            this.labelMed.Text = "Médicaments incompatibles";
            // 
            // addAlBtn
            // 
            this.addAlBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlBtn.Location = new System.Drawing.Point(694, 81);
            this.addAlBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAlBtn.Name = "addAlBtn";
            this.addAlBtn.Size = new System.Drawing.Size(33, 23);
            this.addAlBtn.TabIndex = 29;
            this.addAlBtn.Text = "+";
            this.addAlBtn.UseVisualStyleBackColor = false;
            this.addAlBtn.Click += new System.EventHandler(this.addAlBtn_Click);
            // 
            // comboAl
            // 
            this.comboAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAl.FormattingEnabled = true;
            this.comboAl.Location = new System.Drawing.Point(442, 80);
            this.comboAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAl.Name = "comboAl";
            this.comboAl.Size = new System.Drawing.Size(238, 28);
            this.comboAl.TabIndex = 27;
            this.comboAl.SelectedIndexChanged += new System.EventHandler(this.comboAl_SelectedIndexChanged);
            // 
            // addAnBtn
            // 
            this.addAnBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnBtn.Location = new System.Drawing.Point(694, 222);
            this.addAnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAnBtn.Name = "addAnBtn";
            this.addAnBtn.Size = new System.Drawing.Size(33, 23);
            this.addAnBtn.TabIndex = 31;
            this.addAnBtn.Text = "+";
            this.addAnBtn.UseVisualStyleBackColor = false;
            this.addAnBtn.Click += new System.EventHandler(this.addAnBtn_Click);
            // 
            // comboAn
            // 
            this.comboAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAn.FormattingEnabled = true;
            this.comboAn.Location = new System.Drawing.Point(442, 220);
            this.comboAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAn.Name = "comboAn";
            this.comboAn.Size = new System.Drawing.Size(238, 28);
            this.comboAn.TabIndex = 30;
            this.comboAn.SelectedIndexChanged += new System.EventHandler(this.comboAn_SelectedIndexChanged);
            // 
            // addMedBtn
            // 
            this.addMedBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addMedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMedBtn.Location = new System.Drawing.Point(694, 355);
            this.addMedBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMedBtn.Name = "addMedBtn";
            this.addMedBtn.Size = new System.Drawing.Size(33, 23);
            this.addMedBtn.TabIndex = 33;
            this.addMedBtn.Text = "+";
            this.addMedBtn.UseVisualStyleBackColor = false;
            this.addMedBtn.Click += new System.EventHandler(this.addMedBtn_Click);
            // 
            // comboMed
            // 
            this.comboMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboMed.FormattingEnabled = true;
            this.comboMed.Location = new System.Drawing.Point(442, 354);
            this.comboMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboMed.Name = "comboMed";
            this.comboMed.Size = new System.Drawing.Size(238, 28);
            this.comboMed.TabIndex = 32;
            this.comboMed.SelectedIndexChanged += new System.EventHandler(this.comboMed_SelectedIndexChanged);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 469);
            this.Controls.Add(this.addMedBtn);
            this.Controls.Add(this.comboMed);
            this.Controls.Add(this.addAnBtn);
            this.Controls.Add(this.comboAn);
            this.Controls.Add(this.addAlBtn);
            this.Controls.Add(this.comboAl);
            this.Controls.Add(this.labelMed);
            this.Controls.Add(this.labelAn);
            this.Controls.Add(this.labelAl);
            this.Controls.Add(this.dataGridMed);
            this.Controls.Add(this.dataGridAn);
            this.Controls.Add(this.dataGridAl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contreIndcTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.supprBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Details";
            this.Text = "Détails du médicament - GSB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contreIndcTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.DataGridView dataGridAl;
        private System.Windows.Forms.DataGridView dataGridAn;
        private System.Windows.Forms.DataGridView dataGridMed;
        private System.Windows.Forms.Label labelAl;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.Label labelMed;
        private System.Windows.Forms.Button addAlBtn;
        private System.Windows.Forms.ComboBox comboAl;
        private System.Windows.Forms.Button addAnBtn;
        private System.Windows.Forms.ComboBox comboAn;
        private System.Windows.Forms.Button addMedBtn;
        private System.Windows.Forms.ComboBox comboMed;
    }
}