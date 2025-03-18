namespace WFUsandoListagem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            mnMenu = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsListar = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            picImagem = new PictureBox();
            mnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // mnMenu
            // 
            mnMenu.BackColor = Color.Red;
            mnMenu.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnMenu.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsListar, mnsSair });
            mnMenu.Location = new Point(0, 0);
            mnMenu.Name = "mnMenu";
            mnMenu.Size = new Size(549, 24);
            mnMenu.TabIndex = 0;
            mnMenu.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(71, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += cadastrarToolStripMenuItem_Click;
            // 
            // mnsListar
            // 
            mnsListar.Name = "mnsListar";
            mnsListar.Size = new Size(50, 20);
            mnsListar.Text = "Listar";
            mnsListar.Click += mnsListar_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(42, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // picImagem
            // 
            picImagem.Dock = DockStyle.Fill;
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(549, 426);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 1;
            picImagem.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(picImagem);
            Controls.Add(mnMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = mnMenu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            mnMenu.ResumeLayout(false);
            mnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnMenu;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsListar;
        private ToolStripMenuItem mnsSair;
        private PictureBox picImagem;
    }
}