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
    public partial class FormCRUDBorne : Form
    {
        public FormCRUDBorne()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gestion des caractères autorisés pour le numéro de la rue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbnumAdresseRue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des chiffres", "Erreur", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }

        }

        /// <summary>
        /// Interface de gestion des Bornes pour Ajouter/Modifier
        /// Feuille appelée via la formGestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCRUDBorne_Load(object sender, EventArgs e)
        {
            //affichage des image valide ou non valide
            if (pbValideR.Visible != true && pbValideLat.Visible != true && pbValid1.Visible != true && pbValideL.Visible != true)
            {
                pbNonValideR.Visible = true;
                pbNonValideLat.Visible = true;
                pbNonValideL.Visible = true;
                pbNonValid2.Visible = true;
            }

        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
   
        }

        private void TbNomAdresseRue_TextChanged(object sender, EventArgs e)
        {
            //affichage des image valide ou non valide
            if (TbNomAdresseRue.Text != "")
            {
                pbValideR.Visible = true;
                pbNonValideR.Visible = false;
            }
            else
            {
                pbValideR.Visible = false;
                pbNonValideR.Visible = true;
            }
        }

        public void Latitude_TextChanged(object sender, EventArgs e)
        {
            //affichage des image valide ou non valide
            if (latitudeText.Text != "")
            {
                pbValideLat.Visible = true;
                pbNonValideLat.Visible = false;
            }
            else
            {
                pbValideLat.Visible = false;
                pbNonValideLat.Visible = true;
            }
        }

        private void TbNomBorne_TextChanged(object sender, EventArgs e)
        {
            if (tbNomBorne.Text != "")
            {
                pbValid1.Visible = true;
                pbNonValid2.Visible = false;
            }
            else
            {
                pbValid1.Visible = false;
                pbNonValid2.Visible = true;
            }
        }

        private void PbNonValid2_Click(object sender, EventArgs e)
        {

        }

        private void PbNonValid2_Click_1(object sender, EventArgs e)
        {

        }

        private void PbValid1_Click(object sender, EventArgs e)
        {

        }

        private void PbValideR_Click(object sender, EventArgs e)
        {

        }

        private void PbNonValideR_Click(object sender, EventArgs e)
        {

        }

        private void LongitudeText_TextChanged(object sender, EventArgs e)
        {
            //affichage des image valide ou non valide
            if (longitudeText.Text != "")
            {
                pbValideL.Visible = true;
                pbNonValideL.Visible = false;
            }
            else
            {
                pbValideL.Visible = false;
                pbNonValideL.Visible = true;
            }
        }

        private void PbValideL_Click(object sender, EventArgs e)
        {

        }

        private void PbNonValideL_Click(object sender, EventArgs e)
        {

        }
    }
}
