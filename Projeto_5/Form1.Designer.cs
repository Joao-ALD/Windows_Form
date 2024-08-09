namespace Projeto_5
{
    partial class Calculadora
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
            this.label_valor1 = new System.Windows.Forms.Label();
            this.label_valor2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.button_limpar = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_valor1
            // 
            this.label_valor1.AutoSize = true;
            this.label_valor1.Location = new System.Drawing.Point(13, 15);
            this.label_valor1.Name = "label_valor1";
            this.label_valor1.Size = new System.Drawing.Size(72, 13);
            this.label_valor1.TabIndex = 0;
            this.label_valor1.Text = "Digite o valor:";
            // 
            // label_valor2
            // 
            this.label_valor2.AutoSize = true;
            this.label_valor2.Location = new System.Drawing.Point(5, 41);
            this.label_valor2.Name = "label_valor2";
            this.label_valor2.Size = new System.Drawing.Size(90, 13);
            this.label_valor2.TabIndex = 1;
            this.label_valor2.Text = "Digite outro valor:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_valor1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_valor1.Location = new System.Drawing.Point(101, 12);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(182, 20);
            this.textBox_valor1.TabIndex = 7;
            this.textBox_valor1.TextChanged += new System.EventHandler(this.textBox_valor1_TextChanged);
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_valor2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_valor2.Location = new System.Drawing.Point(101, 38);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(182, 20);
            this.textBox_valor2.TabIndex = 8;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(298, 70);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(114, 34);
            this.button_limpar.TabIndex = 12;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(24, 81);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(58, 13);
            this.label_resultado.TabIndex = 13;
            this.label_resultado.Text = "Resultado:";
            this.label_resultado.Click += new System.EventHandler(this.label_resultado_Click);
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_resultado.Enabled = false;
            this.textBox_resultado.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_resultado.Location = new System.Drawing.Point(88, 78);
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.Size = new System.Drawing.Size(182, 20);
            this.textBox_resultado.TabIndex = 14;
            this.textBox_resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(418, 117);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_valor2);
            this.Controls.Add(this.label_valor1);
            this.Name = "Calculadora";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_valor1;
        private System.Windows.Forms.Label label_valor2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox textBox_resultado;
    }
}

