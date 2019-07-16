namespace Projeto_TCM.Telas.telasPrincipais
{
    partial class Consultar
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
            this.btnreturn = new System.Windows.Forms.Button();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(183, 213);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 0;
            this.btnreturn.Text = "retornoPrin";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(584, 326);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(30, 13);
            this.lbldata.TabIndex = 1;
            this.lbldata.Text = "Data";
            this.lbldata.Click += new System.EventHandler(this.lbldata_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(599, 313);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(30, 13);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "Hora";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 348);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.btnreturn);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.consultarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timerHora;
    }
}