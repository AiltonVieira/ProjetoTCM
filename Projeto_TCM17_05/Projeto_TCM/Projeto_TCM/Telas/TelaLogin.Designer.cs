namespace Projeto_TCM.Telas
{
    partial class TelaLogin
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            this.linkEsqueceu = new System.Windows.Forms.LinkLabel();
            this.lbltecho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(23, 23);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(68, 20);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(27, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(158, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(27, 115);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(158, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsenha_KeyUp);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(23, 92);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(60, 20);
            this.lblsenha.TabIndex = 4;
            this.lblsenha.Text = "Senha:";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsair.Location = new System.Drawing.Point(165, 181);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 32);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnentrar.Location = new System.Drawing.Point(27, 181);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(94, 32);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // linkEsqueceu
            // 
            this.linkEsqueceu.AutoSize = true;
            this.linkEsqueceu.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkEsqueceu.Location = new System.Drawing.Point(24, 138);
            this.linkEsqueceu.Name = "linkEsqueceu";
            this.linkEsqueceu.Size = new System.Drawing.Size(113, 13);
            this.linkEsqueceu.TabIndex = 3;
            this.linkEsqueceu.TabStop = true;
            this.linkEsqueceu.Text = "Esqueceu sua senha?";
            this.linkEsqueceu.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lbltecho
            // 
            this.lbltecho.AutoSize = true;
            this.lbltecho.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.lbltecho.Location = new System.Drawing.Point(292, 181);
            this.lbltecho.Name = "lbltecho";
            this.lbltecho.Size = new System.Drawing.Size(104, 17);
            this.lbltecho.TabIndex = 10;
            this.lbltecho.Text = "Genesys v1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_TCM.Properties.Resources.logofire;
            this.pictureBox1.Location = new System.Drawing.Point(285, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(438, 225);
            this.Controls.Add(this.lbltecho);
            this.Controls.Add(this.linkEsqueceu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblusuario);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faça seu login";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.telaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.LinkLabel linkEsqueceu;
        private System.Windows.Forms.Label lbltecho;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

