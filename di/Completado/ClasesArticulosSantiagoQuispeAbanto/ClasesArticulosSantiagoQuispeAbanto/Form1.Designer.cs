namespace ClasesArticulosSantiagoQuispeAbanto
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
            articulosToolStripMenuItem = new ToolStripMenuItem();
            altasToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            porNombreToolStripMenuItem = new ToolStripMenuItem();
            porCódigoToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            mínimosToolStripMenuItem = new ToolStripMenuItem();
            porCategoríaToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { articulosToolStripMenuItem, consultasToolStripMenuItem, listarToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(333, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altasToolStripMenuItem, pedidosToolStripMenuItem, salirToolStripMenuItem });
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(66, 20);
            articulosToolStripMenuItem.Text = "Articulos";
            // 
            // altasToolStripMenuItem
            // 
            altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            altasToolStripMenuItem.Size = new Size(116, 22);
            altasToolStripMenuItem.Text = "Altas";
            altasToolStripMenuItem.Click += altasToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(116, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(116, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porNombreToolStripMenuItem, porCódigoToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // porNombreToolStripMenuItem
            // 
            porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            porNombreToolStripMenuItem.Size = new Size(139, 22);
            porNombreToolStripMenuItem.Text = "Por Nombre";
            porNombreToolStripMenuItem.Click += porNombreToolStripMenuItem_Click;
            // 
            // porCódigoToolStripMenuItem
            // 
            porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            porCódigoToolStripMenuItem.Size = new Size(139, 22);
            porCódigoToolStripMenuItem.Text = "Por Código";
            porCódigoToolStripMenuItem.Click += porCódigoToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mínimosToolStripMenuItem, porCategoríaToolStripMenuItem, todosToolStripMenuItem });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 20);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // mínimosToolStripMenuItem
            // 
            mínimosToolStripMenuItem.Name = "mínimosToolStripMenuItem";
            mínimosToolStripMenuItem.Size = new Size(180, 22);
            mínimosToolStripMenuItem.Text = "Mínimos";
            mínimosToolStripMenuItem.Click += mínimosToolStripMenuItem_Click;
            // 
            // porCategoríaToolStripMenuItem
            // 
            porCategoríaToolStripMenuItem.Name = "porCategoríaToolStripMenuItem";
            porCategoríaToolStripMenuItem.Size = new Size(180, 22);
            porCategoríaToolStripMenuItem.Text = "Por Categoría";
            porCategoríaToolStripMenuItem.Click += porCategoríaToolStripMenuItem_Click;
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(180, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autorToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(180, 22);
            autorToolStripMenuItem.Text = "Autor";
            autorToolStripMenuItem.Click += autorToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 62);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 1;
            label1.Text = "PRACTICA MENUS Y CLASES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 137);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripMenuItem altasToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem porNombreToolStripMenuItem;
        private ToolStripMenuItem porCódigoToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem mínimosToolStripMenuItem;
        private ToolStripMenuItem porCategoríaToolStripMenuItem;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        private Label label1;
    }
}
