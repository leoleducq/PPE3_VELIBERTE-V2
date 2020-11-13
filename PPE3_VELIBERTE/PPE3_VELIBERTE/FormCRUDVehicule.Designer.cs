using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDVehicule
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbClassique = new System.Windows.Forms.RadioButton();
            this.rbElec = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEtatVehicule = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLatC = new System.Windows.Forms.TextBox();
            this.tbLongC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNumBorne = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Velo";
            // 
            // rbClassique
            // 
            this.rbClassique.AutoSize = true;
            this.rbClassique.Location = new System.Drawing.Point(78, 77);
            this.rbClassique.Name = "rbClassique";
            this.rbClassique.Size = new System.Drawing.Size(93, 17);
            this.rbClassique.TabIndex = 17;
            this.rbClassique.TabStop = true;
            this.rbClassique.Text = "Velo classique";
            this.rbClassique.UseVisualStyleBackColor = true;
            this.rbClassique.CheckedChanged += new System.EventHandler(this.rbClassique_CheckedChanged);
            // 
            // rbElec
            // 
            this.rbElec.AutoSize = true;
            this.rbElec.Location = new System.Drawing.Point(285, 77);
            this.rbElec.Name = "rbElec";
            this.rbElec.Size = new System.Drawing.Size(95, 17);
            this.rbElec.TabIndex = 18;
            this.rbElec.TabStop = true;
            this.rbElec.Text = "Velo electrique";
            this.rbElec.UseVisualStyleBackColor = true;
            this.rbElec.CheckedChanged += new System.EventHandler(this.rbElec_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(37, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Etat du Vehicule :";
            // 
            // cbEtatVehicule
            // 
            this.cbEtatVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtatVehicule.FormattingEnabled = true;
            this.cbEtatVehicule.Items.AddRange(new object[] {
            "R",
            "D"});
            this.cbEtatVehicule.Location = new System.Drawing.Point(209, 140);
            this.cbEtatVehicule.Name = "cbEtatVehicule";
            this.cbEtatVehicule.Size = new System.Drawing.Size(193, 21);
            this.cbEtatVehicule.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(539, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Velo Classique  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Latitude du Vélo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Longitude du Vélo : ";
            // 
            // tbLatC
            // 
            this.tbLatC.Location = new System.Drawing.Point(685, 89);
            this.tbLatC.Name = "tbLatC";
            this.tbLatC.Size = new System.Drawing.Size(128, 20);
            this.tbLatC.TabIndex = 24;
            this.tbLatC.TextChanged += new System.EventHandler(this.TbLatC_TextChanged);
            // 
            // tbLongC
            // 
            this.tbLongC.Location = new System.Drawing.Point(685, 122);
            this.tbLongC.Name = "tbLongC";
            this.tbLongC.Size = new System.Drawing.Size(128, 20);
            this.tbLongC.TabIndex = 25;
            this.tbLongC.TextChanged += new System.EventHandler(this.TbLongC_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(57, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Velo Electrique  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Numero de Borne :";
            // 
            // cbNumBorne
            // 
            this.cbNumBorne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumBorne.FormattingEnabled = true;
            this.cbNumBorne.Location = new System.Drawing.Point(194, 301);
            this.cbNumBorne.Name = "cbNumBorne";
            this.cbNumBorne.Size = new System.Drawing.Size(128, 21);
            this.cbNumBorne.TabIndex = 28;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Red;
            this.btnOK.Location = new System.Drawing.Point(657, 246);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 39);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "CONFIRMER";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 363);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbNumBorne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbLongC);
            this.Controls.Add(this.tbLatC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEtatVehicule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbElec);
            this.Controls.Add(this.rbClassique);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDVehicule";
            this.Text = "FormCRUDVehicule";
            this.Load += new System.EventHandler(this.FormCRUDVehicule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbClassique;
        private System.Windows.Forms.RadioButton rbElec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEtatVehicule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLatC;
        private System.Windows.Forms.TextBox tbLongC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNumBorne;
        private System.Windows.Forms.Button btnOK;

        public TextBox TbLatC { get => tbLatC; set => tbLatC = value; }
        public ComboBox CbEtatVehicule { get => cbEtatVehicule; set => cbEtatVehicule = value; }
        public TextBox TbLongC { get => tbLongC; set => tbLongC = value; }
        public RadioButton RbElec { get => rbElec; set => rbElec = value; }
        public RadioButton RbClassique { get => rbClassique; set => rbClassique = value; }
        public ComboBox CbNumBorne { get => cbNumBorne; set => cbNumBorne = value; }
    }
}