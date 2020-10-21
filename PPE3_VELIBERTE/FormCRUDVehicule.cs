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
    public partial class FormCRUDVehicule : Form
    {
        public FormCRUDVehicule()
        {
            InitializeComponent();
        }

        private void FormCRUDVehicule_Load(object sender, EventArgs e)
        {
            tbLatC.Visible = false;
            tbLongC.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label9.Visible = false;


            cbNumBorne.Visible = false;
        }

        private void rbClassique_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClassique.Checked == true)
            {
                label8.Visible = false;
                label9.Visible = false;
                cbNumBorne.Visible = false;
            }
            else
            {
                label8.Visible = true;
                label9.Visible = true;
                cbNumBorne.Visible = true;
            }
        }

        private void rbElec_CheckedChanged(object sender, EventArgs e)
        {
            if (rbElec.Checked == true)
            {
                label4.Visible = false;
                label2.Visible = false;
                label6.Visible = false;
                tbLatC.Visible = false;
                tbLongC.Visible = false;

            }
            else
            {
                label4.Visible = true;
                label2.Visible = true;
                label6.Visible = true;
                tbLatC.Visible = true;
                tbLongC.Visible = true;
            }
        }

        private void TbLongC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbLatC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
