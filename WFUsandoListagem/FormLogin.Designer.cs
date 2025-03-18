namespace WFUsandoListagem
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
            lblLogin.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Blue;
            lblLogin.Location = new Point(101, 30);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(55, 18);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.Blue;
            lblSenha.Location = new Point(101, 105);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 18);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(101, 59);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Informe seu Login";
            txtLogin.Size = new Size(145, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(101, 132);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe Senha:";
            txtSenha.Size = new Size(145, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.Blue;
            btnAcessar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = SystemColors.ButtonHighlight;
            btnAcessar.Location = new Point(150, 185);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(96, 48);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 260);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += Form1_Load;
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
