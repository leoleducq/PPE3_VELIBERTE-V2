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
            this.pbNonValideTT = new System.Windows.Forms.PictureBox();
            this.pbValideTT = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeTravaux = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNumeroVelo = new System.Windows.Forms.ComboBox();
            this.pbValideNV = new System.Windows.Forms.PictureBox();
            this.pbNonValideNV = new System.Windows.Forms.PictureBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideNV)).BeginInit();
            this.SuspendLayout();
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.cbTypeTravaux.SelectedIndexChanged += new System.EventHandler(this.cbTypeTravaux_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(201, 121);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(187, 20);
            this.datePicker.TabIndex = 54;
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
            this.cbNumeroVelo.SelectedIndexChanged += new System.EventHandler(this.cbNumeroVelo_SelectedIndexChanged);
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
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(200, 161);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(85, 20);
            this.TimePicker.TabIndex = 60;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // FormCRUDReparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 361);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.pbNonValideNV);
            this.Controls.Add(this.pbValideNV);
            this.Controls.Add(this.cbNumeroVelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.cbTypeTravaux);
            this.Controls.Add(this.pbNonValideTT);
            this.Controls.Add(this.pbValideTT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDReparation";
            this.Text = "FormCRUDReparation";
            this.Load += new System.EventHandler(this.FormCRUDReparation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValideNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValideNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbNonValideTT;
        private System.Windows.Forms.PictureBox pbValideTT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeTravaux;
        private System.Windows.Forms.DateTimePicker datePicker;
        private Label label5;
        private ComboBox cbNumeroVelo;
        private PictureBox pbValideNV;
        private PictureBox pbNonValideNV;
        private DateTimePicker TimePicker;

        public ComboBox CbTypeTravaux { get => cbTypeTravaux; set => cbTypeTravaux = value; }
        public DateTimePicker DatePicker { get => datePicker; set => datePicker = value; }

        public ComboBox CbNumeroVelo { get => cbNumeroVelo; set => cbNumeroVelo = value; }

        public DateTimePicker TimePicker1 { get => TimePicker; set => TimePicker = value; }
    }
}