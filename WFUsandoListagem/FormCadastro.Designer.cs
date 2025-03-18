namespace WFUsandoListagem
{
    partial class FormCadastro
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
            txtNovoLogin = new TextBox();
            txtConfirmarSenha = new TextBox();
            txtNovaSenha = new TextBox();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtNovoLogin
            // 
            txtNovoLogin.Location = new Point(48, 60);
            txtNovoLogin.Name = "txtNovoLogin";
            txtNovoLogin.Size = new Size(127, 23);
            txtNovoLogin.TabIndex = 1;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(48, 150);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(127, 23);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(48, 106);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.Size = new Size(127, 23);
            txtNovaSenha.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(181, 63);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(181, 109);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(181, 153);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(96, 15);
            lblConfirmarSenha.TabIndex = 6;
            lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonFace;
            btnCadastrar.Location = new Point(181, 197);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 46);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 307);
            Controls.Add(btnCadastrar);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtNovoLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNovoLogin;
        private TextBox txtConfirmarSenha;
        private TextBox txtNovaSenha;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private Button btnCadastrar;
    }
}