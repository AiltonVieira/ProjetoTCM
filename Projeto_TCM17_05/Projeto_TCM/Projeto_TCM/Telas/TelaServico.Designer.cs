namespace Projeto_TCM.Telas
{
    partial class TelaServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaServico));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtdataInicio = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.lbltermino = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblempresa = new System.Windows.Forms.Label();
            this.txtdataTermino = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSairSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.menStrip = new System.Windows.Forms.MenuStrip();
            this.srFulanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtcpfCnpj = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescricaoDoServico = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).BeginInit();
            this.menStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.Location = new System.Drawing.Point(841, 703);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(152, 35);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(318, 703);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(152, 35);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnlimpar.Location = new System.Drawing.Point(665, 703);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(152, 35);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtdataInicio
            // 
            this.txtdataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtdataInicio.Location = new System.Drawing.Point(458, 437);
            this.txtdataInicio.Name = "txtdataInicio";
            this.txtdataInicio.Size = new System.Drawing.Size(197, 26);
            this.txtdataInicio.TabIndex = 14;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCep.Location = new System.Drawing.Point(809, 377);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(197, 26);
            this.txtCep.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCidade.Location = new System.Drawing.Point(458, 317);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(197, 26);
            this.txtCidade.TabIndex = 18;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtEndereco.Location = new System.Drawing.Point(458, 377);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(197, 26);
            this.txtEndereco.TabIndex = 19;
            // 
            // txtempresa
            // 
            this.txtempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtempresa.Location = new System.Drawing.Point(458, 257);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(197, 26);
            this.txtempresa.TabIndex = 20;
            // 
            // lbltermino
            // 
            this.lbltermino.AutoSize = true;
            this.lbltermino.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltermino.Location = new System.Drawing.Point(706, 432);
            this.lbltermino.Name = "lbltermino";
            this.lbltermino.Size = new System.Drawing.Size(99, 20);
            this.lbltermino.TabIndex = 22;
            this.lbltermino.Text = "TÉRMINO";
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(334, 437);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(76, 20);
            this.lblinicio.TabIndex = 26;
            this.lblinicio.Text = "INÍCIO";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(740, 377);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(45, 20);
            this.lblcep.TabIndex = 28;
            this.lblcep.Text = "CEP";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(334, 317);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(83, 20);
            this.lblcidade.TabIndex = 29;
            this.lblcidade.Text = "CIDADE";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(334, 377);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(112, 20);
            this.lblEndereco.TabIndex = 30;
            this.lblEndereco.Text = "ENDEREÇO";
            // 
            // lblempresa
            // 
            this.lblempresa.AutoSize = true;
            this.lblempresa.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempresa.Location = new System.Drawing.Point(334, 257);
            this.lblempresa.Name = "lblempresa";
            this.lblempresa.Size = new System.Drawing.Size(99, 20);
            this.lblempresa.TabIndex = 31;
            this.lblempresa.Text = "EMPRESA";
            this.lblempresa.Click += new System.EventHandler(this.lblempresa_Click);
            // 
            // txtdataTermino
            // 
            this.txtdataTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtdataTermino.Location = new System.Drawing.Point(809, 432);
            this.txtdataTermino.Name = "txtdataTermino";
            this.txtdataTermino.Size = new System.Drawing.Size(197, 26);
            this.txtdataTermino.TabIndex = 33;
            // 
            // cmbUf
            // 
            this.cmbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(809, 317);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(124, 28);
            this.cmbUf.TabIndex = 36;
            this.cmbUf.SelectedIndexChanged += new System.EventHandler(this.comboBoxUF_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.picLogoEmpresa);
            this.panel2.Controls.Add(this.menStrip);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 86);
            this.panel2.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-46, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 86);
            this.panel1.TabIndex = 49;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_TCM.Properties.Resources.logofire;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(46, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
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
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(865, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(129, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrocaUsuario,
            this.tsmSairSystem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 20);
            this.toolStripMenuItem1.Text = "Wellingtom Cidade";
            // 
            // tsmTrocaUsuario
            // 
            this.tsmTrocaUsuario.Name = "tsmTrocaUsuario";
            this.tsmTrocaUsuario.Size = new System.Drawing.Size(154, 22);
            this.tsmTrocaUsuario.Text = "Trocar Usuario";
            this.tsmTrocaUsuario.Click += new System.EventHandler(this.tsmTrocaUsuario_Click);
            // 
            // tsmSairSystem
            // 
            this.tsmSairSystem.Name = "tsmSairSystem";
            this.tsmSairSystem.Size = new System.Drawing.Size(154, 22);
            this.tsmSairSystem.Text = "Sair do Sistema";
            this.tsmSairSystem.Click += new System.EventHandler(this.tsmSairSystem_Click);
            // 
            // picLogoEmpresa
            // 
            this.picLogoEmpresa.Image = global::Projeto_TCM.Properties.Resources.logofire;
            this.picLogoEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.picLogoEmpresa.Name = "picLogoEmpresa";
            this.picLogoEmpresa.Size = new System.Drawing.Size(93, 82);
            this.picLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoEmpresa.TabIndex = 48;
            this.picLogoEmpresa.TabStop = false;
            // 
            // menStrip
            // 
            this.menStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srFulanoToolStripMenuItem});
            this.menStrip.Location = new System.Drawing.Point(1284, 14);
            this.menStrip.Name = "menStrip";
            this.menStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menStrip.Size = new System.Drawing.Size(76, 24);
            this.menStrip.TabIndex = 47;
            this.menStrip.Text = "menuStrip1";
            // 
            // srFulanoToolStripMenuItem
            // 
            this.srFulanoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarUsuarioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.srFulanoToolStripMenuItem.Name = "srFulanoToolStripMenuItem";
            this.srFulanoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.srFulanoToolStripMenuItem.Text = "Sr.Fulano";
            // 
            // trocarUsuarioToolStripMenuItem
            // 
            this.trocarUsuarioToolStripMenuItem.Name = "trocarUsuarioToolStripMenuItem";
            this.trocarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.trocarUsuarioToolStripMenuItem.Text = "Trocar Usuario";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            // 
            // timerDataHora
            // 
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "CPF/CNPJ";
            // 
            // txtcpfCnpj
            // 
            this.txtcpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtcpfCnpj.Location = new System.Drawing.Point(809, 257);
            this.txtcpfCnpj.Name = "txtcpfCnpj";
            this.txtcpfCnpj.Size = new System.Drawing.Size(197, 26);
            this.txtcpfCnpj.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnConsulta);
            this.panel3.Controls.Add(this.btnCliente);
            this.panel3.Controls.Add(this.btnEquipamento);
            this.panel3.Controls.Add(this.btnFuncionarios);
            this.panel3.Controls.Add(this.btnRelatorio);
            this.panel3.Controls.Add(this.btnServiços);
            this.panel3.Controls.Add(this.btnInformacoes);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 768);
            this.panel3.TabIndex = 48;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.btnConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsulta.Location = new System.Drawing.Point(1, 273);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(260, 96);
            this.btnConsulta.TabIndex = 23;
            this.btnConsulta.Text = "         Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCliente.Location = new System.Drawing.Point(1, 187);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(260, 84);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "        Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.btnEquipamento.TabIndex = 36;
            this.btnEquipamento.Text = "            Equipamento";
            this.btnEquipamento.UseVisualStyleBackColor = false;
            this.btnEquipamento.Click += new System.EventHandler(this.btnEquipamento_Click);
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
            this.btnFuncionarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFuncionarios.Location = new System.Drawing.Point(1, 86);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(260, 96);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "         Funcionário";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click_1);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 472);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(260, 96);
            this.btnRelatorio.TabIndex = 27;
            this.btnRelatorio.Text = "        Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click_1);
            // 
            // btnServiços
            // 
            this.btnServiços.BackColor = System.Drawing.Color.DarkGray;
            this.btnServiços.FlatAppearance.BorderSize = 0;
            this.btnServiços.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnServiços.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnServiços.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiços.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiços.Image = ((System.Drawing.Image)(resources.GetObject("btnServiços.Image")));
            this.btnServiços.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiços.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnServiços.Location = new System.Drawing.Point(1, 373);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(260, 96);
            this.btnServiços.TabIndex = 1;
            this.btnServiços.Text = "       Serviço";
            this.btnServiços.UseVisualStyleBackColor = false;
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
            this.btnInformacoes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInformacoes.Location = new System.Drawing.Point(0, 672);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(261, 105);
            this.btnInformacoes.TabIndex = 28;
            this.btnInformacoes.Text = "            Informação";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click_1);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(334, 497);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 20);
            this.lblValor.TabIndex = 50;
            this.lblValor.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(458, 497);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 20);
            this.txtValor.TabIndex = 52;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(751, 317);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(34, 20);
            this.lblUf.TabIndex = 53;
            this.lblUf.Text = "UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "SITUAÇÃO";
            // 
            // txtdescricaoDoServico
            // 
            this.txtdescricaoDoServico.Location = new System.Drawing.Point(458, 557);
            this.txtdescricaoDoServico.Name = "txtdescricaoDoServico";
            this.txtdescricaoDoServico.Size = new System.Drawing.Size(197, 20);
            this.txtdescricaoDoServico.TabIndex = 57;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(334, 557);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(120, 20);
            this.lblDescricao.TabIndex = 56;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Disponível",
            "Em Andamento",
            "Encerrado"});
            this.cmbSituacao.Location = new System.Drawing.Point(809, 494);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacao.TabIndex = 58;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.Location = new System.Drawing.Point(491, 703);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 35);
            this.btnAtualizar.TabIndex = 126;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // TelaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1036, 768);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.txtdescricaoDoServico);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtcpfCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.txtdataTermino);
            this.Controls.Add(this.lblempresa);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.lbltermino);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtdataInicio);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnvoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Serviços_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).EndInit();
            this.menStrip.ResumeLayout(false);
            this.menStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lbltermino;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblempresa;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menStrip;
        private System.Windows.Forms.ToolStripMenuItem srFulanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnServiços;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.PictureBox picLogoEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmSairSystem;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnEquipamento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox txtdataInicio;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtempresa;
        public System.Windows.Forms.TextBox txtdataTermino;
        public System.Windows.Forms.ComboBox cmbUf;
        public System.Windows.Forms.TextBox txtcpfCnpj;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtdescricaoDoServico;
        public System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Button btnAtualizar;
    }
}