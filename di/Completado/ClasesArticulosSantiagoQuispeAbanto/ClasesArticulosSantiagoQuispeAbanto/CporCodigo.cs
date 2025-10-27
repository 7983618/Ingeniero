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
    public partial class CporCodigo : Form
    {
        List<Articulo> articulos;
        public CporCodigo(List<Articulo> articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            bool aceptable = true;
            if (String.IsNullOrEmpty(CodigoTextBox.Text))
            {
                MessageBox.Show("Falta el código");
                aceptable = false;
            } else
            {
                if (!int.TryParse(CodigoTextBox.Text, out _))
                {
                    MessageBox.Show("El formato del código no es correcto");
                }
            }
            if (aceptable)
            {
                bool existe = false;
                foreach (Articulo a in articulos)
                {
                    if (a.getCod() == int.Parse(CodigoTextBox.Text))
                    {
                        MessageBox.Show(a.ToString());
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    MessageBox.Show("No existe articulo con ese código");
                }
            }
        }
    }
}
