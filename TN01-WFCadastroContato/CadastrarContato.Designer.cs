namespace TN01_WFCadastroContato
{
    partial class CadastrarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarContato));
            lblNome = new Label();
            lblSobrenome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            mkdTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            label1 = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbPessoa = new RadioButton();
            rdbComercial = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(45, 12);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome :";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(307, 12);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(74, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(48, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 23);
            txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(307, 40);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(221, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(48, 154);
            mkdTelefone.Mask = "(99) 000-00000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(120, 23);
            mkdTelefone.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(45, 122);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "DDD/Telefone :";
            // 
            // label1
            // 
            label1.Location = new Point(48, 80);
            label1.MaximumSize = new Size(300, 1);
            label1.Name = "label1";
            label1.Size = new Size(300, 1);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbPessoa);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Location = new Point(208, 122);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(304, 63);
            gbxTipoTelefone.TabIndex = 7;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(191, 29);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 8;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbPessoa
            // 
            rdbPessoa.AutoSize = true;
            rdbPessoa.Location = new Point(6, 29);
            rdbPessoa.Name = "rdbPessoa";
            rdbPessoa.Size = new Size(61, 19);
            rdbPessoa.TabIndex = 9;
            rdbPessoa.TabStop = true;
            rdbPessoa.Text = "Pessoa";
            rdbPessoa.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(90, 29);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 10;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(48, 95);
            label2.Name = "label2";
            label2.Size = new Size(480, 1);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(44, 212);
            label3.Name = "label3";
            label3.Size = new Size(507, 1);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(483, 23);
            txtEmail.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(286, 348);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(91, 68);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(431, 348);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(96, 68);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += this.btnSalvar_Click_2;
            // 
            // CadastrarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(label1);
            Controls.Add(lblTelefone);
            Controls.Add(mkdTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            Name = "CadastrarContato";
            Text = "Cadastrar Contato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private MaskedTextBox mkdTelefone;
        private Label lblTelefone;
        private Label label1;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private RadioButton rdbPessoa;
        private Label label2;
        private Label label3;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}