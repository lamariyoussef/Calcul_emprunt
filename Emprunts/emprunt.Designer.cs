namespace Menu
{
    partial class calculemprunt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculemprunt));
            this.EtiNom = new System.Windows.Forms.Label();
            this.TextNom = new System.Windows.Forms.TextBox();
            this.EtiCapital = new System.Windows.Forms.Label();
            this.TextCapital = new System.Windows.Forms.TextBox();
            this.EtiDuree = new System.Windows.Forms.Label();
            this.Scrollduree = new System.Windows.Forms.HScrollBar();
            this.EtiDur = new System.Windows.Forms.Label();
            this.Etiperiode = new System.Windows.Forms.Label();
            this.listeperiodicite = new System.Windows.Forms.ListBox();
            this.Taux = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.EtiNbRemb = new System.Windows.Forms.Label();
            this.EtiRembour = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.Label();
            this.Valide = new System.Windows.Forms.Button();
            this.Annule = new System.Windows.Forms.Button();
            this.Taux.SuspendLayout();
            this.SuspendLayout();
            // 
            // EtiNom
            // 
            this.EtiNom.AutoSize = true;
            this.EtiNom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtiNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiNom.Location = new System.Drawing.Point(12, 32);
            this.EtiNom.Name = "EtiNom";
            this.EtiNom.Size = new System.Drawing.Size(37, 16);
            this.EtiNom.TabIndex = 0;
            this.EtiNom.Text = "Nom";
            // 
            // TextNom
            // 
            this.TextNom.Location = new System.Drawing.Point(134, 32);
            this.TextNom.Name = "TextNom";
            this.TextNom.Size = new System.Drawing.Size(122, 20);
            this.TextNom.TabIndex = 1;
            // 
            // EtiCapital
            // 
            this.EtiCapital.AutoSize = true;
            this.EtiCapital.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtiCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiCapital.Location = new System.Drawing.Point(12, 74);
            this.EtiCapital.Name = "EtiCapital";
            this.EtiCapital.Size = new System.Drawing.Size(110, 16);
            this.EtiCapital.TabIndex = 2;
            this.EtiCapital.Text = "Capital Emprunté";
            // 
            // TextCapital
            // 
            this.TextCapital.Location = new System.Drawing.Point(134, 70);
            this.TextCapital.Name = "TextCapital";
            this.TextCapital.Size = new System.Drawing.Size(122, 20);
            this.TextCapital.TabIndex = 3;
            this.TextCapital.TextChanged += new System.EventHandler(this.TextCapital_TextChanged);
            this.TextCapital.Leave += new System.EventHandler(this.TextCapital_Leave);
            // 
            // EtiDuree
            // 
            this.EtiDuree.AutoSize = true;
            this.EtiDuree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtiDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiDuree.Location = new System.Drawing.Point(12, 124);
            this.EtiDuree.Name = "EtiDuree";
            this.EtiDuree.Size = new System.Drawing.Size(210, 16);
            this.EtiDuree.TabIndex = 4;
            this.EtiDuree.Text = "Durée en mois du remboursement";
            // 
            // Scrollduree
            // 
            this.Scrollduree.Location = new System.Drawing.Point(134, 152);
            this.Scrollduree.Name = "Scrollduree";
            this.Scrollduree.Size = new System.Drawing.Size(262, 24);
            this.Scrollduree.TabIndex = 5;
            this.Scrollduree.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scrollduree_Scroll);
            // 
            // EtiDur
            // 
            this.EtiDur.BackColor = System.Drawing.Color.White;
            this.EtiDur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EtiDur.Location = new System.Drawing.Point(72, 152);
            this.EtiDur.Name = "EtiDur";
            this.EtiDur.Size = new System.Drawing.Size(50, 22);
            this.EtiDur.TabIndex = 6;
            this.EtiDur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Etiperiode
            // 
            this.Etiperiode.AutoSize = true;
            this.Etiperiode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Etiperiode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Etiperiode.Location = new System.Drawing.Point(12, 213);
            this.Etiperiode.Name = "Etiperiode";
            this.Etiperiode.Size = new System.Drawing.Size(188, 16);
            this.Etiperiode.TabIndex = 7;
            this.Etiperiode.Text = "Périodicité de remboursement";
            // 
            // listeperiodicite
            // 
            this.listeperiodicite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeperiodicite.FormattingEnabled = true;
            this.listeperiodicite.ItemHeight = 16;
            this.listeperiodicite.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listeperiodicite.Location = new System.Drawing.Point(15, 242);
            this.listeperiodicite.Name = "listeperiodicite";
            this.listeperiodicite.Size = new System.Drawing.Size(222, 84);
            this.listeperiodicite.TabIndex = 8;
            this.listeperiodicite.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Taux
            // 
            this.Taux.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Taux.Controls.Add(this.radioButton9);
            this.Taux.Controls.Add(this.radioButton8);
            this.Taux.Controls.Add(this.radioButton7);
            this.Taux.Location = new System.Drawing.Point(433, 32);
            this.Taux.Name = "Taux";
            this.Taux.Size = new System.Drawing.Size(102, 158);
            this.Taux.TabIndex = 9;
            this.Taux.TabStop = false;
            this.Taux.Text = "Taux d\'intérêt";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(29, 102);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(39, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Tag = "0,09";
            this.radioButton9.Text = "9%";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(29, 69);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(39, 17);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.Tag = "0,08";
            this.radioButton8.Text = "8%";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(29, 35);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(39, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "0,07";
            this.radioButton7.Text = "7%";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // EtiNbRemb
            // 
            this.EtiNbRemb.BackColor = System.Drawing.Color.White;
            this.EtiNbRemb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EtiNbRemb.ForeColor = System.Drawing.Color.Red;
            this.EtiNbRemb.Location = new System.Drawing.Point(344, 223);
            this.EtiNbRemb.Name = "EtiNbRemb";
            this.EtiNbRemb.Size = new System.Drawing.Size(36, 26);
            this.EtiNbRemb.TabIndex = 10;
            this.EtiNbRemb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtiRembour
            // 
            this.EtiRembour.AutoSize = true;
            this.EtiRembour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtiRembour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiRembour.Location = new System.Drawing.Point(386, 233);
            this.EtiRembour.Name = "EtiRembour";
            this.EtiRembour.Size = new System.Drawing.Size(129, 16);
            this.EtiRembour.TabIndex = 11;
            this.EtiRembour.Text = "Remboursements";
            // 
            // Montant
            // 
            this.Montant.BackColor = System.Drawing.Color.White;
            this.Montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.ForeColor = System.Drawing.Color.Red;
            this.Montant.Location = new System.Drawing.Point(386, 265);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(139, 28);
            this.Montant.TabIndex = 12;
            this.Montant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Valide
            // 
            this.Valide.Enabled = false;
            this.Valide.Location = new System.Drawing.Point(626, 32);
            this.Valide.Name = "Valide";
            this.Valide.Size = new System.Drawing.Size(126, 31);
            this.Valide.TabIndex = 13;
            this.Valide.Text = "OK";
            this.Valide.UseVisualStyleBackColor = true;
            this.Valide.Click += new System.EventHandler(this.Valide_Click);
            // 
            // Annule
            // 
            this.Annule.Location = new System.Drawing.Point(626, 94);
            this.Annule.Name = "Annule";
            this.Annule.Size = new System.Drawing.Size(126, 31);
            this.Annule.TabIndex = 14;
            this.Annule.Text = "Annuler";
            this.Annule.UseVisualStyleBackColor = true;
            this.Annule.Click += new System.EventHandler(this.Annule_Click);
            // 
            // calculemprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 362);
            this.Controls.Add(this.Annule);
            this.Controls.Add(this.Valide);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.EtiRembour);
            this.Controls.Add(this.EtiNbRemb);
            this.Controls.Add(this.Taux);
            this.Controls.Add(this.listeperiodicite);
            this.Controls.Add(this.Etiperiode);
            this.Controls.Add(this.EtiDur);
            this.Controls.Add(this.Scrollduree);
            this.Controls.Add(this.EtiDuree);
            this.Controls.Add(this.TextCapital);
            this.Controls.Add(this.EtiCapital);
            this.Controls.Add(this.TextNom);
            this.Controls.Add(this.EtiNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calculemprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.calculemprunt_FormClosing);
            this.Load += new System.EventHandler(this.calculemprunt_Load);
            this.Taux.ResumeLayout(false);
            this.Taux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiNom;
        private System.Windows.Forms.TextBox TextNom;
        private System.Windows.Forms.Label EtiCapital;
        private System.Windows.Forms.TextBox TextCapital;
        private System.Windows.Forms.Label EtiDuree;
        private System.Windows.Forms.HScrollBar Scrollduree;
        private System.Windows.Forms.Label EtiDur;
        private System.Windows.Forms.Label Etiperiode;
        private System.Windows.Forms.ListBox listeperiodicite;
        private System.Windows.Forms.GroupBox Taux;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label EtiNbRemb;
        private System.Windows.Forms.Label EtiRembour;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Button Valide;
        private System.Windows.Forms.Button Annule;
    }
}

