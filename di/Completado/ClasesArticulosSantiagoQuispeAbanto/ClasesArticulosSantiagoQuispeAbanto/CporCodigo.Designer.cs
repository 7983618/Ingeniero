namespace ClasesArticulosSantiagoQuispeAbanto
{
    partial class CporCodigo
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
            ConsultaButton = new Button();
            CodigoTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ConsultaButton
            // 
            ConsultaButton.Location = new Point(62, 59);
            ConsultaButton.Name = "ConsultaButton";
            ConsultaButton.Size = new Size(75, 23);
            ConsultaButton.TabIndex = 5;
            ConsultaButton.Text = "Consulta";
            ConsultaButton.UseVisualStyleBackColor = true;
            ConsultaButton.Click += ConsultaButton_Click;
            // 
            // CodigoTextBox
            // 
            CodigoTextBox.Location = new Point(98, 21);
            CodigoTextBox.Name = "CodigoTextBox";
            CodigoTextBox.Size = new Size(100, 23);
            CodigoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // CporCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 126);
            Controls.Add(ConsultaButton);
            Controls.Add(CodigoTextBox);
            Controls.Add(label1);
            Name = "CporCodigo";
            Text = "CporCodigo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConsultaButton;
        private TextBox CodigoTextBox;
        private Label label1;
    }
}