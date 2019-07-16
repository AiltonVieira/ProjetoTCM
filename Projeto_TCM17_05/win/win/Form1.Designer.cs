namespace win
{
    partial class Exemplo
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
            this.tssData = new System.Windows.Forms.ToolStrip();
            this.tss = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssHora = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tssData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tssData
            // 
            this.tssData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tssData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss,
            this.toolStripSeparator1,
            this.tssHora});
            this.tssData.Location = new System.Drawing.Point(0, 236);
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(284, 25);
            this.tssData.TabIndex = 0;
            this.tssData.Text = "tssData";
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(45, 22);
            this.tss.Text = "tssData";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tssHora
            // 
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(47, 22);
            this.tssHora.Text = "tssHora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tssData);
            this.Name = "Exemplo";
            this.Text = "Exemplo";
            this.Load += new System.EventHandler(this.Exemplo_Load);
            this.tssData.ResumeLayout(false);
            this.tssData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tssData;
        private System.Windows.Forms.ToolStripLabel tss;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tssHora;
        private System.Windows.Forms.Timer timer1;
    }
}

