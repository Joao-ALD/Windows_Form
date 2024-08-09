namespace Projeto_3
{
    partial class Form_calculadora_imc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_peso = new System.Windows.Forms.Label();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.label_altura = new System.Windows.Forms.Label();
            this.label_imc = new System.Windows.Forms.Label();
            this.label_situacao = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_resultado_imc = new System.Windows.Forms.Label();
            this.label_resultado_situacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de IMC";
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peso.Location = new System.Drawing.Point(96, 76);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(54, 20);
            this.label_peso.TabIndex = 1;
            this.label_peso.Text = "Peso:";
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(9, 99);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(228, 20);
            this.textBox_peso.TabIndex = 2;
            this.textBox_peso.TextChanged += new System.EventHandler(this.textBox_peso_TextChanged);
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(9, 199);
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(228, 20);
            this.textBox_altura.TabIndex = 3;
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_altura.Location = new System.Drawing.Point(92, 167);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(62, 20);
            this.label_altura.TabIndex = 4;
            this.label_altura.Text = "Altura:";
            // 
            // label_imc
            // 
            this.label_imc.AutoSize = true;
            this.label_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imc.Location = new System.Drawing.Point(103, 252);
            this.label_imc.Name = "label_imc";
            this.label_imc.Size = new System.Drawing.Size(41, 20);
            this.label_imc.TabIndex = 5;
            this.label_imc.Text = "IMC";
            this.label_imc.Click += new System.EventHandler(this.label_imc_Click);
            // 
            // label_situacao
            // 
            this.label_situacao.AutoSize = true;
            this.label_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_situacao.Location = new System.Drawing.Point(81, 333);
            this.label_situacao.Name = "label_situacao";
            this.label_situacao.Size = new System.Drawing.Size(85, 20);
            this.label_situacao.TabIndex = 6;
            this.label_situacao.Text = "Situação:";
            // 
            // button_sair
            // 
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(38, 411);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(171, 37);
            this.button_sair.TabIndex = 7;
            this.button_sair.Text = "SAIR";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // label_resultado_imc
            // 
            this.label_resultado_imc.AutoSize = true;
            this.label_resultado_imc.Location = new System.Drawing.Point(91, 285);
            this.label_resultado_imc.Name = "label_resultado_imc";
            this.label_resultado_imc.Size = new System.Drawing.Size(64, 13);
            this.label_resultado_imc.TabIndex = 8;
            this.label_resultado_imc.Text = "Resultado...";
            this.label_resultado_imc.Click += new System.EventHandler(this.label_resultado_imc_Click);
            // 
            // label_resultado_situacao
            // 
            this.label_resultado_situacao.AutoSize = true;
            this.label_resultado_situacao.Location = new System.Drawing.Point(91, 362);
            this.label_resultado_situacao.Name = "label_resultado_situacao";
            this.label_resultado_situacao.Size = new System.Drawing.Size(64, 13);
            this.label_resultado_situacao.TabIndex = 9;
            this.label_resultado_situacao.Text = "Resultado...";
            this.label_resultado_situacao.Click += new System.EventHandler(this.label_resultado_situacao_Click);
            // 
            // Form_calculadora_imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(248, 458);
            this.Controls.Add(this.label_resultado_situacao);
            this.Controls.Add(this.label_resultado_imc);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.label_situacao);
            this.Controls.Add(this.label_imc);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.label1);
            this.Name = "Form_calculadora_imc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.Label label_imc;
        private System.Windows.Forms.Label label_situacao;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_resultado_imc;
        private System.Windows.Forms.Label label_resultado_situacao;
    }
}

