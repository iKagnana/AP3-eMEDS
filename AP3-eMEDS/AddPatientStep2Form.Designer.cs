﻿namespace AP3_eMEDS
{
    partial class AddPatientStep2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientStep2Form));
            this.comboAl = new System.Windows.Forms.ComboBox();
            this.labelAl = new System.Windows.Forms.Label();
            this.labelAn = new System.Windows.Forms.Label();
            this.comboAn = new System.Windows.Forms.ComboBox();
            this.dataGridAl = new System.Windows.Forms.DataGridView();
            this.dataGridAn = new System.Windows.Forms.DataGridView();
            this.addAlBtn = new System.Windows.Forms.Button();
            this.addAnBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAn)).BeginInit();
            this.SuspendLayout();
            // 
            // comboAl
            // 
            this.comboAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAl.FormattingEnabled = true;
            this.comboAl.Location = new System.Drawing.Point(66, 114);
            this.comboAl.Margin = new System.Windows.Forms.Padding(2);
            this.comboAl.Name = "comboAl";
            this.comboAl.Size = new System.Drawing.Size(238, 28);
            this.comboAl.TabIndex = 0;
            this.comboAl.SelectedIndexChanged += new System.EventHandler(this.comboAl_SelectedIndexChanged);
            // 
            // labelAl
            // 
            this.labelAl.AutoSize = true;
            this.labelAl.Location = new System.Drawing.Point(66, 98);
            this.labelAl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAl.Name = "labelAl";
            this.labelAl.Size = new System.Drawing.Size(52, 13);
            this.labelAl.TabIndex = 1;
            this.labelAl.Text = "Allergie(s)";
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Location = new System.Drawing.Point(429, 98);
            this.labelAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(73, 13);
            this.labelAn.TabIndex = 3;
            this.labelAn.Text = "Antécédent(s)";
            // 
            // comboAn
            // 
            this.comboAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboAn.FormattingEnabled = true;
            this.comboAn.Location = new System.Drawing.Point(429, 114);
            this.comboAn.Margin = new System.Windows.Forms.Padding(2);
            this.comboAn.Name = "comboAn";
            this.comboAn.Size = new System.Drawing.Size(238, 28);
            this.comboAn.TabIndex = 2;
            this.comboAn.SelectedIndexChanged += new System.EventHandler(this.comboAn_SelectedIndexChanged);
            // 
            // dataGridAl
            // 
            this.dataGridAl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAl.Location = new System.Drawing.Point(66, 159);
            this.dataGridAl.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAl.Name = "dataGridAl";
            this.dataGridAl.RowHeadersWidth = 82;
            this.dataGridAl.RowTemplate.Height = 33;
            this.dataGridAl.Size = new System.Drawing.Size(285, 207);
            this.dataGridAl.TabIndex = 4;
            this.dataGridAl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAl_CellContentClick);
            // 
            // dataGridAn
            // 
            this.dataGridAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAn.Location = new System.Drawing.Point(429, 159);
            this.dataGridAn.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAn.Name = "dataGridAn";
            this.dataGridAn.RowHeadersWidth = 82;
            this.dataGridAn.RowTemplate.Height = 33;
            this.dataGridAn.Size = new System.Drawing.Size(285, 207);
            this.dataGridAn.TabIndex = 5;
            this.dataGridAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAn_CellContentClick);
            // 
            // addAlBtn
            // 
            this.addAlBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlBtn.Location = new System.Drawing.Point(318, 115);
            this.addAlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addAlBtn.Name = "addAlBtn";
            this.addAlBtn.Size = new System.Drawing.Size(33, 23);
            this.addAlBtn.TabIndex = 6;
            this.addAlBtn.Text = "+";
            this.addAlBtn.UseVisualStyleBackColor = false;
            this.addAlBtn.Click += new System.EventHandler(this.addAlBtn_Click);
            // 
            // addAnBtn
            // 
            this.addAnBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnBtn.Location = new System.Drawing.Point(681, 115);
            this.addAnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addAnBtn.Name = "addAnBtn";
            this.addAnBtn.Size = new System.Drawing.Size(33, 23);
            this.addAnBtn.TabIndex = 9;
            this.addAnBtn.Text = "+";
            this.addAnBtn.UseVisualStyleBackColor = false;
            this.addAnBtn.Click += new System.EventHandler(this.addAnBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(522, 425);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(204, 43);
            this.addBtn.TabIndex = 29;
            this.addBtn.Text = "Passer";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddPatientStep2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 469);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addAnBtn);
            this.Controls.Add(this.addAlBtn);
            this.Controls.Add(this.dataGridAn);
            this.Controls.Add(this.dataGridAl);
            this.Controls.Add(this.labelAn);
            this.Controls.Add(this.comboAn);
            this.Controls.Add(this.labelAl);
            this.Controls.Add(this.comboAl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPatientStep2Form";
            this.Text = "Ajout d\'un patient étape 2 - GSB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAl;
        private System.Windows.Forms.Label labelAl;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.ComboBox comboAn;
        private System.Windows.Forms.DataGridView dataGridAl;
        private System.Windows.Forms.DataGridView dataGridAn;
        private System.Windows.Forms.Button addAlBtn;
        private System.Windows.Forms.Button addAnBtn;
        private System.Windows.Forms.Button addBtn;
    }
}