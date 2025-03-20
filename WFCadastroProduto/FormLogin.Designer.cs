namespace WFCadastroProduto
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            lblSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(21, 22);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(21, 94);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(21, 49);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(181, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(21, 128);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(181, 23);
            txtSenha.TabIndex = 2;
            
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(109, 194);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(93, 49);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 315);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnAcessar;
    }
}
