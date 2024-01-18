namespace AP3_eMEDS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.title = new System.Windows.Forms.Label();
            this.groupMedecin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.medBtn = new System.Windows.Forms.Button();
            this.groupPatientObject = new System.Windows.Forms.GroupBox();
            this.anBtn = new System.Windows.Forms.Button();
            this.alBtn = new System.Windows.Forms.Button();
            this.groupMedecin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupPatientObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.title.Location = new System.Drawing.Point(514, 76);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(160, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Bienvenu(e)";
            // 
            // groupMedecin
            // 
            this.groupMedecin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupMedecin.Controls.Add(this.button1);
            this.groupMedecin.Location = new System.Drawing.Point(52, 227);
            this.groupMedecin.Name = "groupMedecin";
            this.groupMedecin.Size = new System.Drawing.Size(206, 228);
            this.groupMedecin.TabIndex = 1;
            this.groupMedecin.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(38, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Médecins";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(344, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(38, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Patients";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.medBtn);
            this.groupBox3.Location = new System.Drawing.Point(644, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // medBtn
            // 
            this.medBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.medBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.medBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.medBtn.Location = new System.Drawing.Point(36, 173);
            this.medBtn.Name = "medBtn";
            this.medBtn.Size = new System.Drawing.Size(133, 34);
            this.medBtn.TabIndex = 0;
            this.medBtn.Text = "Médicaments";
            this.medBtn.UseVisualStyleBackColor = false;
            this.medBtn.Click += new System.EventHandler(this.medBtn_Click);
            // 
            // groupPatientObject
            // 
            this.groupPatientObject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupPatientObject.Controls.Add(this.anBtn);
            this.groupPatientObject.Controls.Add(this.alBtn);
            this.groupPatientObject.Location = new System.Drawing.Point(938, 227);
            this.groupPatientObject.Name = "groupPatientObject";
            this.groupPatientObject.Size = new System.Drawing.Size(206, 228);
            this.groupPatientObject.TabIndex = 3;
            this.groupPatientObject.TabStop = false;
            // 
            // anBtn
            // 
            this.anBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.anBtn.Location = new System.Drawing.Point(36, 173);
            this.anBtn.Name = "anBtn";
            this.anBtn.Size = new System.Drawing.Size(133, 34);
            this.anBtn.TabIndex = 1;
            this.anBtn.Text = "Antécédents";
            this.anBtn.UseVisualStyleBackColor = false;
            this.anBtn.Click += new System.EventHandler(this.anBtn_Click);
            // 
            // alBtn
            // 
            this.alBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.alBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.alBtn.Location = new System.Drawing.Point(36, 123);
            this.alBtn.Name = "alBtn";
            this.alBtn.Size = new System.Drawing.Size(133, 34);
            this.alBtn.TabIndex = 0;
            this.alBtn.Text = "Allergies";
            this.alBtn.UseVisualStyleBackColor = false;
            this.alBtn.Click += new System.EventHandler(this.alBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 552);
            this.Controls.Add(this.groupPatientObject);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupMedecin);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu - GSB";
            this.groupMedecin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupPatientObject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupMedecin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupPatientObject;
        private System.Windows.Forms.Button medBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button anBtn;
        private System.Windows.Forms.Button alBtn;
    }
}