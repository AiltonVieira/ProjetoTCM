namespace Projeto_TCM
{
    partial class telaSplash
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
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(21, 257);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(522, 23);
            this.barraProgresso.TabIndex = 0;
            this.barraProgresso.Click += new System.EventHandler(this.barraProgresso_Click);
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Location = new System.Drawing.Point(65, 94);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(35, 13);
            this.lblCarregando.TabIndex = 1;
            this.lblCarregando.Text = "label1";
            this.lblCarregando.Click += new System.EventHandler(this.lblCarregando_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // telaSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 378);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.barraProgresso);
            this.Name = "telaSplash";
            this.Text = "telaSplash";
            this.Load += new System.EventHandler(this.telaSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.Timer timer1;
    }
}