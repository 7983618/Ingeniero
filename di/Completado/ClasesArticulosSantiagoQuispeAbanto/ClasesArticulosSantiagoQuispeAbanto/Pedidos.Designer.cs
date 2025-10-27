namespace ClasesArticulosSantiagoQuispeAbanto
{
    partial class Pedidos
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
            label2 = new Label();
            CodigoTextBox = new TextBox();
            CantidadTextBox = new TextBox();
            PedidoButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "COD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "CANTIDAD";
            // 
            // CodigoTextBox
            // 
            CodigoTextBox.Location = new Point(139, 21);
            CodigoTextBox.Name = "CodigoTextBox";
            CodigoTextBox.Size = new Size(100, 23);
            CodigoTextBox.TabIndex = 2;
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(139, 49);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(100, 23);
            CantidadTextBox.TabIndex = 3;
            // 
            // PedidoButton
            // 
            PedidoButton.Location = new Point(87, 78);
            PedidoButton.Name = "PedidoButton";
            PedidoButton.Size = new Size(75, 23);
            PedidoButton.TabIndex = 4;
            PedidoButton.Text = "Pedido";
            PedidoButton.UseVisualStyleBackColor = true;
            PedidoButton.Click += PedidoButton_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 146);
            Controls.Add(PedidoButton);
            Controls.Add(CantidadTextBox);
            Controls.Add(CodigoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pedidos";
            Text = "Pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CodigoTextBox;
        private TextBox CantidadTextBox;
        private Button PedidoButton;
    }
}