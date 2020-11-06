namespace PPE3_VELIBERTE
{
    partial class FormPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GestionDesDonneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boutonSeConnecter = new System.Windows.Forms.Button();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMDP = new System.Windows.Forms.Label();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.boutonValider = new System.Windows.Forms.Button();
            this.boutonAnnuler = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionDesDonneesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GestionDesDonneesToolStripMenuItem
            // 
            this.GestionDesDonneesToolStripMenuItem.Name = "GestionDesDonneesToolStripMenuItem";
            this.GestionDesDonneesToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.GestionDesDonneesToolStripMenuItem.Text = "Gestion des données";
            this.GestionDesDonneesToolStripMenuItem.Click += new System.EventHandler(this.GestionDesDonneesToolStripMenuItem_Click);
            // 
            // boutonSeConnecter
            // 
            this.boutonSeConnecter.Location = new System.Drawing.Point(175, 55);
            this.boutonSeConnecter.Name = "boutonSeConnecter";
            this.boutonSeConnecter.Size = new System.Drawing.Size(175, 61);
            this.boutonSeConnecter.TabIndex = 1;
            this.boutonSeConnecter.Text = "Se connecter au service technique";
            this.boutonSeConnecter.UseVisualStyleBackColor = true;
            this.boutonSeConnecter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(43, 20);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(99, 20);
            this.labelIdentifiant.TabIndex = 2;
            this.labelIdentifiant.Text = "identifiant :";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Location = new System.Drawing.Point(15, 55);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(127, 20);
            this.labelMDP.TabIndex = 3;
            this.labelMDP.Text = "mot de passe :";
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(161, 17);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(160, 26);
            this.textBoxIdentifiant.TabIndex = 4;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(161, 52);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(160, 26);
            this.textBoxMDP.TabIndex = 5;
            
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Controls.Add(this.boutonAnnuler);
            this.panel.Controls.Add(this.boutonValider);
            this.panel.Controls.Add(this.textBoxIdentifiant);
            this.panel.Controls.Add(this.textBoxMDP);
            this.panel.Controls.Add(this.labelIdentifiant);
            this.panel.Controls.Add(this.labelMDP);
            this.panel.Location = new System.Drawing.Point(381, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(361, 168);
            this.panel.TabIndex = 6;
            this.panel.Visible = false;
            // 
            // boutonValider
            // 
            this.boutonValider.Location = new System.Drawing.Point(233, 121);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(108, 34);
            this.boutonValider.TabIndex = 7;
            this.boutonValider.Text = "VALIDER";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.BoutonValider_Click);
            // 
            // boutonAnnuler
            // 
            this.boutonAnnuler.Location = new System.Drawing.Point(108, 121);
            this.boutonAnnuler.Name = "boutonAnnuler";
            this.boutonAnnuler.Size = new System.Drawing.Size(108, 34);
            this.boutonAnnuler.TabIndex = 8;
            this.boutonAnnuler.Text = "ANNULER";
            this.boutonAnnuler.UseVisualStyleBackColor = true;
            this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnuler_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 469);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.boutonSeConnecter);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Application VELIBERTE : gestion des données et Réparations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GestionDesDonneesToolStripMenuItem;
        private System.Windows.Forms.Button boutonSeConnecter;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button boutonAnnuler;
        private System.Windows.Forms.Button boutonValider;
    }
}

