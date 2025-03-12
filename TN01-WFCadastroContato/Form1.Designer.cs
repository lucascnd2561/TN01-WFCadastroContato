namespace TN01_WFCadastroContato
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            ctsCadastrar = new ToolStripMenuItem();
            ctsSobre = new ToolStripMenuItem();
            ctsSair = new ToolStripMenuItem();
            pbxImagem = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagem).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ctsCadastrar, ctsSobre, ctsSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ctsCadastrar
            // 
            ctsCadastrar.Name = "ctsCadastrar";
            ctsCadastrar.Size = new Size(69, 20);
            ctsCadastrar.Text = "Cadastrar";
            // 
            // ctsSobre
            // 
            ctsSobre.Name = "ctsSobre";
            ctsSobre.Size = new Size(49, 20);
            ctsSobre.Text = "Sobre";
            // 
            // ctsSair
            // 
            ctsSair.Name = "ctsSair";
            ctsSair.Size = new Size(38, 20);
            ctsSair.Text = "Sair";
            // 
            // pbxImagem
            // 
            pbxImagem.Location = new Point(12, 27);
            pbxImagem.Name = "pbxImagem";
            pbxImagem.Size = new Size(776, 366);
            pbxImagem.TabIndex = 1;
            pbxImagem.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbxImagem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ctsCadastrar;
        private ToolStripMenuItem ctsSobre;
        private ToolStripMenuItem ctsSair;
        private PictureBox pbxImagem;
    }
}
