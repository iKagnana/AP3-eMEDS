﻿namespace AP3_eMEDS
{
    partial class DeleteItemPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItemPatient));
            this.titleLabel = new System.Windows.Forms.Label();
            this.supprBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.subtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(91, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(182, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Voulez vous supprimer ?";
            // 
            // supprBtn
            // 
            this.supprBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprBtn.ForeColor = System.Drawing.Color.Red;
            this.supprBtn.Location = new System.Drawing.Point(86, 215);
            this.supprBtn.Name = "supprBtn";
            this.supprBtn.Size = new System.Drawing.Size(204, 31);
            this.supprBtn.TabIndex = 8;
            this.supprBtn.Text = "Supprimer";
            this.supprBtn.UseVisualStyleBackColor = true;
            this.supprBtn.Click += new System.EventHandler(this.supprBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmBtn.Location = new System.Drawing.Point(86, 157);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(204, 43);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Annuler";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(55, 74);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(143, 20);
            this.subtitle.TabIndex = 9;
            this.subtitle.Text = "Exemple texte long";
            // 
            // DeleteItemPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 279);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.supprBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteItemPatient";
            this.Text = "Confirmation de suppression - GSB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button supprBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label subtitle;
    }
}