using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    public partial class FormGestion : Form
    {
        private BindingSource bindingSource1;
        public FormGestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement de la feuille de gestion des données avec toutes les tables disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestion_Load(object sender, EventArgs e)
        {
            dgvDonnees.Visible = false; 
            Controleur.Vmodele.charger_donnees("toutes");

            if (Controleur.Vmodele.Chargement)
            {
                //   MessageBox.Show("BD chargée dans DataTable  : " + Controleur.Vmodele.DT1.Rows.Count.ToString());
                for (int i = 0; i < Controleur.Vmodele.DT[0].Rows.Count; i++)
                {
                    cbTables.Items.Add(Controleur.Vmodele.DT[0].Rows[i][0].ToString());
                }
            }
        }

        /// <summary>
        /// Fermeture de la feuille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Chargement des données dans le dataGrifView selon la table sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTables.SelectedIndex != -1)
            {
                string table = cbTables.SelectedItem.ToString(); // récupération de la table sélectionnée
                Controleur.Vmodele.charger_donnees(table);      // chargement des données de la table sélectionné dans le DT correspondant
                if (Controleur.Vmodele.Chargement)
                {
                    // un DT par table
                    bindingSource1 = new BindingSource();
                    if (table == "PPE_borne")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["codeB"].HeaderText = "Code";
                        dgvDonnees.Columns["nomB"].HeaderText = "Nom Borne";
                        dgvDonnees.Columns["numRueB"].HeaderText = "Numéro Rue";
                        dgvDonnees.Columns["nomRueB"].HeaderText = "Rue";
                        dgvDonnees.Columns["latitudeV"].HeaderText = "latitude";
                        dgvDonnees.Columns["longitudeV"].HeaderText = "longitude";

                    }
                    else if (table == "PPE_adherent")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[2];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numA"].HeaderText = "Numéro";
                        dgvDonnees.Columns["nomA"].HeaderText = "Nom";
                        dgvDonnees.Columns["prenomA"].HeaderText = "Préom";
                        dgvDonnees.Columns["adresseRueA"].HeaderText = "Adresse";
                        dgvDonnees.Columns["cpA"].HeaderText = "Code Postal";
                        dgvDonnees.Columns["villeA"].HeaderText = "Ville";
                        dgvDonnees.Columns["telA"].HeaderText = "Téléphone";
                        dgvDonnees.Columns["login"].HeaderText = "Login Utilisateur";
                        dgvDonnees.Columns["password"].HeaderText = "mot de passe Utilisateur";
                        dgvDonnees.Columns["Pidentite"].HeaderText = "Pièce d'identité";
                    }
                    else if (table == "PPE_vehicule")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[3];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro Vélo";
                        dgvDonnees.Columns["etatV"].HeaderText = "état Vélo";


                    }
                    else if (table == "PPE_veloelectrique")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[4];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro Vélo";
                        dgvDonnees.Columns["numB"].HeaderText = "Numéro";

                    }
                    else if (table == "PPE_velo")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[5];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["numV"].HeaderText = "Numéro Vélo";
                        dgvDonnees.Columns["latitudeV"].HeaderText = "Latitude Vélo";
                        dgvDonnees.Columns["longitudeV"].HeaderText = "Longitude vélo";
                    }
                    else if (table == "PPE_utilisateur")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[6];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["idU"].HeaderText = "Numéro Utilisateur";
                        dgvDonnees.Columns["loginU"].HeaderText = "Identifiant Utilisteur";
                        dgvDonnees.Columns["mdpU"].HeaderText = "Mot de passee Utilisateur";
                    }
                    else if (table == "PPE_travaux")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[7];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["idT"].HeaderText = "Numéro Travaux";
                        dgvDonnees.Columns["libelleT"].HeaderText = "Libellé Travaux";
                    }
                    else if (table =="PPE_reparer")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[8];
                        dgvDonnees.DataSource = bindingSource1;
                        dgvDonnees.Columns["NumV"].HeaderText = "Numéro Vélo";
                        dgvDonnees.Columns["idT"].HeaderText = "Numéro Travaux";
                        dgvDonnees.Columns["dateR"].HeaderText = "Date Réparation";
                        dgvDonnees.Columns["tempsR"].HeaderText = "Temps Réparation";
                        dgvDonnees.Columns["idU"].HeaderText = "Identifiant Utilisateur";
                    }

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dgvDonnees.Refresh();
                    dgvDonnees.Visible = true;
                }
                else
                {
                    MessageBox.Show("Table non gérée encore", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvDonnees.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Selectionner une table dans la liste déroulante", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestion du menu contextuel pour AJOUTER/SUPPRIMER/MODIFIER des données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            string table = cbTables.SelectedItem.ToString();
            if (sender == ajouterToolStripMenuItem)
            {
                // appel de la méthode du controleur en mode create

                if (table == "PPE_borne") Controleur.crud_borne('c', -1);
                if (table == "PPE_adherent") Controleur.crud_adherent('c', -1);
                if (table == "PPE_velo") Controleur.crud_velo('c', -1);
                if (table == "PPE_veloelectrique") Controleur.crud_veloelectrique('c', -1);
                if (table == "PPE_vehicule") Controleur.crud_vehicule('c', -1);
            }
            else
            {
                // vérifier qu’une ligne est bien sélectionnée dans le dataGridView
                if (dgvDonnees.SelectedRows.Count == 1)
                {
                    if (sender == modifierToolStripMenuItem)
                    {
                        if (table == "PPE_borne") Controleur.crud_borne('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_adherent") Controleur.crud_adherent('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_velo") Controleur.crud_velo('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_veloelectrique") Controleur.crud_veloelectrique('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_vehicule") Controleur.crud_vehicule('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        if (table == "PPE_borne") Controleur.crud_borne('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_adherent") Controleur.crud_adherent('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_velo") Controleur.crud_velo('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_veloelectrique") Controleur.crud_veloelectrique('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (table == "PPE_vehicule") Controleur.crud_vehicule('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));

                    }

                }
                else
                {
                    MessageBox.Show("Sélectionner une ligne à modifier/supprimer");
                }
            }

            // mise à jour du dataGridView en affichage     
            // appel de la méthode pour recharger toutes les données dans le DataGridView en cas d'ajout
            cbTables_SelectedIndexChanged(sender, e);
            bindingSource1.MoveLast();
            bindingSource1.MoveFirst();
            dgvDonnees.Refresh();

        }

        private void DgvDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
