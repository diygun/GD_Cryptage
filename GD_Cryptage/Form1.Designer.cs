
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcrypter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clePerso = new System.Windows.Forms.TextBox();
            this.txtCrypteDES = new System.Windows.Forms.TextBox();
            this.txtCryptePerso = new System.Windows.Forms.TextBox();
            this.btnCrypter = new System.Windows.Forms.Button();
            this.btnDecrypter = new System.Windows.Forms.Button();
            this.cleNET = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDecryptNET = new System.Windows.Forms.Button();
            this.btnCryptNET = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(307, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text initiale";
            // 
            // txtAcrypter
            // 
            this.txtAcrypter.Location = new System.Drawing.Point(388, 165);
            this.txtAcrypter.Name = "txtAcrypter";
            this.txtAcrypter.Size = new System.Drawing.Size(356, 20);
            this.txtAcrypter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clé de chiffrement perso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(76, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text crypté perso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(555, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Text crypté DES (.NET)";
            // 
            // clePerso
            // 
            this.clePerso.Location = new System.Drawing.Point(309, 230);
            this.clePerso.Name = "clePerso";
            this.clePerso.Size = new System.Drawing.Size(117, 20);
            this.clePerso.TabIndex = 5;
            //this.clePerso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clePerso_KeyPress);
            // 
            // txtCrypteDES
            // 
            this.txtCrypteDES.Location = new System.Drawing.Point(682, 330);
            this.txtCrypteDES.Name = "txtCrypteDES";
            this.txtCrypteDES.Size = new System.Drawing.Size(356, 20);
            this.txtCrypteDES.TabIndex = 7;
            // 
            // txtCryptePerso
            // 
            this.txtCryptePerso.Location = new System.Drawing.Point(186, 330);
            this.txtCryptePerso.Name = "txtCryptePerso";
            this.txtCryptePerso.Size = new System.Drawing.Size(356, 20);
            this.txtCryptePerso.TabIndex = 8;
            // 
            // btnCrypter
            // 
            this.btnCrypter.Location = new System.Drawing.Point(70, 256);
            this.btnCrypter.Name = "btnCrypter";
            this.btnCrypter.Size = new System.Drawing.Size(233, 57);
            this.btnCrypter.TabIndex = 9;
            this.btnCrypter.Text = "Crypter avec Lorem";
            this.btnCrypter.UseVisualStyleBackColor = true;
            this.btnCrypter.Click += new System.EventHandler(this.btnCrypter_Click);
            // 
            // btnDecrypter
            // 
            this.btnDecrypter.Location = new System.Drawing.Point(309, 256);
            this.btnDecrypter.Name = "btnDecrypter";
            this.btnDecrypter.Size = new System.Drawing.Size(233, 57);
            this.btnDecrypter.TabIndex = 10;
            this.btnDecrypter.Text = "Decrypter avec Lorem";
            this.btnDecrypter.UseVisualStyleBackColor = true;
            this.btnDecrypter.Click += new System.EventHandler(this.btnDecrypter_Click);
            // 
            // cleNET
            // 
            this.cleNET.Location = new System.Drawing.Point(810, 230);
            this.cleNET.Name = "cleNET";
            this.cleNET.Size = new System.Drawing.Size(117, 20);
            this.cleNET.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clé de chiffrement .NET";
            // 
            // btnDecryptNET
            // 
            this.btnDecryptNET.Location = new System.Drawing.Point(810, 256);
            this.btnDecryptNET.Name = "btnDecryptNET";
            this.btnDecryptNET.Size = new System.Drawing.Size(233, 57);
            this.btnDecryptNET.TabIndex = 14;
            this.btnDecryptNET.Text = "Decrypter avec DES (.NET)";
            this.btnDecryptNET.UseVisualStyleBackColor = true;
            this.btnDecryptNET.Click += new System.EventHandler(this.btnDecryptNET_Click);
            // 
            // btnCryptNET
            // 
            this.btnCryptNET.Location = new System.Drawing.Point(571, 256);
            this.btnCryptNET.Name = "btnCryptNET";
            this.btnCryptNET.Size = new System.Drawing.Size(233, 57);
            this.btnCryptNET.TabIndex = 13;
            this.btnCryptNET.Text = "Crypter avec DES (.NET)";
            this.btnCryptNET.UseVisualStyleBackColor = true;
            this.btnCryptNET.Click += new System.EventHandler(this.btnCryptNET_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1674, 741);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(309, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(523, 136);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 420);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDecryptNET);
            this.Controls.Add(this.btnCryptNET);
            this.Controls.Add(this.cleNET);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDecrypter);
            this.Controls.Add(this.btnCrypter);
            this.Controls.Add(this.txtCryptePerso);
            this.Controls.Add(this.txtCrypteDES);
            this.Controls.Add(this.clePerso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAcrypter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Crypt-it";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.TextBox txtCrypteDES;
        private System.Windows.Forms.TextBox txtCryptePerso;
        private System.Windows.Forms.Button btnCrypter;
        private System.Windows.Forms.Button btnDecrypter;
        private System.Windows.Forms.TextBox cleNET;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDecryptNET;
        private System.Windows.Forms.Button btnCryptNET;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

