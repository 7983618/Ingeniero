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
    public partial class CporNombre : Form
    {
        List<Articulo> articulos;
        public CporNombre(List<Articulo> articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            bool aceptable = true;
            if (String.IsNullOrEmpty(NombreTextBox.Text)) 
            {
                MessageBox.Show("Falta el nombre");
                aceptable = false;
            }
            if (aceptable) 
            {
                bool existe = false;
                foreach (Articulo a in articulos)
                {
                    if (a.getNombre().Equals(NombreTextBox.Text)) 
                    {
                        MessageBox.Show(a.ToString());
                        existe = true;
                    }
                }
                if (!existe)
                {
                    MessageBox.Show("No existe articulo con ese nombre");
                }
            }
            

        }
    }
}
