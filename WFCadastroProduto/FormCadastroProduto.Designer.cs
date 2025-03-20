namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lblCodigo = new Label();
            dtpDataVencimento = new DateTimePicker();
            cbxCategoria = new ComboBox();
            nudPreco = new NumericUpDown();
            txtNomedoProduto = new TextBox();
            lblCategoria = new Label();
            lblNomedoProduto = new Label();
            lblPreco = new Label();
            lblDatadeVencimento = new Label();
            btnSalvar = new Button();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            mtbCodigo = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Location = new Point(191, 146);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(131, 23);
            dtpDataVencimento.TabIndex = 1;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Açougue", "", "Hortaliças", "", "Eletrônicos", "", "Limpeza", "", "Padaria", "", "Frios", "", "Laticínios", "", "Peixaria", "", "Cesta", " Básica" });
            cbxCategoria.Location = new Point(172, 36);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(150, 23);
            cbxCategoria.TabIndex = 2;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudPreco.Location = new Point(25, 146);
            nudPreco.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(160, 23);
            nudPreco.TabIndex = 4;
            // 
            // txtNomedoProduto
            // 
            txtNomedoProduto.Location = new Point(25, 93);
            txtNomedoProduto.Name = "txtNomedoProduto";
            txtNomedoProduto.Size = new Size(297, 23);
            txtNomedoProduto.TabIndex = 6;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(172, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria";
            // 
            // lblNomedoProduto
            // 
            lblNomedoProduto.AutoSize = true;
            lblNomedoProduto.Location = new Point(25, 75);
            lblNomedoProduto.Name = "lblNomedoProduto";
            lblNomedoProduto.Size = new Size(103, 15);
            lblNomedoProduto.TabIndex = 8;
            lblNomedoProduto.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(25, 128);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 9;
            lblPreco.Text = "Preço";
            // 
            // lblDatadeVencimento
            // 
            lblDatadeVencimento.AutoSize = true;
            lblDatadeVencimento.Location = new Point(192, 128);
            lblDatadeVencimento.Name = "lblDatadeVencimento";
            lblDatadeVencimento.Size = new Size(113, 15);
            lblDatadeVencimento.TabIndex = 10;
            lblDatadeVencimento.Text = "Data de Vencimento";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(219, 380);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 64);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(25, 202);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(297, 156);
            txtObservacao.TabIndex = 12;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(25, 184);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 13;
            lblObservacao.Text = "Observação";
            // 
            // mtbCodigo
            // 
            mtbCodigo.Enabled = false;
            mtbCodigo.Location = new Point(28, 36);
            mtbCodigo.Mask = "000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(100, 23);
            mtbCodigo.TabIndex = 14;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 456);
            Controls.Add(mtbCodigo);
            Controls.Add(lblObservacao);
            Controls.Add(txtObservacao);
            Controls.Add(btnSalvar);
            Controls.Add(lblDatadeVencimento);
            Controls.Add(lblPreco);
            Controls.Add(lblNomedoProduto);
            Controls.Add(lblCategoria);
            Controls.Add(txtNomedoProduto);
            Controls.Add(nudPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(dtpDataVencimento);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            Load += FormCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private DateTimePicker dtpDataVencimento;
        private ComboBox cbxCategoria;
        private NumericUpDown nudPreco;
        private TextBox txtNomedoProduto;
        private Label lblCategoria;
        private Label lblNomedoProduto;
        private Label lblPreco;
        private Label lblDatadeVencimento;
        private Button btnSalvar;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private MaskedTextBox mtbCodigo;
    }
}