namespace Projeto_4
{
    partial class Form_reservaPassagem
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
            this.label_reservaPassagem = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_destino = new System.Windows.Forms.Label();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.label_data = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.groupBox_meios_transporte = new System.Windows.Forms.GroupBox();
            this.radioButton_onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.groupBox_valoresPacote = new System.Windows.Forms.GroupBox();
            this.label_valorTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_gastoDestino = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_gastoTransporte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.groupBox_meios_transporte.SuspendLayout();
            this.groupBox_valoresPacote.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_reservaPassagem
            // 
            this.label_reservaPassagem.AutoSize = true;
            this.label_reservaPassagem.BackColor = System.Drawing.Color.SteelBlue;
            this.label_reservaPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reservaPassagem.ForeColor = System.Drawing.Color.GhostWhite;
            this.label_reservaPassagem.Location = new System.Drawing.Point(-1, -2);
            this.label_reservaPassagem.Name = "label_reservaPassagem";
            this.label_reservaPassagem.Padding = new System.Windows.Forms.Padding(160, 0, 160, 0);
            this.label_reservaPassagem.Size = new System.Drawing.Size(627, 31);
            this.label_reservaPassagem.TabIndex = 0;
            this.label_reservaPassagem.Text = "Reserva de Passagem";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(12, 54);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(43, 13);
            this.label_nome.TabIndex = 1;
            this.label_nome.Text = "Nome:";
            this.label_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(69, 51);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(408, 20);
            this.textBox_nome.TabIndex = 2;
            // 
            // label_destino
            // 
            this.label_destino.AutoSize = true;
            this.label_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_destino.Location = new System.Drawing.Point(9, 90);
            this.label_destino.Name = "label_destino";
            this.label_destino.Size = new System.Drawing.Size(54, 13);
            this.label_destino.TabIndex = 3;
            this.label_destino.Text = "Destino:";
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBox_destino.Location = new System.Drawing.Point(69, 87);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(122, 21);
            this.comboBox_destino.TabIndex = 4;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(12, 123);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(38, 13);
            this.label_data.TabIndex = 5;
            this.label_data.Text = "Data:";
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_data.Location = new System.Drawing.Point(69, 121);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker_data.TabIndex = 6;
            // 
            // groupBox_meios_transporte
            // 
            this.groupBox_meios_transporte.Controls.Add(this.radioButton_onibus);
            this.groupBox_meios_transporte.Controls.Add(this.radioButton_aviao);
            this.groupBox_meios_transporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_meios_transporte.Location = new System.Drawing.Point(252, 87);
            this.groupBox_meios_transporte.Name = "groupBox_meios_transporte";
            this.groupBox_meios_transporte.Size = new System.Drawing.Size(225, 49);
            this.groupBox_meios_transporte.TabIndex = 7;
            this.groupBox_meios_transporte.TabStop = false;
            this.groupBox_meios_transporte.Text = "Meios de transporte:";
            // 
            // radioButton_onibus
            // 
            this.radioButton_onibus.AutoSize = true;
            this.radioButton_onibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_onibus.Location = new System.Drawing.Point(136, 19);
            this.radioButton_onibus.Name = "radioButton_onibus";
            this.radioButton_onibus.Size = new System.Drawing.Size(58, 17);
            this.radioButton_onibus.TabIndex = 1;
            this.radioButton_onibus.TabStop = true;
            this.radioButton_onibus.Text = "Ônibus";
            this.radioButton_onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_aviao.Location = new System.Drawing.Point(33, 19);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(52, 17);
            this.radioButton_aviao.TabIndex = 0;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Avião";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox_valoresPacote
            // 
            this.groupBox_valoresPacote.Controls.Add(this.label_valorTotal);
            this.groupBox_valoresPacote.Controls.Add(this.label10);
            this.groupBox_valoresPacote.Controls.Add(this.label_gastoDestino);
            this.groupBox_valoresPacote.Controls.Add(this.label8);
            this.groupBox_valoresPacote.Controls.Add(this.label_gastoTransporte);
            this.groupBox_valoresPacote.Controls.Add(this.label5);
            this.groupBox_valoresPacote.Controls.Add(this.label4);
            this.groupBox_valoresPacote.Controls.Add(this.label2);
            this.groupBox_valoresPacote.Controls.Add(this.label1);
            this.groupBox_valoresPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_valoresPacote.Location = new System.Drawing.Point(69, 161);
            this.groupBox_valoresPacote.Name = "groupBox_valoresPacote";
            this.groupBox_valoresPacote.Size = new System.Drawing.Size(434, 79);
            this.groupBox_valoresPacote.TabIndex = 8;
            this.groupBox_valoresPacote.TabStop = false;
            this.groupBox_valoresPacote.Text = "Valores do Pacote:";
            // 
            // label_valorTotal
            // 
            this.label_valorTotal.AutoSize = true;
            this.label_valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valorTotal.Location = new System.Drawing.Point(354, 51);
            this.label_valorTotal.Name = "label_valorTotal";
            this.label_valorTotal.Size = new System.Drawing.Size(39, 13);
            this.label_valorTotal.TabIndex = 8;
            this.label_valorTotal.Text = "00,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "R$";
            // 
            // label_gastoDestino
            // 
            this.label_gastoDestino.AutoSize = true;
            this.label_gastoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gastoDestino.Location = new System.Drawing.Point(219, 51);
            this.label_gastoDestino.Name = "label_gastoDestino";
            this.label_gastoDestino.Size = new System.Drawing.Size(34, 13);
            this.label_gastoDestino.TabIndex = 6;
            this.label_gastoDestino.Text = "00,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "R$";
            // 
            // label_gastoTransporte
            // 
            this.label_gastoTransporte.AutoSize = true;
            this.label_gastoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gastoTransporte.Location = new System.Drawing.Point(68, 51);
            this.label_gastoTransporte.Name = "label_gastoTransporte";
            this.label_gastoTransporte.Size = new System.Drawing.Size(34, 13);
            this.label_gastoTransporte.TabIndex = 4;
            this.label_gastoTransporte.Text = "00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gasto com Destino";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gasto Transporte";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button_confirmar
            // 
            this.button_confirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_confirmar.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_confirmar.Location = new System.Drawing.Point(488, 51);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(65, 36);
            this.button_confirmar.TabIndex = 9;
            this.button_confirmar.Text = "Confirmar";
            this.button_confirmar.UseVisualStyleBackColor = false;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // button_calcular
            // 
            this.button_calcular.BackColor = System.Drawing.Color.SteelBlue;
            this.button_calcular.ForeColor = System.Drawing.Color.GhostWhite;
            this.button_calcular.Location = new System.Drawing.Point(488, 94);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(65, 36);
            this.button_calcular.TabIndex = 11;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = false;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.SteelBlue;
            this.button_sair.ForeColor = System.Drawing.Color.GhostWhite;
            this.button_sair.Location = new System.Drawing.Point(559, 94);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(59, 36);
            this.button_sair.TabIndex = 13;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = false;
            // 
            // button_limpar
            // 
            this.button_limpar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_limpar.ForeColor = System.Drawing.Color.GhostWhite;
            this.button_limpar.Location = new System.Drawing.Point(559, 51);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(59, 36);
            this.button_limpar.TabIndex = 12;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = false;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // Form_reservaPassagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.groupBox_valoresPacote);
            this.Controls.Add(this.groupBox_meios_transporte);
            this.Controls.Add(this.dateTimePicker_data);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.label_destino);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label_reservaPassagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_reservaPassagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Passagem";
            this.Load += new System.EventHandler(this.Form_reservaPassagem_Load);
            this.groupBox_meios_transporte.ResumeLayout(false);
            this.groupBox_meios_transporte.PerformLayout();
            this.groupBox_valoresPacote.ResumeLayout(false);
            this.groupBox_valoresPacote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_reservaPassagem;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_destino;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.GroupBox groupBox_meios_transporte;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.RadioButton radioButton_onibus;
        private System.Windows.Forms.GroupBox groupBox_valoresPacote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_valorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_gastoDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_gastoTransporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_limpar;
    }
}

