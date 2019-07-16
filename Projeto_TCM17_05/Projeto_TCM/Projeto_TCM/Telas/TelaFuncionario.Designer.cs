namespace Projeto_TCM.Telas
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.lblcadUsuTitle = new System.Windows.Forms.Label();
            this.txtSenhaNovamente = new System.Windows.Forms.TextBox();
            this.lblEscolhaNovamente = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEscolhaSenha = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtcpfCnpj = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblfone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menStrip = new System.Windows.Forms.MenuStrip();
            this.srFulanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcadUsuTitle
            // 
            this.lblcadUsuTitle.AutoSize = true;
            this.lblcadUsuTitle.Location = new System.Drawing.Point(520, 60);
            this.lblcadUsuTitle.Name = "lblcadUsuTitle";
            this.lblcadUsuTitle.Size = new System.Drawing.Size(177, 13);
            this.lblcadUsuTitle.TabIndex = 96;
            this.lblcadUsuTitle.Text = "Dados para cadastro de Login";
            // 
            // txtSenhaNovamente
            // 
            this.txtSenhaNovamente.Location = new System.Drawing.Point(820, 574);
            this.txtSenhaNovamente.Name = "txtSenhaNovamente";
            this.txtSenhaNovamente.Size = new System.Drawing.Size(197, 21);
            this.txtSenhaNovamente.TabIndex = 95;
            this.txtSenhaNovamente.TextChanged += new System.EventHandler(this.txtSenhaNovamente_TextChanged);
            // 
            // lblEscolhaNovamente
            // 
            this.lblEscolhaNovamente.AutoSize = true;
            this.lblEscolhaNovamente.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaNovamente.Location = new System.Drawing.Point(612, 574);
            this.lblEscolhaNovamente.Name = "lblEscolhaNovamente";
            this.lblEscolhaNovamente.Size = new System.Drawing.Size(200, 20);
            this.lblEscolhaNovamente.TabIndex = 94;
            this.lblEscolhaNovamente.Text = "CONFIRME A SENHA";
            this.lblEscolhaNovamente.Click += new System.EventHandler(this.lblEscolhaNovamente_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(382, 574);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(197, 21);
            this.txtSenha.TabIndex = 93;
            // 
            // lblEscolhaSenha
            // 
            this.lblEscolhaSenha.AutoSize = true;
            this.lblEscolhaSenha.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaSenha.Location = new System.Drawing.Point(289, 574);
            this.lblEscolhaSenha.Name = "lblEscolhaSenha";
            this.lblEscolhaSenha.Size = new System.Drawing.Size(74, 20);
            this.lblEscolhaSenha.TabIndex = 92;
            this.lblEscolhaSenha.Text = "SENHA";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(761, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 35);
            this.btnEditar.TabIndex = 88;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnlimpar.Location = new System.Drawing.Point(665, 686);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(152, 35);
            this.btnlimpar.TabIndex = 86;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.Location = new System.Drawing.Point(306, 686);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(152, 35);
            this.btnCadastrar.TabIndex = 85;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(820, 524);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(116, 21);
            this.txtFone.TabIndex = 83;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(382, 474);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(197, 21);
            this.txtEnd.TabIndex = 82;
            // 
            // txtcpfCnpj
            // 
            this.txtcpfCnpj.Location = new System.Drawing.Point(820, 372);
            this.txtcpfCnpj.Name = "txtcpfCnpj";
            this.txtcpfCnpj.Size = new System.Drawing.Size(197, 21);
            this.txtcpfCnpj.TabIndex = 81;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(382, 524);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 21);
            this.txtEmail.TabIndex = 80;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(820, 474);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(197, 21);
            this.txtCep.TabIndex = 79;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(382, 424);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(197, 21);
            this.txtCid.TabIndex = 78;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(382, 374);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 21);
            this.txtNome.TabIndex = 77;
            // 
            // lblfone
            // 
            this.lblfone.AutoSize = true;
            this.lblfone.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfone.Location = new System.Drawing.Point(746, 524);
            this.lblfone.Name = "lblfone";
            this.lblfone.Size = new System.Drawing.Size(60, 20);
            this.lblfone.TabIndex = 76;
            this.lblfone.Text = "FONE";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(290, 524);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 20);
            this.lblemail.TabIndex = 75;
            this.lblemail.Text = "E-MAIL";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(757, 474);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(45, 20);
            this.lblcep.TabIndex = 74;
            this.lblcep.Text = "CEP";
            this.lblcep.Click += new System.EventHandler(this.lblcep_Click);
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(284, 424);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(83, 20);
            this.lblcidade.TabIndex = 73;
            this.lblcidade.Text = "CIDADE";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(264, 474);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(112, 20);
            this.lblend.TabIndex = 72;
            this.lblend.Text = "ENDEREÇO";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnpj.Location = new System.Drawing.Point(757, 372);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(44, 20);
            this.lblcnpj.TabIndex = 71;
            this.lblcnpj.Text = "CPF";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(293, 374);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(65, 20);
            this.lblnome.TabIndex = 70;
            this.lblnome.Text = "NOME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnEquipamento);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnServiços);
            this.panel1.Controls.Add(this.btnInformacoes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 768);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnEquipamento.TabIndex = 41;
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
            this.btnConsulta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
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
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
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
            this.btnFuncionarios.BackColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.BackgroundImage")));
            this.btnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFuncionarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFuncionarios.Location = new System.Drawing.Point(1, 86);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(260, 96);
            this.btnFuncionarios.TabIndex = 37;
            this.btnFuncionarios.Text = "         Funcionário";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
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
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
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
            this.btnServiços.BackColor = System.Drawing.Color.Transparent;
            this.btnServiços.FlatAppearance.BorderSize = 0;
            this.btnServiços.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnServiços.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnServiços.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiços.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiços.ForeColor = System.Drawing.Color.White;
            this.btnServiços.Image = ((System.Drawing.Image)(resources.GetObject("btnServiços.Image")));
            this.btnServiços.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiços.Location = new System.Drawing.Point(1, 373);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(260, 96);
            this.btnServiços.TabIndex = 36;
            this.btnServiços.Text = "       Serviço";
            this.btnServiços.UseVisualStyleBackColor = false;
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
            this.btnInformacoes.ForeColor = System.Drawing.Color.White;
            this.btnInformacoes.Location = new System.Drawing.Point(0, 672);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(261, 105);
            this.btnInformacoes.TabIndex = 40;
            this.btnInformacoes.Text = "            Informação";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.Location = new System.Drawing.Point(844, 686);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(152, 35);
            this.btnvoltar.TabIndex = 97;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menStrip);
            this.panel2.Location = new System.Drawing.Point(-46, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1596, 86);
            this.panel2.TabIndex = 98;
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
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // menStrip
            // 
            this.menStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srFulanoToolStripMenuItem});
            this.menStrip.Location = new System.Drawing.Point(864, 35);
            this.menStrip.Name = "menStrip";
            this.menStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menStrip.Size = new System.Drawing.Size(130, 24);
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
            // cboUf
            // 
            this.cboUf.FormattingEnabled = true;
            this.cboUf.ItemHeight = 13;
            this.cboUf.Items.AddRange(new object[] {
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
            this.cboUf.Location = new System.Drawing.Point(820, 423);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(87, 21);
            this.cboUf.TabIndex = 99;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(768, 423);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(34, 20);
            this.lblUf.TabIndex = 100;
            this.lblUf.Text = "UF";
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(539, 110);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(197, 182);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 87;
            this.picUsuario.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.Location = new System.Drawing.Point(484, 686);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 35);
            this.btnAtualizar.TabIndex = 126;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1036, 733);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.cboUf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lblcadUsuTitle);
            this.Controls.Add(this.txtSenhaNovamente);
            this.Controls.Add(this.lblEscolhaNovamente);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEscolhaSenha);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtcpfCnpj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblfone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblcnpj);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaFuncionario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Do Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.funcionarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menStrip.ResumeLayout(false);
            this.menStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcadUsuTitle;
        private System.Windows.Forms.Label lblEscolhaNovamente;
        private System.Windows.Forms.Label lblEscolhaSenha;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblfone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnvoltar;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnEquipamento;
        public System.Windows.Forms.TextBox txtSenhaNovamente;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtFone;
        public System.Windows.Forms.TextBox txtEnd;
        public System.Windows.Forms.TextBox txtcpfCnpj;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.TextBox txtCid;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.ComboBox cboUf;
        public System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Timer timer1;
    }
}