namespace InterfataUtilizator_WindowsFormsApp
{
    partial class Form1
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
            this.gpbStari = new System.Windows.Forms.GroupBox();
            this.ckbNOU = new System.Windows.Forms.CheckBox();
            this.ckbSECOND_HAND = new System.Windows.Forms.CheckBox();
            this.lblStari = new System.Windows.Forms.Label();
            this.gpbAniSelectati = new System.Windows.Forms.GroupBox();
            this.rdbAnul2021 = new System.Windows.Forms.RadioButton();
            this.rdbAnul2022 = new System.Windows.Forms.RadioButton();
            this.rdbAnul2023 = new System.Windows.Forms.RadioButton();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCuloare = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.gpbStari.SuspendLayout();
            this.gpbAniSelectati.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbStari
            // 
            this.gpbStari.Controls.Add(this.ckbNOU);
            this.gpbStari.Controls.Add(this.ckbSECOND_HAND);
            this.gpbStari.Location = new System.Drawing.Point(147, 213);
            this.gpbStari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbStari.Name = "gpbStari";
            this.gpbStari.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbStari.Size = new System.Drawing.Size(187, 33);
            this.gpbStari.TabIndex = 41;
            this.gpbStari.TabStop = false;
            // 
            // ckbNOU
            // 
            this.ckbNOU.AutoSize = true;
            this.ckbNOU.Location = new System.Drawing.Point(7, 10);
            this.ckbNOU.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNOU.Name = "ckbNOU";
            this.ckbNOU.Size = new System.Drawing.Size(53, 17);
            this.ckbNOU.TabIndex = 20;
            this.ckbNOU.Text = "NOU";
            this.ckbNOU.UseVisualStyleBackColor = true;
            this.ckbNOU.CheckedChanged += new System.EventHandler(this.CkbStari_CheckedChanged);
            // 
            // ckbSECOND_HAND
            // 
            this.ckbSECOND_HAND.AutoSize = true;
            this.ckbSECOND_HAND.Location = new System.Drawing.Point(64, 10);
            this.ckbSECOND_HAND.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSECOND_HAND.Name = "ckbSECOND_HAND";
            this.ckbSECOND_HAND.Size = new System.Drawing.Size(116, 17);
            this.ckbSECOND_HAND.TabIndex = 21;
            this.ckbSECOND_HAND.Text = "SECOND-HAND";
            this.ckbSECOND_HAND.UseVisualStyleBackColor = true;
            this.ckbSECOND_HAND.CheckedChanged += new System.EventHandler(this.CkbStari_CheckedChanged);
            // 
            // lblStari
            // 
            this.lblStari.AutoSize = true;
            this.lblStari.Location = new System.Drawing.Point(34, 223);
            this.lblStari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStari.Name = "lblStari";
            this.lblStari.Size = new System.Drawing.Size(106, 13);
            this.lblStari.TabIndex = 40;
            this.lblStari.Text = "Starea produsului";
            // 
            // gpbAniSelectati
            // 
            this.gpbAniSelectati.Controls.Add(this.rdbAnul2021);
            this.gpbAniSelectati.Controls.Add(this.rdbAnul2022);
            this.gpbAniSelectati.Controls.Add(this.rdbAnul2023);
            this.gpbAniSelectati.Location = new System.Drawing.Point(147, 115);
            this.gpbAniSelectati.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAniSelectati.Name = "gpbAniSelectati";
            this.gpbAniSelectati.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAniSelectati.Size = new System.Drawing.Size(175, 92);
            this.gpbAniSelectati.TabIndex = 39;
            this.gpbAniSelectati.TabStop = false;
            // 
            // rdbAnul2021
            // 
            this.rdbAnul2021.AutoSize = true;
            this.rdbAnul2021.Location = new System.Drawing.Point(42, 12);
            this.rdbAnul2021.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAnul2021.Name = "rdbAnul2021";
            this.rdbAnul2021.Size = new System.Drawing.Size(82, 17);
            this.rdbAnul2021.TabIndex = 10;
            this.rdbAnul2021.TabStop = true;
            this.rdbAnul2021.Text = "Anul 2021";
            this.rdbAnul2021.UseVisualStyleBackColor = true;
            // 
            // rdbAnul2022
            // 
            this.rdbAnul2022.AutoSize = true;
            this.rdbAnul2022.Location = new System.Drawing.Point(42, 37);
            this.rdbAnul2022.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAnul2022.Name = "rdbAnul2022";
            this.rdbAnul2022.Size = new System.Drawing.Size(82, 17);
            this.rdbAnul2022.TabIndex = 8;
            this.rdbAnul2022.TabStop = true;
            this.rdbAnul2022.Text = "Anul 2022";
            this.rdbAnul2022.UseVisualStyleBackColor = true;
            // 
            // rdbAnul2023
            // 
            this.rdbAnul2023.AutoSize = true;
            this.rdbAnul2023.Location = new System.Drawing.Point(42, 62);
            this.rdbAnul2023.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAnul2023.Name = "rdbAnul2023";
            this.rdbAnul2023.Size = new System.Drawing.Size(82, 17);
            this.rdbAnul2023.TabIndex = 9;
            this.rdbAnul2023.TabStop = true;
            this.rdbAnul2023.Text = "Anul 2023";
            this.rdbAnul2023.UseVisualStyleBackColor = true;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(34, 129);
            this.lblAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(22, 13);
            this.lblAn.TabIndex = 38;
            this.lblAn.Text = "An";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(135, 449);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 36;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(277, 300);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(139, 28);
            this.btnAfiseaza.TabIndex = 34;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.BtnAfiseaza_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(147, 36);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(175, 20);
            this.txtNume.TabIndex = 31;
            // 
            // txtCuloare
            // 
            this.txtCuloare.Location = new System.Drawing.Point(147, 71);
            this.txtCuloare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(175, 20);
            this.txtCuloare.TabIndex = 32;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(147, 266);
            this.txtPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(124, 20);
            this.txtPret.TabIndex = 33;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(147, 300);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 28);
            this.btnAdauga.TabIndex = 30;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(34, 43);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(39, 13);
            this.lblNume.TabIndex = 27;
            this.lblNume.Text = "Nume";
            // 
            // lblCuloare
            // 
            this.lblCuloare.AutoSize = true;
            this.lblCuloare.Location = new System.Drawing.Point(34, 71);
            this.lblCuloare.Name = "lblCuloare";
            this.lblCuloare.Size = new System.Drawing.Size(50, 13);
            this.lblCuloare.TabIndex = 28;
            this.lblCuloare.Text = "Culoare";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(34, 269);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(30, 13);
            this.lblPret.TabIndex = 29;
            this.lblPret.Text = "Pret";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.gpbAniSelectati);
            this.Controls.Add(this.lblStari);
            this.Controls.Add(this.gpbStari);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblCuloare);
            this.Controls.Add(this.lblPret);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbStari.ResumeLayout(false);
            this.gpbStari.PerformLayout();
            this.gpbAniSelectati.ResumeLayout(false);
            this.gpbAniSelectati.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbStari;
        private System.Windows.Forms.CheckBox ckbNOU;
        private System.Windows.Forms.CheckBox ckbSECOND_HAND;
        private System.Windows.Forms.Label lblStari;
        private System.Windows.Forms.GroupBox gpbAniSelectati;
        private System.Windows.Forms.RadioButton rdbAnul2021;
        private System.Windows.Forms.RadioButton rdbAnul2022;
        private System.Windows.Forms.RadioButton rdbAnul2023;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCuloare;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCuloare;
        private System.Windows.Forms.Label lblPret;






    }
}

