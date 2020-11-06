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
    public partial class FormCRUDTravaux : Form
    {
        public FormCRUDTravaux()
        {
            InitializeComponent();
        }

        private void TbNomBorne_TextChanged(object sender, EventArgs e)
        {
            if (typeTravaux.Text != "")
            {
                pbValide.Visible = true;
                pbNonValide.Visible = false;
            }
            else
            {
                pbValide.Visible = false;
                pbNonValide.Visible = true;
            }
        }

        private void FormCRUDTravaux_Load(object sender, EventArgs e)
        {
            if (pbValide.Visible != true)
            {
                pbNonValide.Visible = true;
            }
        }
    }
}
