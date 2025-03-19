namespace WFCadastroProduto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            mnsMenu = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsListar = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            picImagem = new PictureBox();
            mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = Color.BlueViolet;
            mnsMenu.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsListar, mnsSair });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(509, 24);
            mnsMenu.TabIndex = 0;
            mnsMenu.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsListar
            // 
            mnsListar.Name = "mnsListar";
            mnsListar.Size = new Size(47, 20);
            mnsListar.Text = "Listar";
            mnsListar.Click += mnsListar_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // picImagem
            // 
            picImagem.BorderStyle = BorderStyle.Fixed3D;
            picImagem.Dock = DockStyle.Fill;
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(509, 359);
            picImagem.SizeMode = PictureBoxSizeMode.CenterImage;
            picImagem.TabIndex = 1;
            picImagem.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 383);
            Controls.Add(picImagem);
            Controls.Add(mnsMenu);
            ForeColor = SystemColors.HighlightText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            TransparencyKey = SystemColors.ActiveCaptionText;
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenu;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsListar;
        private ToolStripMenuItem mnsSair;
        private PictureBox picImagem;
    }
}