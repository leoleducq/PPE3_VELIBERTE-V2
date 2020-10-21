using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPE3_VELIBERTE
{
    /// <summary>
    /// Controleur du projet VELIIBERTE
    /// </summary>
    public static class Controleur
    {
        #region propriétés
        private static Modele vmodele;
        #endregion

        #region accesseurs
        /// <summary>
        /// propriété Vmodele
        /// </summary>
        public static Modele Vmodele
        {
            get { return vmodele; }
            set { vmodele = value; }
        }
        #endregion

        #region methodes
        /// <summary>
        /// instanciation du modele
        /// </summary>
        public static void init()
        {
            Vmodele = new Modele();
        }

        /// <summary>
        /// permet le crud sur la table borne
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_borne(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette borne " + vmodele.DT[1].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[1].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[1].Update(vmodele.DT[1]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDBorne formCRUD = new FormCRUDBorne();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNomBorne.Clear();
                    formCRUD.TbNomAdresseRue.Clear();
                    formCRUD.TbnumAdresseRue.Clear();
                    formCRUD.LatitudeText.Clear();
                    formCRUD.LongitudeText.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNomBorne.Text = vmodele.DT[1].Rows[indice][1].ToString();
                    formCRUD.TbnumAdresseRue.Text = vmodele.DT[1].Rows[indice][2].ToString();
                    formCRUD.TbNomAdresseRue.Text = vmodele.DT[1].Rows[indice][3].ToString();
                    formCRUD.LatitudeText.Text = vmodele.DT[1].Rows[indice][4].ToString();
                    formCRUD.LongitudeText.Text = vmodele.DT[1].Rows[indice][5].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNomBorne.Text != "" && formCRUD.TbNomAdresseRue.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            NouvLigne["nomB"] = formCRUD.TbNomBorne.Text;
                            NouvLigne["latitudeV"] = formCRUD.LatitudeText.Text;
                            NouvLigne["longitudeV"] = formCRUD.LongitudeText.Text;
                            if (formCRUD.TbnumAdresseRue.Text != "") NouvLigne["numRueB"] = formCRUD.TbnumAdresseRue.Text;
                            NouvLigne["nomRueB"] = formCRUD.TbNomAdresseRue.Text;
                            vmodele.DT[1].Rows.Add(NouvLigne);
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins le nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (c == 'u')  // modif
                    {
                        if (formCRUD.TbNomBorne.Text != "" && formCRUD.TbNomAdresseRue.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[1].Rows[indice]["nomB"] = formCRUD.TbNomBorne.Text;
                            vmodele.DT[1].Rows[indice]["latitudeV"] = formCRUD.LatitudeText.Text;
                            vmodele.DT[1].Rows[indice]["longitudeV"] = formCRUD.LongitudeText.Text;
                            if (formCRUD.TbnumAdresseRue.Text != "") vmodele.DT[1].Rows[indice]["numRueB"] = formCRUD.TbnumAdresseRue.Text;
                            vmodele.DT[1].Rows[indice]["nomRueB"] = formCRUD.TbNomAdresseRue.Text;
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins le nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("OK : données enregistrées Borne");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Borne");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table adherent
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_adherent(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                //DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette adherent " + vmodele.DT[2].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[2].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[2].Update(vmodele.DT[2]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDAdherent formCRUD = new FormCRUDAdherent();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.TbNom.Clear();
                    formCRUD.TbPrenom.Clear();
                    formCRUD.TbAdresse.Clear();
                    formCRUD.MtbCP.Clear();
                    formCRUD.TbVille.Clear();
                    formCRUD.MtbTel.Clear();
                    formCRUD.MtbTel.Text = "0";
                    formCRUD.Logintext.Clear();
                    formCRUD.passwordText.Clear();


                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[2].Rows[indice][1].ToString();
                    formCRUD.TbPrenom.Text = vmodele.DT[2].Rows[indice][2].ToString();
                    formCRUD.TbAdresse.Text = vmodele.DT[2].Rows[indice][3].ToString();
                    formCRUD.MtbCP.Text = vmodele.DT[2].Rows[indice][4].ToString();
                    formCRUD.TbVille.Text = vmodele.DT[2].Rows[indice][5].ToString();
                    formCRUD.MtbTel.Text = vmodele.DT[2].Rows[indice][6].ToString();
                    formCRUD.Logintext.Text = vmodele.DT[2].Rows[indice][7].ToString();
                    formCRUD.passwordText.Text = vmodele.DT[2].Rows[indice][8].ToString();
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        bool valid = true;
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "" && formCRUD.MtbCP.Text != "" && formCRUD.TbAdresse.Text != "" && formCRUD.TbVille.Text != "" && formCRUD.MtbTel.Text != "0 /  /  /  /" && formCRUD.Logintext.Text != "" && formCRUD.passwordText.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[2].NewRow();
                            NouvLigne["nomA"] = formCRUD.TbNom.Text;
                            NouvLigne["prenomA"] = formCRUD.TbPrenom.Text;
                            NouvLigne["login"] = formCRUD.Logintext.Text;
                            NouvLigne["password"] = formCRUD.passwordText.Text;
                            NouvLigne["Pidentite"] = formCRUD.OuiIdentité1.Checked;
                            NouvLigne["caution"] = formCRUD.CautionCheck.Checked;

                            if (formCRUD.MtbCP.Text != "")
                            {
                                if (Convert.ToInt32(formCRUD.MtbCP.Text) >= 1000 && Convert.ToInt32(formCRUD.MtbCP.Text) <= 99999)
                                {
                                    NouvLigne["cpA"] = formCRUD.MtbCP.Text;
                                }
                                else valid = false;

                            }

                            NouvLigne["adresseRueA"] = formCRUD.TbAdresse.Text;


                            NouvLigne["villeA"] = formCRUD.TbVille.Text;


                            if (formCRUD.MtbTel.Text != "0 /  /  /  /")
                            {
                                if (formCRUD.MtbTel.Text.Length == 14) NouvLigne["telA"] = formCRUD.MtbTel.Text;
                                else valid = false;
                            }

                            if (valid)
                            {
                                vmodele.DT[2].Rows.Add(NouvLigne);
                                vmodele.DA[2].Update(vmodele.DT[2]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur dans la saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // ne pas fermer la form : revenir avant le bouton OK
                                goto eti;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut tout saisir", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[2].Rows[indice]["nomA"] = formCRUD.TbNom.Text;
                            vmodele.DT[2].Rows[indice]["prenomA"] = formCRUD.TbPrenom.Text;
                            vmodele.DT[2].Rows[indice]["adresseRueA"] = formCRUD.TbAdresse.Text;
                            vmodele.DT[2].Rows[indice]["cpA"] = formCRUD.MtbCP.Text;
                            vmodele.DT[2].Rows[indice]["villeA"] = formCRUD.TbVille.Text;
                            vmodele.DT[2].Rows[indice]["telA"] = formCRUD.MtbTel.Text;
                            vmodele.DT[2].Rows[indice]["login"] = formCRUD.Logintext.Text;
                            vmodele.DT[2].Rows[indice]["password"] = formCRUD.passwordText.Text;
                            if (formCRUD.OuiIdentité1.Checked == true) vmodele.DT[2].Rows[indice]["Pidentite"] = 1;
                            else vmodele.DT[2].Rows[indice]["Pidentite"] = 0;
                            if (formCRUD.CautionCheck.Checked == true) vmodele.DT[2].Rows[indice]["caution"] = 1;
                            else vmodele.DT[2].Rows[indice]["caution"] = 0;
                            vmodele.DA[2].Update(vmodele.DT[2]);
                        }
                        else
                            MessageBox.Show("Erreur : il faut saisir au moins le nom et le prénom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); // à compléter
                    }


                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        #endregion

        ///<summary>
        /// permet le crud sur la table velo
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>

        public static void crud_velo(Char c, int indice)
        {

            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce velo " + vmodele.DT[5].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                    {
                        if (vmodele.DT[5].Rows[indice][0].ToString() == vmodele.DT[3].Rows[i][0].ToString())
                        {
                            vmodele.DT[3].Rows[i].Delete();

                        }
                    }
                    vmodele.DA[5].Update(vmodele.DT[5]);			// mise à jour du DataAdapter
                    vmodele.DA[3].Update(vmodele.DT[3]);
                }
            }

            else
            {
                // cas de l'ajout et modification
                FormCRUDVehicule formCRUD = new FormCRUDVehicule();
                FormCRUDVELO formCRUD2 = new FormCRUDVELO();

                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbLatC.Clear();
                    formCRUD.TbLongC.Clear();
                    formCRUD.CbNumBorne.SelectedIndex = -1;
                    formCRUD.RbElec.Checked = false;
                    formCRUD.RbClassique.Checked = false;
                    formCRUD.CbEtatVehicule.SelectedIndex = -1;

                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    formCRUD2.TbLat.Text = vmodele.DT[5].Rows[indice][1].ToString();
                    formCRUD2.TbLong.Text = vmodele.DT[5].Rows[indice][2].ToString();


                }
                // on affiche la nouvelle form

                if (c == 'u')
                {
                    formCRUD2.ShowDialog();

                }
                else
                {
                    formCRUD.ShowDialog();
                }



                // si l’utilisateur clique sur OK
                if (formCRUD2.DialogResult == DialogResult.OK || formCRUD.DialogResult == DialogResult.OK)
                {

                    if (c == 'c') // ajout
                    {

                        if (formCRUD.RbClassique.Checked == true)
                        {
                            if (formCRUD.CbEtatVehicule.SelectedIndex != -1 && formCRUD.TbLatC.Text != "" && formCRUD.TbLongC.Text != "")
                            {
                                DataRow NouvLigne = vmodele.DT[5].NewRow();
                                NouvLigne["latitudeV"] = formCRUD.TbLatC.Text;
                                NouvLigne["longitudeV"] = formCRUD.TbLongC.Text;

                                vmodele.DT[5].Rows.Add(NouvLigne);
                                vmodele.DA[5].Update(vmodele.DT[5]);

                            }
                            else
                                MessageBox.Show("Erreur : veuillez saisir  latitude et la longitude + etat du véhicule pour ajouter un velo classique", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }


                    if (c == 'u')  // modif
                    {
                        if (formCRUD2.TbLat.Text != "" && formCRUD2.TbLong.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[5].Rows[indice]["latitudeV"] = formCRUD2.TbLat.Text.ToString(); 
                            vmodele.DT[5].Rows[indice]["longitudeV"] = formCRUD2.TbLong.Text.ToString();
                            vmodele.DA[5].Update(vmodele.DT[5]);
                        }
                        else
                            MessageBox.Show("Erreur : veuillez saisir la latitude et la longitude.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("OK : données enregistrées dans Velo");
                    formCRUD2.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Velo");
                    formCRUD2.Dispose();
                }
            }
        }
        ///<summary>
        ///crud sur vehicule
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_vehicule(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ceci  " + vmodele.DT[3].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[3].Rows[indice].Delete();        // suppression dans le DataTable
                    vmodele.DA[3].Update(vmodele.DT[3]);            // mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDVehicule formCRUD = new FormCRUDVehicule();

                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // a remplir 
                    formCRUD.TbLatC.Clear();
                    formCRUD.TbLongC.Clear();
                    formCRUD.CbNumBorne.SelectedIndex = -1;
                    formCRUD.RbElec.Checked = false;
                    formCRUD.RbClassique.Checked = false;
                    formCRUD.CbEtatVehicule.SelectedIndex = -1;

                    for (int i = 0; i < Vmodele.DT[1].Rows.Count; i++)
                    {
                        formCRUD.CbNumBorne.Items.Add(Vmodele.DT[1].Rows[i]["nomB"].ToString());
                    }

                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    for (int i = 0; i < Vmodele.DT[1].Rows.Count; i++)
                    {
                        formCRUD.CbNumBorne.Items.Add(Vmodele.DT[1].Rows[i]["nomB"].ToString());
                    }

                    formCRUD.CbEtatVehicule.Text = vmodele.DT[3].Rows[indice][1].ToString();
                    formCRUD.RbClassique.Visible = false;
                    formCRUD.RbElec.Visible = false;


                    // on remplit les zones par les valeurs du dataGridView correspondantes

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        for (int i = 0; i < Vmodele.DT[1].Rows.Count; i++)
                        {
                            formCRUD.CbNumBorne.Items.Add(Vmodele.DT[1].Rows[i]["nomB"].ToString()); // boucle pour charger le num des bornes via leur nom 
                        }

                        DataRow NouvLigne = vmodele.DT[3].NewRow(); // table vehicule
                        DataRow NouvLigne1 = vmodele.DT[5].NewRow(); //table velo
                        DataRow NouvLigne2 = vmodele.DT[4].NewRow(); // table veloelec


                        NouvLigne["etatV"] = formCRUD.CbEtatVehicule.Text;
                        vmodele.DT[3].Rows.Add(NouvLigne);
                        vmodele.DA[3].Update(vmodele.DT[3]);
                        MessageBox.Show("Vehicule ajouté");


                        if (formCRUD.RbClassique.Checked == true && formCRUD.RbElec.Checked == false) // si je veux ajouter velo classique
                        {
                            vmodele.charger_donnees("vehicule");
                            int numV = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1]["numV"].ToString());
                            NouvLigne1["numV"] = numV;
                            NouvLigne1["latitudeV"] = formCRUD.TbLatC.Text;
                            NouvLigne1["longitudeV"] = formCRUD.TbLongC.Text;
                            vmodele.DT[5].Rows.Add(NouvLigne1);
                            vmodele.DA[5].Update(vmodele.DT[5]);
                        }
                        else if (formCRUD.RbElec.Checked == true && formCRUD.RbClassique.Checked == false) // si je veux ajouter velo elec
                        {
                            vmodele.charger_donnees("vehicule");
                            int numV = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1]["numV"].ToString());
                            NouvLigne2["numV"] = numV;
                            NouvLigne2["numB"] = Convert.ToInt32(formCRUD.CbNumBorne.SelectedIndex + 1);
                            vmodele.DT[4].Rows.Add(NouvLigne2);
                            vmodele.DA[4].Update(vmodele.DT[4]);
                        }

                    }


                    if (c == 'u')  // modif
                    {

                        if (formCRUD.CbEtatVehicule.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs

                            vmodele.DT[3].Rows[indice]["etatV"] = formCRUD.CbEtatVehicule.Text;
                            vmodele.DA[3].Update(vmodele.DT[3]);
                        }
                        else
                            MessageBox.Show("Erreur : Etat non saisis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("OK : données enregistrées Vehicule");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Vehicule");
                    formCRUD.Dispose();
                }
            }
        }
        ///<summary>
        ///crud sur veloelec
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_veloelectrique(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ceci  " + vmodele.DT[4].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                    {
                        if (vmodele.DT[4].Rows[indice][0].ToString() == vmodele.DT[3].Rows[i][0].ToString())
                        {
                            vmodele.DT[3].Rows[i].Delete();

                        }
                    }
                    vmodele.DA[4].Update(vmodele.DT[4]);			// mise à jour du DataAdapter
                    vmodele.DA[5].Update(vmodele.DT[3]);
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDVehicule formCRUD = new FormCRUDVehicule();  // création de la nouvelle forme
                FormCRUDVELOELEC formCRUD2 = new FormCRUDVELOELEC();

                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbLatC.Clear();
                    formCRUD.TbLongC.Clear();
                    formCRUD.CbNumBorne.SelectedIndex = -1;
                    formCRUD.RbElec.Checked = false;
                    formCRUD.RbClassique.Checked = false;
                    formCRUD.CbEtatVehicule.SelectedIndex = -1;

                    for (int i = 0; i < Vmodele.DT[1].Rows.Count; i++)
                    {
                        formCRUD.CbNumBorne.Items.Add(Vmodele.DT[1].Rows[i]["nomB"].ToString());
                    }


                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    for (int i = 0; i < Vmodele.DT[1].Rows.Count; i++)
                    {
                        formCRUD2.CbNumB.Items.Add(Vmodele.DT[1].Rows[i]["nomB"].ToString());
                    }

                    for (int i = 0; i < Vmodele.DT[3].Rows.Count; i++)
                    {
                        formCRUD2.CbNumVeh.Items.Add(Vmodele.DT[3].Rows[i]["numV"].ToString());
                    }

                    formCRUD2.CbNumB.SelectedIndex = Convert.ToInt32(vmodele.DT[4].Rows[indice][1].ToString()) - 1;
                    formCRUD2.CbNumVeh.Text = vmodele.DT[4].Rows[indice][0].ToString();

                }

                if (c == 'u')
                {
                    formCRUD2.ShowDialog();

                }
                else
                {
                    formCRUD.ShowDialog();
                }

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK || formCRUD2.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        for (int i = 0; i < Vmodele.DT[1].Rows.Count; i++)
                        {
                            formCRUD.CbNumBorne.Items.Add(Vmodele.DT[1].Rows[i]["nomB"].ToString()); // boucle pour charger le num des bornes via leur nom 
                        }
                        
                        DataRow NouvLigne = vmodele.DT[3].NewRow(); // table vehicule
                        DataRow NouvLigne1 = vmodele.DT[5].NewRow(); //table velo
                        DataRow NouvLigne2 = vmodele.DT[4].NewRow(); // table veloelec


                        NouvLigne["etatV"] = formCRUD.CbEtatVehicule.Text;
                        vmodele.DT[3].Rows.Add(NouvLigne);
                        vmodele.DA[3].Update(vmodele.DT[3]);
                        MessageBox.Show("Vehicule ajouté");


                        if (formCRUD.RbClassique.Checked == true && formCRUD.RbElec.Checked == false) // ajout velo classique
                        {
                            vmodele.charger_donnees("vehicule");
                            int numV = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1]["numV"].ToString());
                            NouvLigne1["numV"] = numV;
                            NouvLigne1["latitudeV"] = formCRUD.TbLatC.Text;
                            NouvLigne1["longitudeV"] = formCRUD.TbLongC.Text;
                            vmodele.DT[5].Rows.Add(NouvLigne1);
                            vmodele.DA[5].Update(vmodele.DT[5]);
                        }
                        else if (formCRUD.RbElec.Checked == true && formCRUD.RbClassique.Checked == false) // ajout velo elec
                        {
                            vmodele.charger_donnees("vehicule");
                            int numV = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1]["numV"].ToString());
                            NouvLigne2["numV"] = numV;
                            NouvLigne2["numB"] = Convert.ToInt32(formCRUD.CbNumBorne.SelectedIndex + 1);
                            vmodele.DT[4].Rows.Add(NouvLigne2);
                            vmodele.DA[4].Update(vmodele.DT[4]);
                        }

                    }

                    if (c == 'u')  // modif
                    {

                        if (formCRUD2.CbNumB.Text != "" && formCRUD2.CbNumVeh.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs

                            vmodele.DT[4].Rows[indice]["numV"] = Convert.ToInt32(formCRUD2.CbNumVeh.Text.ToString());
                            vmodele.DT[4].Rows[indice]["numB"] = Convert.ToInt32(formCRUD2.CbNumB.SelectedIndex + 1);
                            vmodele.DA[4].Update(vmodele.DT[4]);
                        }
                        else
                            MessageBox.Show("Erreur : Numero du véhicule et nom de la borne non saisis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("OK : données enregistrées Vehicule electrique");
                    formCRUD2.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Vehicule electrique");
                    formCRUD.Dispose();
                }
            }
        }

    }
}
//faire la methode crud velo
// faire la methode crud velo electrique
       


 