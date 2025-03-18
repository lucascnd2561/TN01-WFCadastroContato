namespace WFUsandoListagem
{
    partial class FormListagem
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
            dvgListagemUsuario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgListagemUsuario).BeginInit();
            SuspendLayout();
            // 
            // dvgListagemUsuario
            // 
            dvgListagemUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListagemUsuario.Location = new Point(78, 43);
            dvgListagemUsuario.Name = "dvgListagemUsuario";
            dvgListagemUsuario.Size = new Size(492, 374);
            dvgListagemUsuario.TabIndex = 1;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgListagemUsuario);
            Name = "FormListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListagem";
            ((System.ComponentModel.ISupportInitialize)dvgListagemUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgListagemUsuario;
    }
}