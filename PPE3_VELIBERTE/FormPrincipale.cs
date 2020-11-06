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
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement de la feuille principale avec le menu et la connexion à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                //MessageBox.Show("BD connectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Fermeture de l'application avec déconnexion à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controleur.Vmodele.Connopen)    // si connexion ouverte
            {
                Controleur.Vmodele.sedeconnecter();
                if (!Controleur.Vmodele.Connopen)  // si connexion bien fermée
                {
                    MessageBox.Show("BD déconnectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Appel au menu Gestion des données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestionDesDonneesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veuillez vous connecter au service technique", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
        }

        private void BoutonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxIdentifiant.Clear();
            textBoxMDP.Clear();           
        }

        private void BoutonValider_Click(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees("PPE_utilisateur");
            bool trouve = false;
            for (int i = 0; i < Controleur.Vmodele.DT[6].Rows.Count; i++)
            {
                if (textBoxIdentifiant.Text == Controleur.Vmodele.DT[6].Rows[i]["loginU"].ToString() && textBoxMDP.Text == Controleur.Vmodele.DT[6].Rows[i]["mdpU"].ToString())
                {
                    MessageBox.Show("Bienvenue" + " ", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    trouve = true;
                    this.Visible = false;
                    FormGestion F = new FormGestion();
                    F.Show();
                }

            }
            if (trouve == false)
            {
                MessageBox.Show("Erreur dans les identifiants de connexion" + "", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
