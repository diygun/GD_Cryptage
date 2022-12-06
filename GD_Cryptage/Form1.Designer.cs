
namespace GD_Cryptage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcrypter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clePerso = new System.Windows.Forms.TextBox();
            this.txtCrypteSHA512 = new System.Windows.Forms.TextBox();
            this.txtCryptePerso = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCrypter = new System.Windows.Forms.Button();
            this.btnDecrypter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text initiale";
            // 
            // txtAcrypter
            // 
            this.txtAcrypter.Location = new System.Drawing.Point(212, 61);
            this.txtAcrypter.Name = "txtAcrypter";
            this.txtAcrypter.Size = new System.Drawing.Size(356, 20);
            this.txtAcrypter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clé de chiffrement perso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text crypté perso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Text crypté SHA-512";
            // 
            // clePerso
            // 
            this.clePerso.Location = new System.Drawing.Point(212, 91);
            this.clePerso.Name = "clePerso";
            this.clePerso.Size = new System.Drawing.Size(117, 20);
            this.clePerso.TabIndex = 5;
            // 
            // txtCrypteSHA512
            // 
            this.txtCrypteSHA512.Location = new System.Drawing.Point(212, 243);
            this.txtCrypteSHA512.Name = "txtCrypteSHA512";
            this.txtCrypteSHA512.Size = new System.Drawing.Size(356, 20);
            this.txtCrypteSHA512.TabIndex = 7;
            // 
            // txtCryptePerso
            // 
            this.txtCryptePerso.Location = new System.Drawing.Point(212, 208);
            this.txtCryptePerso.Name = "txtCryptePerso";
            this.txtCryptePerso.Size = new System.Drawing.Size(356, 20);
            this.txtCryptePerso.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCrypter
            // 
            this.btnCrypter.Location = new System.Drawing.Point(96, 134);
            this.btnCrypter.Name = "btnCrypter";
            this.btnCrypter.Size = new System.Drawing.Size(233, 57);
            this.btnCrypter.TabIndex = 9;
            this.btnCrypter.Text = "Crypter";
            this.btnCrypter.UseVisualStyleBackColor = true;
            this.btnCrypter.Click += new System.EventHandler(this.btnCrypter_Click);
            // 
            // btnDecrypter
            // 
            this.btnDecrypter.Location = new System.Drawing.Point(335, 134);
            this.btnDecrypter.Name = "btnDecrypter";
            this.btnDecrypter.Size = new System.Drawing.Size(233, 57);
            this.btnDecrypter.TabIndex = 10;
            this.btnDecrypter.Text = "Decrypter";
            this.btnDecrypter.UseVisualStyleBackColor = true;
            this.btnDecrypter.Click += new System.EventHandler(this.btnDecrypter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 393);
            this.Controls.Add(this.btnDecrypter);
            this.Controls.Add(this.btnCrypter);
            this.Controls.Add(this.txtCryptePerso);
            this.Controls.Add(this.txtCrypteSHA512);
            this.Controls.Add(this.clePerso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAcrypter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Crypt-it";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcrypter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clePerso;
        private System.Windows.Forms.TextBox txtCrypteSHA512;
        private System.Windows.Forms.TextBox txtCryptePerso;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCrypter;
        private System.Windows.Forms.Button btnDecrypter;
    }
}

