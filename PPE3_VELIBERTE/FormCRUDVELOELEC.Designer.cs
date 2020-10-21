using System.Windows.Forms;

namespace PPE3_VELIBERTE
{
    partial class FormCRUDVELOELEC
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
            this.cbNumVeh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumB = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNumVeh
            // 
            this.cbNumVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumVeh.FormattingEnabled = true;
            this.cbNumVeh.Location = new System.Drawing.Point(248, 53);
            this.cbNumVeh.Name = "cbNumVeh";
            this.cbNumVeh.Size = new System.Drawing.Size(146, 21);
            this.cbNumVeh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numéro du Véhicule : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom de la Borne :";
            // 
            // cbNumB
            // 
            this.cbNumB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumB.FormattingEnabled = true;
            this.cbNumB.Location = new System.Drawing.Point(248, 115);
            this.cbNumB.Name = "cbNumB";
            this.cbNumB.Size = new System.Drawing.Size(146, 21);
            this.cbNumB.TabIndex = 5;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.ForeColor = System.Drawing.Color.Red;
            this.BtnOk.Location = new System.Drawing.Point(483, 69);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(113, 40);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "CONFIRMER";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // FormCRUDVELOELEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 173);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.cbNumB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNumVeh);
            this.Name = "FormCRUDVELOELEC";
            this.Text = "FormCRUDVELOELEC";
            this.Load += new System.EventHandler(this.FormCRUDVELOELEC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNumVeh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumB;
        private System.Windows.Forms.Button BtnOk;

        public ComboBox CbNumB { get => cbNumB; set => cbNumB = value; }
        public Button BtnOk1 { get => BtnOk; set => BtnOk = value; }
        public ComboBox CbNumVeh { get => cbNumVeh; set => cbNumVeh = value; }
    }
}