namespace Projeto_7
{
    partial class FormLogin
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
            this.label_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(12, 9);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(101, 26);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(17, 38);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(328, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(17, 102);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(328, 20);
            this.txt_senha.TabIndex = 3;
            this.txt_senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.Location = new System.Drawing.Point(12, 73);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(87, 26);
            this.label_senha.TabIndex = 2;
            this.label_senha.Text = "Senha:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(17, 147);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 50);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(195, 147);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(150, 50);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 216);
            this.ControlBox = false;
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label_usuario);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_entrar;
    }
}