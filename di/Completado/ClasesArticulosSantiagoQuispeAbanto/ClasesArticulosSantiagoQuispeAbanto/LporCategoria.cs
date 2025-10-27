using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesArticulosSantiagoQuispeAbanto
{
    public partial class LporCategoria : Form
    {
        List<Articulo> articulos;
        public LporCategoria(List<Articulo> articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
            CategoriaListBox.Items.Add(Categoria.Informatica);
            CategoriaListBox.Items.Add(Categoria.Telefonia);
            CategoriaListBox.Items.Add(Categoria.Sonido);
            CategoriaListBox.Items.Add(Categoria.Imagen);
        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CategoriaListBox.Text)) 
            {
                MessageBox.Show("Falta la categoría");
            } else
            {
                string str = "";
                foreach (Articulo a in articulos)
                {
                    if (a.getCategoria().Equals(CategoriaListBox.Text))
                    {
                        str = str + a.ToString();
                    }
                }
                if (string.IsNullOrEmpty(str))
                {
                    MessageBox.Show("No hay ningun articulo con esa categoría");
                }
                else
                {
                    MessageBox.Show(str);
                }
            }
        }
    }
}
