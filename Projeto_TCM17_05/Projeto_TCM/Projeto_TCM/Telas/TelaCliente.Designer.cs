namespace Projeto_TCM.Telas
{
    partial class TelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtFoneFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtcpfCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfone = new System.Windows.Forms.Label();
            this.chkFisica = new System.Windows.Forms.CheckBox();
            this.chkJuridica = new System.Windows.Forms.CheckBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.btnServiços = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.menStrip = new System.Windows.Forms.MenuStrip();
            this.srFulanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUf = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.Location = new System.Drawing.Point(819, 703);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(152, 35);
            this.btnvoltar.TabIndex = 0;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.retPrincipal_Click);
            // 
            // txtFoneFax
            // 
            this.txtFoneFax.Location = new System.Drawing.Point(797, 457);
            this.txtFoneFax.MaxLength = 11;
            this.txtFoneFax.Name = "txtFoneFax";
            this.txtFoneFax.Size = new System.Drawing.Size(197, 20);
            this.txtFoneFax.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(461, 457);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(797, 407);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(197, 20);
            this.txtCep.TabIndex = 6;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(461, 357);
            this.txtCid.MaxLength = 20;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(197, 20);
            this.txtCid.TabIndex = 7;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(461, 407);
            this.txtEnd.MaxLength = 40;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(197, 20);
            this.txtEnd.TabIndex = 8;
            // 
            // txtcpfCnpj
            // 
            this.txtcpfCnpj.Location = new System.Drawing.Point(797, 307);
            this.txtcpfCnpj.MaxLength = 11;
            this.txtcpfCnpj.Name = "txtcpfCnpj";
            this.txtcpfCnpj.Size = new System.Drawing.Size(197, 20);
            this.txtcpfCnpj.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(461, 307);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(372, 307);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(65, 20);
            this.lblnome.TabIndex = 13;
            this.lblnome.Text = "NOME";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(736, 307);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(44, 20);
            this.lblcpf.TabIndex = 14;
            this.lblcpf.Text = "CPF";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(343, 407);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(112, 20);
            this.lblend.TabIndex = 15;
            this.lblend.Text = "ENDEREÇO";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(363, 357);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(83, 20);
            this.lblCid.TabIndex = 16;
            this.lblCid.Text = "CIDADE";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(735, 407);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(45, 20);
            this.lblcep.TabIndex = 17;
            this.lblcep.Text = "CEP";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(369, 457);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(78, 20);
            this.lblemail.TabIndex = 18;
            this.lblemail.Text = "E-MAIL";
            // 
            // lblfone
            // 
            this.lblfone.AutoSize = true;
            this.lblfone.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfone.Location = new System.Drawing.Point(723, 457);
            this.lblfone.Name = "lblfone";
            this.lblfone.Size = new System.Drawing.Size(60, 20);
            this.lblfone.TabIndex = 19;
            this.lblfone.Text = "FONE";
            // 
            // chkFisica
            // 
            this.chkFisica.AutoSize = true;
            this.chkFisica.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFisica.Location = new System.Drawing.Point(533, 219);
            this.chkFisica.Name = "chkFisica";
            this.chkFisica.Size = new System.Drawing.Size(94, 24);
            this.chkFisica.TabIndex = 2;
            this.chkFisica.Text = "FÍSICA";
            this.chkFisica.UseVisualStyleBackColor = true;
            this.chkFisica.CheckedChanged += new System.EventHandler(this.chnFisica_CheckedChanged);
            // 
            // chkJuridica
            // 
            this.chkJuridica.AutoSize = true;
            this.chkJuridica.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJuridica.Location = new System.Drawing.Point(668, 219);
            this.chkJuridica.Name = "chkJuridica";
            this.chkJuridica.Size = new System.Drawing.Size(121, 24);
            this.chkJuridica.TabIndex = 3;
            this.chkJuridica.Text = "JURÍDICA";
            this.chkJuridica.UseVisualStyleBackColor = true;
            this.chkJuridica.CheckedChanged += new System.EventHandler(this.chnJuridica_CheckedChanged);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncadastrar.Location = new System.Drawing.Point(318, 703);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(137, 35);
            this.btncadastrar.TabIndex = 25;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnlimpar.Location = new System.Drawing.Point(649, 703);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(152, 35);
            this.btnlimpar.TabIndex = 26;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // cboUf
            // 
            this.cboUf.FormattingEnabled = true;
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
            this.cboUf.Location = new System.Drawing.Point(797, 357);
            this.cboUf.MaxLength = 2;
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(87, 21);
            this.cboUf.TabIndex = 27;
            this.cboUf.SelectedIndexChanged += new System.EventHandler(this.cboUF_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnEquipamento);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.btnInformacoes);
            this.panel1.Controls.Add(this.btnServiços);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 768);
            this.panel1.TabIndex = 40;
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
            this.btnEquipamento.TabIndex = 36;
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
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "         Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DarkGray;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientes.Location = new System.Drawing.Point(1, 187);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(260, 84);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "        Cliente";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
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
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "         Funcionário";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click_1);
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
            this.btnInformacoes.TabIndex = 34;
            this.btnInformacoes.Text = "            Informação";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
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
            this.btnServiços.TabIndex = 30;
            this.btnServiços.Text = "       Serviço";
            this.btnServiços.UseVisualStyleBackColor = true;
            this.btnServiços.Click += new System.EventHandler(this.btnServiços_Click_1);
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
            this.btnRelatorio.Location = new System.Drawing.Point(0, 472);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(260, 96);
            this.btnRelatorio.TabIndex = 33;
            this.btnRelatorio.Text = "        Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(302, 507);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(154, 20);
            this.lblComplemento.TabIndex = 43;
            this.lblComplemento.Text = "COMPLEMENTO";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(461, 507);
            this.txtComplemento.MaxLength = 5;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(197, 20);
            this.txtComplemento.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-46, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 86);
            this.panel2.TabIndex = 100;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Verdana", 13.75F, System.Drawing.FontStyle.Italic);
            this.lblData.Location = new System.Drawing.Point(945, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 23);
            this.lblData.TabIndex = 124;
            this.lblData.Text = "Data:";
            // 
            // menStrip
            // 
            this.menStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srFulanoToolStripMenuItem});
            this.menStrip.Location = new System.Drawing.Point(819, 35);
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
            this.srFulanoToolStripMenuItem.Click += new System.EventHandler(this.srFulanoToolStripMenuItem_Click);
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
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Verdana", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(746, 357);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(34, 20);
            this.lblUf.TabIndex = 101;
            this.lblUf.Text = "UF";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.Location = new System.Drawing.Point(475, 703);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 35);
            this.btnAtualizar.TabIndex = 125;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1036, 768);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.menStrip);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.cboUf);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.chkJuridica);
            this.Controls.Add(this.chkFisica);
            this.Controls.Add(this.lblfone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtcpfCnpj);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFoneFax);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da pessoa Física/Jurídica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menStrip.ResumeLayout(false);
            this.menStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblfone;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblComplemento;
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
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtFoneFax;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.TextBox txtCid;
        public System.Windows.Forms.TextBox txtEnd;
        public System.Windows.Forms.TextBox txtcpfCnpj;
        public System.Windows.Forms.ComboBox cboUf;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.CheckBox chkFisica;
        public System.Windows.Forms.CheckBox chkJuridica;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Timer timer1;
    }
}