namespace projeto_6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nome = new System.Windows.Forms.Label();
            this.label_telefone = new System.Windows.Forms.Label();
            this.label_estadoCivil = new System.Windows.Forms.Label();
            this.label_dataNascimento = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.dateTimePicker_nascimento = new System.Windows.Forms.DateTimePicker();
            this.comboBox_estadoCivil = new System.Windows.Forms.ComboBox();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.radioButton_outros = new System.Windows.Forms.RadioButton();
            this.radioButton_feminino = new System.Windows.Forms.RadioButton();
            this.radioButton_masculino = new System.Windows.Forms.RadioButton();
            this.button_cadastrarAlterar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.listBox_lista = new System.Windows.Forms.ListBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_casa = new System.Windows.Forms.CheckBox();
            this.checkBox_veiculo = new System.Windows.Forms.CheckBox();
            this.dataGridView_pessoa = new System.Windows.Forms.DataGridView();
            this.groupBox_sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(20, 18);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(38, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(22, 103);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(52, 13);
            this.label_telefone.TabIndex = 1;
            this.label_telefone.Text = "Telefone:";
            // 
            // label_estadoCivil
            // 
            this.label_estadoCivil.AutoSize = true;
            this.label_estadoCivil.Location = new System.Drawing.Point(20, 73);
            this.label_estadoCivil.Name = "label_estadoCivil";
            this.label_estadoCivil.Size = new System.Drawing.Size(65, 13);
            this.label_estadoCivil.TabIndex = 2;
            this.label_estadoCivil.Text = "Estado Civil:";
            // 
            // label_dataNascimento
            // 
            this.label_dataNascimento.AutoSize = true;
            this.label_dataNascimento.Location = new System.Drawing.Point(20, 45);
            this.label_dataNascimento.Name = "label_dataNascimento";
            this.label_dataNascimento.Size = new System.Drawing.Size(107, 13);
            this.label_dataNascimento.TabIndex = 3;
            this.label_dataNascimento.Text = "Data de Nascimento:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(64, 15);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(269, 20);
            this.textBox_nome.TabIndex = 4;
            // 
            // dateTimePicker_nascimento
            // 
            this.dateTimePicker_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_nascimento.Location = new System.Drawing.Point(133, 41);
            this.dateTimePicker_nascimento.Name = "dateTimePicker_nascimento";
            this.dateTimePicker_nascimento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_nascimento.TabIndex = 7;
            // 
            // comboBox_estadoCivil
            // 
            this.comboBox_estadoCivil.FormattingEnabled = true;
            this.comboBox_estadoCivil.Location = new System.Drawing.Point(91, 70);
            this.comboBox_estadoCivil.Name = "comboBox_estadoCivil";
            this.comboBox_estadoCivil.Size = new System.Drawing.Size(242, 21);
            this.comboBox_estadoCivil.TabIndex = 8;
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radioButton_outros);
            this.groupBox_sexo.Controls.Add(this.radioButton_feminino);
            this.groupBox_sexo.Controls.Add(this.radioButton_masculino);
            this.groupBox_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_sexo.Location = new System.Drawing.Point(23, 153);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(303, 68);
            this.groupBox_sexo.TabIndex = 9;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radioButton_outros
            // 
            this.radioButton_outros.AutoSize = true;
            this.radioButton_outros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_outros.Location = new System.Drawing.Point(199, 30);
            this.radioButton_outros.Name = "radioButton_outros";
            this.radioButton_outros.Size = new System.Drawing.Size(62, 17);
            this.radioButton_outros.TabIndex = 22;
            this.radioButton_outros.TabStop = true;
            this.radioButton_outros.Text = "Outros";
            this.radioButton_outros.UseVisualStyleBackColor = true;
            // 
            // radioButton_feminino
            // 
            this.radioButton_feminino.AutoSize = true;
            this.radioButton_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_feminino.Location = new System.Drawing.Point(111, 30);
            this.radioButton_feminino.Name = "radioButton_feminino";
            this.radioButton_feminino.Size = new System.Drawing.Size(75, 17);
            this.radioButton_feminino.TabIndex = 21;
            this.radioButton_feminino.TabStop = true;
            this.radioButton_feminino.Text = "Feminino";
            this.radioButton_feminino.UseVisualStyleBackColor = true;
            // 
            // radioButton_masculino
            // 
            this.radioButton_masculino.AutoSize = true;
            this.radioButton_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_masculino.Location = new System.Drawing.Point(22, 30);
            this.radioButton_masculino.Name = "radioButton_masculino";
            this.radioButton_masculino.Size = new System.Drawing.Size(82, 17);
            this.radioButton_masculino.TabIndex = 20;
            this.radioButton_masculino.TabStop = true;
            this.radioButton_masculino.Text = "Masculino";
            this.radioButton_masculino.UseVisualStyleBackColor = true;
            // 
            // button_cadastrarAlterar
            // 
            this.button_cadastrarAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrarAlterar.Location = new System.Drawing.Point(25, 230);
            this.button_cadastrarAlterar.Name = "button_cadastrarAlterar";
            this.button_cadastrarAlterar.Size = new System.Drawing.Size(139, 35);
            this.button_cadastrarAlterar.TabIndex = 13;
            this.button_cadastrarAlterar.Text = "Cadastrar | Alterar";
            this.button_cadastrarAlterar.UseVisualStyleBackColor = true;
            this.button_cadastrarAlterar.Click += new System.EventHandler(this.button_cadastrarAlterar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(170, 230);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 35);
            this.button_excluir.TabIndex = 14;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(251, 230);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 35);
            this.button_limpar.TabIndex = 15;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // listBox_lista
            // 
            this.listBox_lista.FormattingEnabled = true;
            this.listBox_lista.Location = new System.Drawing.Point(25, 274);
            this.listBox_lista.Name = "listBox_lista";
            this.listBox_lista.Size = new System.Drawing.Size(301, 95);
            this.listBox_lista.TabIndex = 16;
            this.listBox_lista.DoubleClick += new System.EventHandler(this.listBox_lista_DoubleClick);
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(80, 100);
            this.maskedTextBox_telefone.Mask = "(00) 9 9999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(253, 20);
            this.maskedTextBox_telefone.TabIndex = 17;
            // 
            // checkBox_casa
            // 
            this.checkBox_casa.AutoSize = true;
            this.checkBox_casa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_casa.Location = new System.Drawing.Point(26, 131);
            this.checkBox_casa.Name = "checkBox_casa";
            this.checkBox_casa.Size = new System.Drawing.Size(135, 17);
            this.checkBox_casa.TabIndex = 23;
            this.checkBox_casa.Text = "Possui Casa Própia";
            this.checkBox_casa.UseVisualStyleBackColor = true;
            // 
            // checkBox_veiculo
            // 
            this.checkBox_veiculo.AutoSize = true;
            this.checkBox_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_veiculo.Location = new System.Drawing.Point(173, 131);
            this.checkBox_veiculo.Name = "checkBox_veiculo";
            this.checkBox_veiculo.Size = new System.Drawing.Size(108, 17);
            this.checkBox_veiculo.TabIndex = 24;
            this.checkBox_veiculo.Text = "Possui veiculo";
            this.checkBox_veiculo.UseVisualStyleBackColor = true;
            // 
            // dataGridView_pessoa
            // 
            this.dataGridView_pessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pessoa.Location = new System.Drawing.Point(26, 375);
            this.dataGridView_pessoa.Name = "dataGridView_pessoa";
            this.dataGridView_pessoa.Size = new System.Drawing.Size(301, 136);
            this.dataGridView_pessoa.TabIndex = 25;
            this.dataGridView_pessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pessoa_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 529);
            this.Controls.Add(this.dataGridView_pessoa);
            this.Controls.Add(this.checkBox_casa);
            this.Controls.Add(this.checkBox_veiculo);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.listBox_lista);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cadastrarAlterar);
            this.Controls.Add(this.groupBox_sexo);
            this.Controls.Add(this.comboBox_estadoCivil);
            this.Controls.Add(this.dateTimePicker_nascimento);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_dataNascimento);
            this.Controls.Add(this.label_estadoCivil);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.label_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Label label_estadoCivil;
        private System.Windows.Forms.Label label_dataNascimento;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nascimento;
        private System.Windows.Forms.ComboBox comboBox_estadoCivil;
        private System.Windows.Forms.GroupBox groupBox_sexo;
        private System.Windows.Forms.Button button_cadastrarAlterar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.ListBox listBox_lista;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.RadioButton radioButton_outros;
        private System.Windows.Forms.RadioButton radioButton_feminino;
        private System.Windows.Forms.RadioButton radioButton_masculino;
        private System.Windows.Forms.CheckBox checkBox_casa;
        private System.Windows.Forms.CheckBox checkBox_veiculo;
        private System.Windows.Forms.DataGridView dataGridView_pessoa;
    }
}

