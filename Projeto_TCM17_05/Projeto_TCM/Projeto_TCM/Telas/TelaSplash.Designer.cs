namespace Projeto_TCM
{
    partial class TelaSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSplash));
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picWifi = new System.Windows.Forms.PictureBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.lblCarregando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(60, 208);
            this.barraProgresso.MarqueeAnimationSpeed = 1;
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(392, 10);
            this.barraProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgresso.TabIndex = 0;
            this.barraProgresso.Click += new System.EventHandler(this.barraProgresso_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(116, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(285, 166);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // picWifi
            // 
            this.picWifi.Image = ((System.Drawing.Image)(resources.GetObject("picWifi.Image")));
            this.picWifi.Location = new System.Drawing.Point(264, 12);
            this.picWifi.Name = "picWifi";
            this.picWifi.Size = new System.Drawing.Size(86, 81);
            this.picWifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWifi.TabIndex = 6;
            this.picWifi.TabStop = false;
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.Image = ((System.Drawing.Image)(resources.GetObject("picLoad.Image")));
            this.picLoad.Location = new System.Drawing.Point(427, 176);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(25, 26);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoad.TabIndex = 7;
            this.picLoad.TabStop = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.BackColor = System.Drawing.Color.White;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.Location = new System.Drawing.Point(220, 100);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(33, 19);
            this.lblCarregando.TabIndex = 8;
            this.lblCarregando.Text = "0%";
            this.lblCarregando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 225);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picWifi);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.barraProgresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaSplash";
            this.Load += new System.EventHandler(this.telaSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWifi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picWifi;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Label lblCarregando;
    }
}