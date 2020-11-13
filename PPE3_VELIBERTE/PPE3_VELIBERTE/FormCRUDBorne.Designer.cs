using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDBorne
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
            this.tbNomBorne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnumAdresseRue = new System.Windows.Forms.TextBox();
            this.tbNomAdresseRue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.latitudeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.longitudeText = new System.Windows.Forms.TextBox();
            this.pbValid1 = new System.Windows.Forms.PictureBox();
            this.pbNonValid2 = new System.Windows.Forms.PictureBox();
            this.pbNonValideR = new System.Windows.Forms.PictureBox();
            this.pbValideR = new System.Windows.Forms.PictureBox();
            this.pbValideLat = new System.Windows.Forms.PictureBox();
            this.pbNonValideLat = new System.Windows.Forms.PictureBox();
            this.pbValideL = new System.Windows.Forms.PictureBox();
            this.pbNonValideL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la Borne :";
            // 
            // tbNomBorne
            // 
            this.tbNomBorne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomBorne.Location = new System.Drawing.Point(148, 33);
            this.tbNomBorne.Name = "tbNomBorne";
            this.tbNomBorne.Size = new System.Drawing.Size(190, 22);
            this.tbNomBorne.TabIndex = 1;
            this.tbNomBorne.TextChanged += new System.EventHandler(this.TbNomBorne_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro de rue  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom rue  :";
            // 
            // tbnumAdresseRue
            // 
            this.tbnumAdresseRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumAdresseRue.Location = new System.Drawing.Point(148, 80);
            this.tbnumAdresseRue.Name = "tbnumAdresseRue";
            this.tbnumAdresseRue.Size = new System.Drawing.Size(47, 22);
            this.tbnumAdresseRue.TabIndex = 4;
            this.tbnumAdresseRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnumAdresseRue_KeyPress);
            // 
            // tbNomAdresseRue
            // 
            this.tbNomAdresseRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomAdresseRue.Location = new System.Drawing.Point(148, 118);
            this.tbNomAdresseRue.Name = "tbNomAdresseRue";
            this.tbNomAdresseRue.Size = new System.Drawing.Size(190, 22);
            this.tbNomAdresseRue.TabIndex = 5;
            this.tbNomAdresseRue.TextChanged += new System.EventHandler(this.TbNomAdresseRue_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(148, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK\r\n";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(27, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Latitude :";
            // 
            // latitudeText
            // 
            this.latitudeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeText.Location = new System.Drawing.Point(148, 163);
            this.latitudeText.Name = "latitudeText";
            this.latitudeText.Size = new System.Drawing.Size(190, 22);
            this.latitudeText.TabIndex = 8;
            this.latitudeText.TextChanged += new System.EventHandler(this.Latitude_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Longitude :";
            // 
            // longitudeText
            // 
            this.longitudeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeText.Location = new System.Drawing.Point(148, 197);
            this.longitudeText.Name = "longitudeText";
            this.longitudeText.Size = new System.Drawing.Size(190, 22);
            this.longitudeText.TabIndex = 10;
            this.longitudeText.TextChanged += new System.EventHandler(this.LongitudeText_TextChanged);
            // 
            // pbValid1
            // 
            this.pbValid1.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValid1.Location = new System.Drawing.Point(353, 33);
            this.pbValid1.Name = "pbValid1";
            this.pbValid1.Size = new System.Drawing.Size(27, 32);
            this.pbValid1.TabIndex = 24;
            this.pbValid1.TabStop = false;
            this.pbValid1.Visible = false;
            this.pbValid1.Click += new System.EventHandler(this.PbValid1_Click);
            // 
            // pbNonValid2
            // 
            this.pbNonValid2.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValid2.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValid2.Location = new System.Drawing.Point(399, 33);
            this.pbNonValid2.Name = "pbNonValid2";
            this.pbNonValid2.Size = new System.Drawing.Size(26, 31);
            this.pbNonValid2.TabIndex = 26;
            this.pbNonValid2.TabStop = false;
            this.pbNonValid2.Visible = false;
            this.pbNonValid2.Click += new System.EventHandler(this.PbNonValid2_Click_1);
            // 
            // pbNonValideR
            // 
            this.pbNonValideR.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideR.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideR.Location = new System.Drawing.Point(399, 118);
            this.pbNonValideR.Name = "pbNonValideR";
            this.pbNonValideR.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideR.TabIndex = 27;
            this.pbNonValideR.TabStop = false;
            this.pbNonValideR.Visible = false;
            this.pbNonValideR.Click += new System.EventHandler(this.PbNonValideR_Click);
            // 
            // pbValideR
            // 
            this.pbValideR.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideR.Location = new System.Drawing.Point(353, 117);
            this.pbValideR.Name = "pbValideR";
            this.pbValideR.Size = new System.Drawing.Size(27, 32);
            this.pbValideR.TabIndex = 28;
            this.pbValideR.TabStop = false;
            this.pbValideR.Visible = false;
            this.pbValideR.Click += new System.EventHandler(this.PbValideR_Click);
            // 
            // pbValideLat
            // 
            this.pbValideLat.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideLat.Location = new System.Drawing.Point(353, 155);
            this.pbValideLat.Name = "pbValideLat";
            this.pbValideLat.Size = new System.Drawing.Size(27, 32);
            this.pbValideLat.TabIndex = 29;
            this.pbValideLat.TabStop = false;
            this.pbValideLat.Visible = false;
            // 
            // pbNonValideLat
            // 
            this.pbNonValideLat.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideLat.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideLat.Location = new System.Drawing.Point(399, 156);
            this.pbNonValideLat.Name = "pbNonValideLat";
            this.pbNonValideLat.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideLat.TabIndex = 30;
            this.pbNonValideLat.TabStop = false;
            this.pbNonValideLat.Visible = false;
            // 
            // pbValideL
            // 
            this.pbValideL.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideL.Location = new System.Drawing.Point(353, 193);
            this.pbValideL.Name = "pbValideL";
            this.pbValideL.Size = new System.Drawing.Size(27, 32);
            this.pbValideL.TabIndex = 31;
            this.pbValideL.TabStop = false;
            this.pbValideL.Visible = false;
            this.pbValideL.Click += new System.EventHandler(this.PbValideL_Click);
            // 
            // pbNonValideL
            // 
            this.pbNonValideL.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideL.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideL.Location = new System.Drawing.Point(399, 194);
            this.pbNonValideL.Name = "pbNonValideL";
            this.pbNonValideL.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideL.TabIndex = 32;
            this.pbNonValideL.TabStop = false;
            this.pbNonValideL.Visible = false;
            this.pbNonValideL.Click += new System.EventHandler(this.PbNonValideL_Click);
            // 
            // FormCRUDBorne
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 341);
            this.Controls.Add(this.pbNonValideL);
            this.Controls.Add(this.pbValideL);
            this.Controls.Add(this.pbNonValideLat);
            this.Controls.Add(this.pbValideLat);
            this.Controls.Add(this.pbValideR);
            this.Controls.Add(this.pbNonValideR);
            this.Controls.Add(this.pbNonValid2);
            this.Controls.Add(this.pbValid1);
            this.Controls.Add(this.longitudeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.latitudeText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNomAdresseRue);
            this.Controls.Add(this.tbnumAdresseRue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomBorne);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDBorne";
            this.Text = "Ajouter/Modifier : table BORNE";
            this.Load += new System.EventHandler(this.FormCRUDBorne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomBorne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnumAdresseRue;
        private System.Windows.Forms.TextBox tbNomAdresseRue;
        private System.Windows.Forms.Button btnOK;
        private Label label4;
        private TextBox latitudeText;
        private Label label5;
        private TextBox longitudeText;
        private PictureBox pbValid1;
        private PictureBox pbNonValid2;
        private PictureBox pbNonValideR;
        private PictureBox pbValideR;
        private PictureBox pbValideLat;
        private PictureBox pbNonValideLat;
        private PictureBox pbValideL;
        private PictureBox pbNonValideL;

        public TextBox TbNomBorne
        {
            get
            {
                return tbNomBorne;
            }

            set
            {
                tbNomBorne = value;
            }
        }

        public TextBox TbnumAdresseRue
        {
            get
            {
                return tbnumAdresseRue;
            }

            set
            {
                tbnumAdresseRue = value;
            }
        }

        public TextBox TbNomAdresseRue
        {
            get
            {
                return tbNomAdresseRue;
            }

            set
            {
                tbNomAdresseRue = value;
            }
        }

        public TextBox LatitudeText
        {
            get
            {
                return latitudeText;
            }

            set
            {
                latitudeText = value;
            }
        }
        public TextBox LongitudeText
        {
            get
            {
                return longitudeText;
            }

            set
            {
                longitudeText = value;
            }
        }

    }
}