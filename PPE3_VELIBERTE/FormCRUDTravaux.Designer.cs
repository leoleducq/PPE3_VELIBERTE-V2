using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDTravaux
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
            this.pbNonValide = new System.Windows.Forms.PictureBox();
            this.pbValide = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.typeTravaux = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValide)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNonValide
            // 
            this.pbNonValide.BackColor = System.Drawing.Color.Transparent;
            this.pbNonValide.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_rouge;
            this.pbNonValide.Location = new System.Drawing.Point(409, 28);
            this.pbNonValide.Name = "pbNonValide";
            this.pbNonValide.Size = new System.Drawing.Size(26, 31);
            this.pbNonValide.TabIndex = 45;
            this.pbNonValide.TabStop = false;
            this.pbNonValide.Visible = false;
            // 
            // pbValide
            // 
            this.pbValide.Image = global::PPE3_VELIBERTE.Properties.Resources.valid_vert;
            this.pbValide.Location = new System.Drawing.Point(363, 28);
            this.pbValide.Name = "pbValide";
            this.pbValide.Size = new System.Drawing.Size(27, 32);
            this.pbValide.TabIndex = 44;
            this.pbValide.TabStop = false;
            this.pbValide.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(189, 102);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "OK\r\n";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // typeTravaux
            // 
            this.typeTravaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTravaux.Location = new System.Drawing.Point(158, 28);
            this.typeTravaux.Name = "typeTravaux";
            this.typeTravaux.Size = new System.Drawing.Size(190, 22);
            this.typeTravaux.TabIndex = 34;
            this.typeTravaux.TextChanged += new System.EventHandler(this.TbNomBorne_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Type de travaux";
            // 
            // FormCRUDTravaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 160);
            this.Controls.Add(this.pbNonValide);
            this.Controls.Add(this.pbValide);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.typeTravaux);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDTravaux";
            this.Text = "FormCRUDTravaux";
            this.Load += new System.EventHandler(this.FormCRUDTravaux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNonValide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbNonValide;
        private System.Windows.Forms.PictureBox pbValide;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox typeTravaux;
        private System.Windows.Forms.Label label1;

        public TextBox TypeTravaux { get => typeTravaux; set => typeTravaux = value; }
    }
}