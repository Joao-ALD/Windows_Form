namespace Projeto_8.br.com.projeto.VIEW
{
    partial class FormClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_cadastroClientes = new System.Windows.Forms.Label();
            this.tabControl_Clientes = new System.Windows.Forms.TabControl();
            this.tabPage_DadosPessoais = new System.Windows.Forms.TabPage();
            this.comboBox_UF = new System.Windows.Forms.ComboBox();
            this.label_uf = new System.Windows.Forms.Label();
            this.textBox_complemento = new System.Windows.Forms.TextBox();
            this.label_complemento = new System.Windows.Forms.Label();
            this.maskedTextBox_celular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_CEP = new System.Windows.Forms.MaskedTextBox();
            this.textBox_cidade = new System.Windows.Forms.TextBox();
            this.label_cidade = new System.Windows.Forms.Label();
            this.maskedTextBox_rg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.textBox_bairro = new System.Windows.Forms.TextBox();
            this.label_bairro = new System.Windows.Forms.Label();
            this.label_cep = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.textBox_endereco = new System.Windows.Forms.TextBox();
            this.label_endereco = new System.Windows.Forms.Label();
            this.label_celular = new System.Windows.Forms.Label();
            this.label_telefone = new System.Windows.Forms.Label();
            this.label_cpf = new System.Windows.Forms.Label();
            this.label_rg = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.label_codigo = new System.Windows.Forms.Label();
            this.tabPage_consulta = new System.Windows.Forms.TabPage();
            this.button_ConsultaPesquisar = new System.Windows.Forms.Button();
            this.dataGridView_Consulta = new System.Windows.Forms.DataGridView();
            this.textBox_ConsultaNome = new System.Windows.Forms.TextBox();
            this.label_ConsultaNome = new System.Windows.Forms.Label();
            this.button_novo = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl_Clientes.SuspendLayout();
            this.tabPage_DadosPessoais.SuspendLayout();
            this.tabPage_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label_cadastroClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 100);
            this.panel1.TabIndex = 0;
            // 
            // label_cadastroClientes
            // 
            this.label_cadastroClientes.AutoSize = true;
            this.label_cadastroClientes.Font = new System.Drawing.Font("Century", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cadastroClientes.ForeColor = System.Drawing.Color.White;
            this.label_cadastroClientes.Location = new System.Drawing.Point(23, 35);
            this.label_cadastroClientes.Name = "label_cadastroClientes";
            this.label_cadastroClientes.Size = new System.Drawing.Size(222, 25);
            this.label_cadastroClientes.TabIndex = 0;
            this.label_cadastroClientes.Text = "Cadastro De Clientes";
            // 
            // tabControl_Clientes
            // 
            this.tabControl_Clientes.Controls.Add(this.tabPage_DadosPessoais);
            this.tabControl_Clientes.Controls.Add(this.tabPage_consulta);
            this.tabControl_Clientes.Location = new System.Drawing.Point(12, 106);
            this.tabControl_Clientes.Name = "tabControl_Clientes";
            this.tabControl_Clientes.SelectedIndex = 0;
            this.tabControl_Clientes.Size = new System.Drawing.Size(441, 311);
            this.tabControl_Clientes.TabIndex = 1;
            // 
            // tabPage_DadosPessoais
            // 
            this.tabPage_DadosPessoais.Controls.Add(this.comboBox_UF);
            this.tabPage_DadosPessoais.Controls.Add(this.label_uf);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_complemento);
            this.tabPage_DadosPessoais.Controls.Add(this.label_complemento);
            this.tabPage_DadosPessoais.Controls.Add(this.maskedTextBox_celular);
            this.tabPage_DadosPessoais.Controls.Add(this.maskedTextBox_CEP);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_cidade);
            this.tabPage_DadosPessoais.Controls.Add(this.label_cidade);
            this.tabPage_DadosPessoais.Controls.Add(this.maskedTextBox_rg);
            this.tabPage_DadosPessoais.Controls.Add(this.maskedTextBox_telefone);
            this.tabPage_DadosPessoais.Controls.Add(this.maskedTextBox_cpf);
            this.tabPage_DadosPessoais.Controls.Add(this.button_pesquisar);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_bairro);
            this.tabPage_DadosPessoais.Controls.Add(this.label_bairro);
            this.tabPage_DadosPessoais.Controls.Add(this.label_cep);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_numero);
            this.tabPage_DadosPessoais.Controls.Add(this.label_numero);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_endereco);
            this.tabPage_DadosPessoais.Controls.Add(this.label_endereco);
            this.tabPage_DadosPessoais.Controls.Add(this.label_celular);
            this.tabPage_DadosPessoais.Controls.Add(this.label_telefone);
            this.tabPage_DadosPessoais.Controls.Add(this.label_cpf);
            this.tabPage_DadosPessoais.Controls.Add(this.label_rg);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_email);
            this.tabPage_DadosPessoais.Controls.Add(this.label_email);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_nome);
            this.tabPage_DadosPessoais.Controls.Add(this.label_nome);
            this.tabPage_DadosPessoais.Controls.Add(this.textBox_codigo);
            this.tabPage_DadosPessoais.Controls.Add(this.label_codigo);
            this.tabPage_DadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DadosPessoais.Name = "tabPage_DadosPessoais";
            this.tabPage_DadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DadosPessoais.Size = new System.Drawing.Size(433, 285);
            this.tabPage_DadosPessoais.TabIndex = 0;
            this.tabPage_DadosPessoais.Text = "Dados Pessoais";
            this.tabPage_DadosPessoais.UseVisualStyleBackColor = true;
            // 
            // comboBox_UF
            // 
            this.comboBox_UF.FormattingEnabled = true;
            this.comboBox_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox_UF.Location = new System.Drawing.Point(91, 256);
            this.comboBox_UF.Name = "comboBox_UF";
            this.comboBox_UF.Size = new System.Drawing.Size(109, 21);
            this.comboBox_UF.TabIndex = 33;
            // 
            // label_uf
            // 
            this.label_uf.AutoSize = true;
            this.label_uf.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_uf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_uf.Location = new System.Drawing.Point(10, 257);
            this.label_uf.Name = "label_uf";
            this.label_uf.Size = new System.Drawing.Size(35, 17);
            this.label_uf.TabIndex = 32;
            this.label_uf.Text = "UF:";
            // 
            // textBox_complemento
            // 
            this.textBox_complemento.Location = new System.Drawing.Point(127, 173);
            this.textBox_complemento.Name = "textBox_complemento";
            this.textBox_complemento.Size = new System.Drawing.Size(300, 20);
            this.textBox_complemento.TabIndex = 31;
            // 
            // label_complemento
            // 
            this.label_complemento.AutoSize = true;
            this.label_complemento.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_complemento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_complemento.Location = new System.Drawing.Point(9, 174);
            this.label_complemento.Name = "label_complemento";
            this.label_complemento.Size = new System.Drawing.Size(112, 17);
            this.label_complemento.TabIndex = 30;
            this.label_complemento.Text = "Complemento:";
            // 
            // maskedTextBox_celular
            // 
            this.maskedTextBox_celular.Location = new System.Drawing.Point(91, 121);
            this.maskedTextBox_celular.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_celular.Name = "maskedTextBox_celular";
            this.maskedTextBox_celular.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox_celular.TabIndex = 29;
            // 
            // maskedTextBox_CEP
            // 
            this.maskedTextBox_CEP.Location = new System.Drawing.Point(91, 227);
            this.maskedTextBox_CEP.Mask = "99999-999";
            this.maskedTextBox_CEP.Name = "maskedTextBox_CEP";
            this.maskedTextBox_CEP.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox_CEP.TabIndex = 28;
            // 
            // textBox_cidade
            // 
            this.textBox_cidade.Location = new System.Drawing.Point(318, 230);
            this.textBox_cidade.Name = "textBox_cidade";
            this.textBox_cidade.Size = new System.Drawing.Size(109, 20);
            this.textBox_cidade.TabIndex = 27;
            // 
            // label_cidade
            // 
            this.label_cidade.AutoSize = true;
            this.label_cidade.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cidade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_cidade.Location = new System.Drawing.Point(248, 231);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(64, 17);
            this.label_cidade.TabIndex = 26;
            this.label_cidade.Text = "Cidade:";
            // 
            // maskedTextBox_rg
            // 
            this.maskedTextBox_rg.Location = new System.Drawing.Point(91, 94);
            this.maskedTextBox_rg.Mask = "99,999,999-9";
            this.maskedTextBox_rg.Name = "maskedTextBox_rg";
            this.maskedTextBox_rg.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox_rg.TabIndex = 25;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(318, 119);
            this.maskedTextBox_telefone.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox_telefone.TabIndex = 24;
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(318, 93);
            this.maskedTextBox_cpf.Mask = "999,999,999-99";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox_cpf.TabIndex = 23;
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_pesquisar.Font = new System.Drawing.Font("Century", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.ForeColor = System.Drawing.Color.White;
            this.button_pesquisar.Location = new System.Drawing.Point(308, 255);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(119, 27);
            this.button_pesquisar.TabIndex = 22;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            // 
            // textBox_bairro
            // 
            this.textBox_bairro.Location = new System.Drawing.Point(318, 201);
            this.textBox_bairro.Name = "textBox_bairro";
            this.textBox_bairro.Size = new System.Drawing.Size(109, 20);
            this.textBox_bairro.TabIndex = 21;
            // 
            // label_bairro
            // 
            this.label_bairro.AutoSize = true;
            this.label_bairro.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_bairro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_bairro.Location = new System.Drawing.Point(248, 202);
            this.label_bairro.Name = "label_bairro";
            this.label_bairro.Size = new System.Drawing.Size(60, 17);
            this.label_bairro.TabIndex = 20;
            this.label_bairro.Text = "Bairro:";
            // 
            // label_cep
            // 
            this.label_cep.AutoSize = true;
            this.label_cep.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cep.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_cep.Location = new System.Drawing.Point(9, 227);
            this.label_cep.Name = "label_cep";
            this.label_cep.Size = new System.Drawing.Size(45, 17);
            this.label_cep.TabIndex = 18;
            this.label_cep.Text = "CEP:";
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(91, 199);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(109, 20);
            this.textBox_numero.TabIndex = 17;
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_numero.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_numero.Location = new System.Drawing.Point(9, 199);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(32, 17);
            this.label_numero.TabIndex = 16;
            this.label_numero.Text = "N°:";
            // 
            // textBox_endereco
            // 
            this.textBox_endereco.Location = new System.Drawing.Point(91, 147);
            this.textBox_endereco.Name = "textBox_endereco";
            this.textBox_endereco.Size = new System.Drawing.Size(336, 20);
            this.textBox_endereco.TabIndex = 15;
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_endereco.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_endereco.Location = new System.Drawing.Point(9, 147);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(81, 17);
            this.label_endereco.TabIndex = 14;
            this.label_endereco.Text = "Endereço:";
            this.label_endereco.Click += new System.EventHandler(this.label8_Click);
            // 
            // label_celular
            // 
            this.label_celular.AutoSize = true;
            this.label_celular.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_celular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_celular.Location = new System.Drawing.Point(9, 120);
            this.label_celular.Name = "label_celular";
            this.label_celular.Size = new System.Drawing.Size(68, 17);
            this.label_celular.TabIndex = 12;
            this.label_celular.Text = "Celular:";
            this.label_celular.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_telefone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_telefone.Location = new System.Drawing.Point(236, 120);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(76, 17);
            this.label_telefone.TabIndex = 10;
            this.label_telefone.Text = "Telefone:";
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cpf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_cpf.Location = new System.Drawing.Point(263, 94);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(44, 17);
            this.label_cpf.TabIndex = 8;
            this.label_cpf.Text = "CPF:";
            this.label_cpf.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_rg
            // 
            this.label_rg.AutoSize = true;
            this.label_rg.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_rg.Location = new System.Drawing.Point(9, 94);
            this.label_rg.Name = "label_rg";
            this.label_rg.Size = new System.Drawing.Size(36, 17);
            this.label_rg.TabIndex = 6;
            this.label_rg.Text = "RG:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(91, 66);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(336, 20);
            this.textBox_email.TabIndex = 5;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_email.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_email.Location = new System.Drawing.Point(9, 67);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(56, 17);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(91, 37);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(336, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_nome.Location = new System.Drawing.Point(9, 38);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(54, 17);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome:";
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(91, 11);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(81, 20);
            this.textBox_codigo.TabIndex = 1;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_codigo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_codigo.Location = new System.Drawing.Point(9, 12);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(58, 17);
            this.label_codigo.TabIndex = 0;
            this.label_codigo.Text = "Código";
            // 
            // tabPage_consulta
            // 
            this.tabPage_consulta.Controls.Add(this.button_ConsultaPesquisar);
            this.tabPage_consulta.Controls.Add(this.dataGridView_Consulta);
            this.tabPage_consulta.Controls.Add(this.textBox_ConsultaNome);
            this.tabPage_consulta.Controls.Add(this.label_ConsultaNome);
            this.tabPage_consulta.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consulta.Name = "tabPage_consulta";
            this.tabPage_consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consulta.Size = new System.Drawing.Size(433, 285);
            this.tabPage_consulta.TabIndex = 1;
            this.tabPage_consulta.Text = "Consulta";
            this.tabPage_consulta.UseVisualStyleBackColor = true;
            // 
            // button_ConsultaPesquisar
            // 
            this.button_ConsultaPesquisar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_ConsultaPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ConsultaPesquisar.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConsultaPesquisar.ForeColor = System.Drawing.Color.White;
            this.button_ConsultaPesquisar.Location = new System.Drawing.Point(308, 6);
            this.button_ConsultaPesquisar.Name = "button_ConsultaPesquisar";
            this.button_ConsultaPesquisar.Size = new System.Drawing.Size(119, 23);
            this.button_ConsultaPesquisar.TabIndex = 23;
            this.button_ConsultaPesquisar.Text = "Pesquisar";
            this.button_ConsultaPesquisar.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Consulta
            // 
            this.dataGridView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consulta.Location = new System.Drawing.Point(6, 35);
            this.dataGridView_Consulta.Name = "dataGridView_Consulta";
            this.dataGridView_Consulta.Size = new System.Drawing.Size(421, 244);
            this.dataGridView_Consulta.TabIndex = 7;
            this.dataGridView_Consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Consulta_CellClick);
            // 
            // textBox_ConsultaNome
            // 
            this.textBox_ConsultaNome.Location = new System.Drawing.Point(69, 9);
            this.textBox_ConsultaNome.Name = "textBox_ConsultaNome";
            this.textBox_ConsultaNome.Size = new System.Drawing.Size(233, 20);
            this.textBox_ConsultaNome.TabIndex = 6;
            // 
            // label_ConsultaNome
            // 
            this.label_ConsultaNome.AutoSize = true;
            this.label_ConsultaNome.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ConsultaNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_ConsultaNome.Location = new System.Drawing.Point(9, 10);
            this.label_ConsultaNome.Name = "label_ConsultaNome";
            this.label_ConsultaNome.Size = new System.Drawing.Size(54, 17);
            this.label_ConsultaNome.TabIndex = 5;
            this.label_ConsultaNome.Text = "Nome:";
            // 
            // button_novo
            // 
            this.button_novo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_novo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_novo.ForeColor = System.Drawing.Color.White;
            this.button_novo.Location = new System.Drawing.Point(13, 421);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(92, 42);
            this.button_novo.TabIndex = 2;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = false;
            this.button_novo.Click += new System.EventHandler(this.button_novo_Click);
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_editar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editar.ForeColor = System.Drawing.Color.White;
            this.button_editar.Location = new System.Drawing.Point(361, 421);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(92, 42);
            this.button_editar.TabIndex = 3;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.UseWaitCursor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_excluir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.White;
            this.button_excluir.Location = new System.Drawing.Point(245, 421);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(92, 42);
            this.button_excluir.TabIndex = 4;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_salvar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.White;
            this.button_salvar.Location = new System.Drawing.Point(129, 421);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(92, 42);
            this.button_salvar.TabIndex = 5;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 468);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.tabControl_Clientes);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_Clientes.ResumeLayout(false);
            this.tabPage_DadosPessoais.ResumeLayout(false);
            this.tabPage_DadosPessoais.PerformLayout();
            this.tabPage_consulta.ResumeLayout(false);
            this.tabPage_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_cadastroClientes;
        private System.Windows.Forms.TabControl tabControl_Clientes;
        private System.Windows.Forms.TabPage tabPage_DadosPessoais;
        private System.Windows.Forms.TabPage tabPage_consulta;
        private System.Windows.Forms.Label label_rg;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_cep;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox textBox_endereco;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.Label label_celular;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.TextBox textBox_bairro;
        private System.Windows.Forms.Label label_bairro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_rg;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CEP;
        private System.Windows.Forms.TextBox textBox_cidade;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.TextBox textBox_complemento;
        private System.Windows.Forms.Label label_complemento;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_celular;
        private System.Windows.Forms.ComboBox comboBox_UF;
        private System.Windows.Forms.Label label_uf;
        private System.Windows.Forms.Button button_ConsultaPesquisar;
        private System.Windows.Forms.DataGridView dataGridView_Consulta;
        private System.Windows.Forms.TextBox textBox_ConsultaNome;
        private System.Windows.Forms.Label label_ConsultaNome;
    }
}