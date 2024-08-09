namespace Projeto_7
{
    partial class Form_inicio
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
            this.label_telaInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_telaInicial
            // 
            this.label_telaInicial.AutoSize = true;
            this.label_telaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telaInicial.Location = new System.Drawing.Point(150, 96);
            this.label_telaInicial.Name = "label_telaInicial";
            this.label_telaInicial.Size = new System.Drawing.Size(156, 31);
            this.label_telaInicial.TabIndex = 0;
            this.label_telaInicial.Text = "Tela Inicial";
            this.label_telaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 253);
            this.Controls.Add(this.label_telaInicial);
            this.Name = "Form_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Form_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_telaInicial;
    }
}

