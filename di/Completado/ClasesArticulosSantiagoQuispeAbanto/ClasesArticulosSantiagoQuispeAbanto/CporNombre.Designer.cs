namespace ClasesArticulosSantiagoQuispeAbanto
{
    partial class CporNombre
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
            NombreTextBox = new TextBox();
            ConsultaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(98, 20);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(100, 23);
            NombreTextBox.TabIndex = 1;
            // 
            // ConsultaButton
            // 
            ConsultaButton.Location = new Point(62, 58);
            ConsultaButton.Name = "ConsultaButton";
            ConsultaButton.Size = new Size(75, 23);
            ConsultaButton.TabIndex = 2;
            ConsultaButton.Text = "Consulta";
            ConsultaButton.UseVisualStyleBackColor = true;
            ConsultaButton.Click += ConsultaButton_Click;
            // 
            // CporNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 115);
            Controls.Add(ConsultaButton);
            Controls.Add(NombreTextBox);
            Controls.Add(label1);
            Name = "CporNombre";
            Text = "CporNombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NombreTextBox;
        private Button ConsultaButton;
    }
}