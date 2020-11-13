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
    public partial class FormCRUDReparation : Form
    {
        public FormCRUDReparation()
        {
            InitializeComponent();
        }

        private void FormCRUDReparation_Load(object sender, EventArgs e)
        {

        }

        private void cbNumeroVelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumeroVelo.SelectedItem.ToString() !="")
            {
                pbNonValideNV.Visible = false;
                pbValideNV.Visible = true;
            }
        }

        private void cbTypeTravaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeTravaux.SelectedItem.ToString() !="")
            {
                pbNonValideTT.Visible = false;
                pbValideTT.Visible = true;
            }
        }

        private void cbUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            TimePicker1.CustomFormat = "HH:mm:ss";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
