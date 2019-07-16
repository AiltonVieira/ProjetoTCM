namespace Projeto_TCM.Telas
{
    partial class TelaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorio));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblrelatorio = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblsituação = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menStrip = new System.Windows.Forms.MenuStrip();
            this.srFulanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDtInicio = new System.Windows.Forms.TextBox();
            this.txtDtTermino = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.lblDtTermino = new System.Windows.Forms.Label();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.Location = new System.Drawing.Point(714, 710);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(152, 35);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(463, 710);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 35);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // lblrelatorio
            // 
            this.lblrelatorio.AutoSize = true;
            this.lblrelatorio.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrelatorio.Location = new System.Drawing.Point(856, 506);
            this.lblrelatorio.Name = "lblrelatorio";
            this.lblrelatorio.Size = new System.Drawing.Size(120, 20);
            this.lblrelatorio.TabIndex = 37;
            this.lblrelatorio.Text = "RELATÓRIO";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.Location = new System.Drawing.Point(453, 123);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(152, 35);
            this.btnbuscar.TabIndex = 42;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblsituação
            // 
            this.lblsituação.AutoSize = true;
            this.lblsituação.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituação.Location = new System.Drawing.Point(271, 94);
            this.lblsituação.Name = "lblsituação";
            this.lblsituação.Size = new System.Drawing.Size(233, 20);
            this.lblsituação.TabIndex = 44;
            this.lblsituação.Text = "SITUAÇÃO DO SERVIÇO";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(903, 153);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(111, 20);
            this.lblConsulta.TabIndex = 46;
            this.lblConsulta.Text = "CONSULTA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnEquipamento);
            this.panel3.Controls.Add(this.btnConsulta);
            this.panel3.Controls.Add(this.btnClientes);
            this.panel3.Controls.Add(this.btnFuncionarios);
            this.panel3.Controls.Add(this.btnRelatorio);
            this.panel3.Controls.Add(this.btnServiços);
            this.panel3.Controls.Add(this.btnInformacoes);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 768);
            this.panel3.TabIndex = 48;
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEquipamento.BackgroundImage")));
            this.btnEquipamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEquipamento.FlatAppearance.BorderSize = 0;
            this.btnEquipamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEquipamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipamento.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipamento.Location = new System.Drawing.Point(0, 573);
            this.btnEquipamento.Name = "btnEquipamento";
            this.btnEquipamento.Size = new System.Drawing.Size(260, 96);
            this.btnEquipamento.TabIndex = 69;
            this.btnEquipamento.Text = "            Equipamento";
            this.btnEquipamento.UseVisualStyleBackColor = false;
            this.btnEquipamento.Click += new System.EventHandler(this.btnEquipamento_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsulta.BackgroundImage")));
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulta.Location = new System.Drawing.Point(1, 273);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(260, 96);
            this.btnConsulta.TabIndex = 38;
            this.btnConsulta.Text = "         Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Location = new System.Drawing.Point(1, 187);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(260, 84);
            this.btnClientes.TabIndex = 35;
            this.btnClientes.Text = "        Cliente";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.BackgroundImage")));
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFuncionarios.Location = new System.Drawing.Point(1, 86);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(260, 96);
            this.btnFuncionarios.TabIndex = 37;
            this.btnFuncionarios.Text = "         Funcionário";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click_1);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.DarkGray;
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 472);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(260, 96);
            this.btnRelatorio.TabIndex = 39;
            this.btnRelatorio.Text = "        Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnServiços
            // 
            this.btnServiços.FlatAppearance.BorderSize = 0;
            this.btnServiços.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnServiços.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnServiços.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiços.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiços.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnServiços.Image = ((System.Drawing.Image)(resources.GetObject("btnServiços.Image")));
            this.btnServiços.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiços.Location = new System.Drawing.Point(1, 373);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(260, 96);
            this.btnServiços.TabIndex = 36;
            this.btnServiços.Text = "       Serviço";
            this.btnServiços.UseVisualStyleBackColor = true;
            this.btnServiços.Click += new System.EventHandler(this.btnServiços_Click_1);
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInformacoes.BackgroundImage")));
            this.btnInformacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInformacoes.FlatAppearance.BorderSize = 0;
            this.btnInformacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnInformacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformacoes.Location = new System.Drawing.Point(0, 672);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(261, 105);
            this.btnInformacoes.TabIndex = 40;
            this.btnInformacoes.Text = "            Informação";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // timerDataHora
            // 
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menStrip);
            this.panel2.Location = new System.Drawing.Point(-46, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 86);
            this.panel2.TabIndex = 52;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Italic);
            this.lblData.Location = new System.Drawing.Point(991, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 23);
            this.lblData.TabIndex = 124;
            this.lblData.Text = "Data:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Italic);
            this.lblHora.Location = new System.Drawing.Point(1023, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(64, 23);
            this.lblHora.TabIndex = 123;
            this.lblHora.Text = "Hora:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(760, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 122;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_TCM.Properties.Resources.logofire;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(46, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // menStrip
            // 
            this.menStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srFulanoToolStripMenuItem});
            this.menStrip.Location = new System.Drawing.Point(865, 35);
            this.menStrip.Name = "menStrip";
            this.menStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menStrip.Size = new System.Drawing.Size(129, 24);
            this.menStrip.TabIndex = 47;
            this.menStrip.Text = "menuStrip1";
            // 
            // srFulanoToolStripMenuItem
            // 
            this.srFulanoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarUsuarioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.srFulanoToolStripMenuItem.Name = "srFulanoToolStripMenuItem";
            this.srFulanoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.srFulanoToolStripMenuItem.Text = "Wellingtom Cidade";
            // 
            // trocarUsuarioToolStripMenuItem
            // 
            this.trocarUsuarioToolStripMenuItem.Name = "trocarUsuarioToolStripMenuItem";
            this.trocarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.trocarUsuarioToolStripMenuItem.Text = "Trocar Usuario";
            this.trocarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuarioToolStripMenuItem_Click);
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Disponível",
            "Em Andamento",
            "Encerrado"});
            this.cmbPesquisa.Location = new System.Drawing.Point(286, 131);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(145, 21);
            this.cmbPesquisa.TabIndex = 53;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbSituacaodoServico_SelectedIndexChanged);
            // 
            // dgvServico
            // 
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(285, 176);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(730, 196);
            this.dgvServico.TabIndex = 54;
            this.dgvServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(391, 401);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 56;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(636, 401);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(126, 20);
            this.txtEmpresa.TabIndex = 57;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(391, 446);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(126, 20);
            this.txtValor.TabIndex = 58;
            this.txtValor.TextChanged += new System.EventHandler(this.txtServico_TextChanged);
            // 
            // txtDtInicio
            // 
            this.txtDtInicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDtInicio.Enabled = false;
            this.txtDtInicio.Location = new System.Drawing.Point(636, 446);
            this.txtDtInicio.Name = "txtDtInicio";
            this.txtDtInicio.Size = new System.Drawing.Size(126, 20);
            this.txtDtInicio.TabIndex = 59;
            // 
            // txtDtTermino
            // 
            this.txtDtTermino.Location = new System.Drawing.Point(898, 446);
            this.txtDtTermino.Name = "txtDtTermino";
            this.txtDtTermino.Size = new System.Drawing.Size(117, 20);
            this.txtDtTermino.TabIndex = 60;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(301, 401);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(86, 20);
            this.lblCodigo.TabIndex = 61;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(525, 401);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(99, 20);
            this.lblEmpresa.TabIndex = 62;
            this.lblEmpresa.Text = "EMPRESA";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(301, 446);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(73, 20);
            this.lblServico.TabIndex = 63;
            this.lblServico.Text = "VALOR";
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicio.Location = new System.Drawing.Point(525, 446);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(108, 20);
            this.lblDtInicio.TabIndex = 64;
            this.lblDtInicio.Text = "DT.INÍCIO";
            // 
            // lblDtTermino
            // 
            this.lblDtTermino.AutoSize = true;
            this.lblDtTermino.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtTermino.Location = new System.Drawing.Point(764, 446);
            this.lblDtTermino.Name = "lblDtTermino";
            this.lblDtTermino.Size = new System.Drawing.Size(131, 20);
            this.lblDtTermino.TabIndex = 65;
            this.lblDtTermino.Text = "DT.TÉRMINO";
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Location = new System.Drawing.Point(356, 529);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(620, 152);
            this.txtRelatorio.TabIndex = 66;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(301, 485);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(120, 20);
            this.lblDescricao.TabIndex = 68;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(422, 485);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(211, 20);
            this.txtDescricao.TabIndex = 67;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(768, 401);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(108, 20);
            this.lblSituacao.TabIndex = 69;
            this.lblSituacao.Text = "SITUAÇÃO";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Disponível",
            "Em Andamento",
            "Encerrado"});
            this.cmbSituacao.Location = new System.Drawing.Point(880, 401);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(135, 21);
            this.cmbSituacao.TabIndex = 70;
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1036, 768);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtRelatorio);
            this.Controls.Add(this.lblDtTermino);
            this.Controls.Add(this.lblDtInicio);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDtTermino);
            this.Controls.Add(this.txtDtInicio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.cmbPesquisa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblsituação);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblrelatorio);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnvoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.relatório_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menStrip.ResumeLayout(false);
            this.menStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblrelatorio;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblsituação;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnServiços;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menStrip;
        private System.Windows.Forms.ToolStripMenuItem srFulanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSituacaoServico;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.Label lblDtTermino;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnEquipamento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblSituacao;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtDtInicio;
        public System.Windows.Forms.TextBox txtDtTermino;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.ComboBox cmbSituacao;
        public System.Windows.Forms.TextBox txtRelatorio;
    }
}