using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDReparation
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
            this.pbNonValideU = new System.Windows.Forms.PictureBox();
            this.pbValideU = new System.Windows.Forms.PictureBox();
            this.pbValideTR = new System.Windows.Forms.PictureBox();
            this.pbNonValideTR = new System.Windows.Forms.PictureBox();
            this.pbNonValideTT = new System.Windows.Forms.PictureBox();
            this.pbValideTT = new System.Windows.Forms.PictureBox();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxTempsReparation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeTravaux = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbUtilisateur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNumeroVelo = new System.Windows.Forms.ComboBox();
            this.pbValideNV = new System.Windows.Forms.PictureBox();
            this.pbNonValideNV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNonValideU
            // 
            this.pbNonValideU.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideU.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideU.Location = new System.Drawing.Point(452, 197);
            this.pbNonValideU.Name = "pbNonValideU";
            this.pbNonValideU.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideU.TabIndex = 49;
            this.pbNonValideU.TabStop = false;
            // 
            // pbValideU
            // 
            this.pbValideU.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideU.Location = new System.Drawing.Point(406, 196);
            this.pbValideU.Name = "pbValideU";
            this.pbValideU.Size = new System.Drawing.Size(27, 32);
            this.pbValideU.TabIndex = 48;
            this.pbValideU.TabStop = false;
            this.pbValideU.Visible = false;
            // 
            // pbValideTR
            // 
            this.pbValideTR.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideTR.Location = new System.Drawing.Point(406, 158);
            this.pbValideTR.Name = "pbValideTR";
            this.pbValideTR.Size = new System.Drawing.Size(27, 32);
            this.pbValideTR.TabIndex = 47;
            this.pbValideTR.TabStop = false;
            this.pbValideTR.Visible = false;
            // 
            // pbNonValideTR
            // 
            this.pbNonValideTR.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideTR.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideTR.Location = new System.Drawing.Point(452, 159);
            this.pbNonValideTR.Name = "pbNonValideTR";
            this.pbNonValideTR.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideTR.TabIndex = 46;
            this.pbNonValideTR.TabStop = false;
            // 
            // pbNonValideTT
            // 
            this.pbNonValideTT.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideTT.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideTT.Location = new System.Drawing.Point(452, 74);
            this.pbNonValideTT.Name = "pbNonValideTT";
            this.pbNonValideTT.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideTT.TabIndex = 45;
            this.pbNonValideTT.TabStop = false;
            // 
            // pbValideTT
            // 
            this.pbValideTT.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideTT.Location = new System.Drawing.Point(406, 74);
            this.pbValideTT.Name = "pbValideTT";
            this.pbValideTT.Size = new System.Drawing.Size(27, 32);
            this.pbValideTT.TabIndex = 44;
            this.pbValideTT.TabStop = false;
            this.pbValideTT.Visible = false;
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelUtilisateur.Location = new System.Drawing.Point(118, 204);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(73, 16);
            this.labelUtilisateur.TabIndex = 40;
            this.labelUtilisateur.Text = "Utilisateur :";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(201, 273);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "OK\r\n";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // textBoxTempsReparation
            // 
            this.textBoxTempsReparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempsReparation.Location = new System.Drawing.Point(201, 159);
            this.textBoxTempsReparation.Name = "textBoxTempsReparation";
            this.textBoxTempsReparation.Size = new System.Drawing.Size(159, 22);
            this.textBoxTempsReparation.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Temps de réparation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(69, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date de réparation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(80, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type de travaux :";
            // 
            // cbTypeTravaux
            // 
            this.cbTypeTravaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTravaux.FormattingEnabled = true;
            this.cbTypeTravaux.Location = new System.Drawing.Point(201, 78);
            this.cbTypeTravaux.Name = "cbTypeTravaux";
            this.cbTypeTravaux.Size = new System.Drawing.Size(128, 21);
            this.cbTypeTravaux.TabIndex = 52;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(201, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker.TabIndex = 54;
            // 
            // cbUtilisateur
            // 
            this.cbUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUtilisateur.FormattingEnabled = true;
            this.cbUtilisateur.Location = new System.Drawing.Point(201, 203);
            this.cbUtilisateur.Name = "cbUtilisateur";
            this.cbUtilisateur.Size = new System.Drawing.Size(128, 21);
            this.cbUtilisateur.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(80, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Numéro du vélo :";
            // 
            // cbNumeroVelo
            // 
            this.cbNumeroVelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroVelo.FormattingEnabled = true;
            this.cbNumeroVelo.Location = new System.Drawing.Point(201, 36);
            this.cbNumeroVelo.Name = "cbNumeroVelo";
            this.cbNumeroVelo.Size = new System.Drawing.Size(128, 21);
            this.cbNumeroVelo.TabIndex = 57;
            // 
            // pbValideNV
            // 
            this.pbValideNV.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValideNV.Location = new System.Drawing.Point(406, 26);
            this.pbValideNV.Name = "pbValideNV";
            this.pbValideNV.Size = new System.Drawing.Size(27, 32);
            this.pbValideNV.TabIndex = 58;
            this.pbValideNV.TabStop = false;
            this.pbValideNV.Visible = false;
            // 
            // pbNonValideNV
            // 
            this.pbNonValideNV.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValideNV.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValideNV.Location = new System.Drawing.Point(452, 26);
            this.pbNonValideNV.Name = "pbNonValideNV";
            this.pbNonValideNV.Size = new System.Drawing.Size(26, 31);
            this.pbNonValideNV.TabIndex = 59;
            this.pbNonValideNV.TabStop = false;
            // 
            // FormCRUDReparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 361);
            this.Controls.Add(this.pbNonValideNV);
            this.Controls.Add(this.pbValideNV);
            this.Controls.Add(this.cbNumeroVelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbUtilisateur);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbTypeTravaux);
            this.Controls.Add(this.pbNonValideU);
            this.Controls.Add(this.pbValideU);
            this.Controls.Add(this.pbValideTR);
            this.Controls.Add(this.pbNonValideTR);
            this.Controls.Add(this.pbNonValideTT);
            this.Controls.Add(this.pbValideTT);
            this.Controls.Add(this.labelUtilisateur);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxTempsReparation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDReparation";
            this.Text = "FormCRUDReparation";
            this.Load += new System.EventHandler(this.FormCRUDReparation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbNonValideU;
        private System.Windows.Forms.PictureBox pbValideU;
        private System.Windows.Forms.PictureBox pbValideTR;
        private System.Windows.Forms.PictureBox pbNonValideTR;
        private System.Windows.Forms.PictureBox pbNonValideTT;
        private System.Windows.Forms.PictureBox pbValideTT;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBoxTempsReparation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeTravaux;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbUtilisateur;
        private Label label5;
        private ComboBox cbNumeroVelo;
        private PictureBox pbValideNV;
        private PictureBox pbNonValideNV;

        public ComboBox CbTypeTravaux { get => cbTypeTravaux; set => cbTypeTravaux = value; }
        public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
        public TextBox TextBoxTempsReparation { get => textBoxTempsReparation; set => textBoxTempsReparation = value; }
        public ComboBox CbUtilisateur { get => cbUtilisateur; set => cbUtilisateur = value; }
        public ComboBox CbNumeroVelo { get => cbNumeroVelo; set => cbNumeroVelo = value; }
        public Label LabelUtilisateur { get => labelUtilisateur; set => labelUtilisateur = value; }
    }
}