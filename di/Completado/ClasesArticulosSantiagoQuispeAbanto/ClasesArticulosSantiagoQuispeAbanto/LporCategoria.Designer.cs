namespace ClasesArticulosSantiagoQuispeAbanto
{
    partial class LporCategoria
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
            label1 = new Label();
            CategoriaListBox = new ListBox();
            ListarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIA";
            // 
            // CategoriaListBox
            // 
            CategoriaListBox.FormattingEnabled = true;
            CategoriaListBox.ItemHeight = 15;
            CategoriaListBox.Location = new Point(97, 17);
            CategoriaListBox.Name = "CategoriaListBox";
            CategoriaListBox.Size = new Size(89, 34);
            CategoriaListBox.TabIndex = 1;
            // 
            // ListarButton
            // 
            ListarButton.Location = new Point(64, 57);
            ListarButton.Name = "ListarButton";
            ListarButton.Size = new Size(75, 23);
            ListarButton.TabIndex = 3;
            ListarButton.Text = "Listar";
            ListarButton.UseVisualStyleBackColor = true;
            ListarButton.Click += ListarButton_Click;
            // 
            // LporCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 114);
            Controls.Add(ListarButton);
            Controls.Add(CategoriaListBox);
            Controls.Add(label1);
            Name = "LporCategoria";
            Text = "LporCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox CategoriaListBox;
        private Button ListarButton;
    }
}