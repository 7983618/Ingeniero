namespace ClasesArticulosSantiagoQuispeAbanto
{
    partial class Altas
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
            codLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NombreTextBox = new TextBox();
            CategoriaListBox = new ListBox();
            PrecioTextBox = new TextBox();
            ExistenciasTextBox = new TextBox();
            AltaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 41);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "COD";
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.Location = new Point(131, 41);
            codLabel.Name = "codLabel";
            codLabel.Size = new Size(0, 15);
            codLabel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 73);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 102);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "CATEGORIA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 132);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "PRECIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 161);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 5;
            label6.Text = "EXISTENCIAS";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(131, 70);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(100, 23);
            NombreTextBox.TabIndex = 6;
            // 
            // CategoriaListBox
            // 
            CategoriaListBox.FormattingEnabled = true;
            CategoriaListBox.ItemHeight = 15;
            CategoriaListBox.Location = new Point(132, 102);
            CategoriaListBox.Name = "CategoriaListBox";
            CategoriaListBox.Size = new Size(99, 19);
            CategoriaListBox.TabIndex = 7;
            // 
            // PrecioTextBox
            // 
            PrecioTextBox.Location = new Point(131, 129);
            PrecioTextBox.Name = "PrecioTextBox";
            PrecioTextBox.Size = new Size(100, 23);
            PrecioTextBox.TabIndex = 8;
            // 
            // ExistenciasTextBox
            // 
            ExistenciasTextBox.Location = new Point(131, 158);
            ExistenciasTextBox.Name = "ExistenciasTextBox";
            ExistenciasTextBox.Size = new Size(100, 23);
            ExistenciasTextBox.TabIndex = 9;
            // 
            // AltaButton
            // 
            AltaButton.Location = new Point(96, 196);
            AltaButton.Name = "AltaButton";
            AltaButton.Size = new Size(75, 23);
            AltaButton.TabIndex = 10;
            AltaButton.Text = "Alta";
            AltaButton.UseVisualStyleBackColor = true;
            AltaButton.Click += AltaButton_Click;
            // 
            // Altas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 294);
            Controls.Add(AltaButton);
            Controls.Add(ExistenciasTextBox);
            Controls.Add(PrecioTextBox);
            Controls.Add(CategoriaListBox);
            Controls.Add(NombreTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(codLabel);
            Controls.Add(label1);
            Name = "Altas";
            Text = "Altas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label codLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NombreTextBox;
        private ListBox CategoriaListBox;
        private TextBox PrecioTextBox;
        private TextBox ExistenciasTextBox;
        private Button AltaButton;
    }
}