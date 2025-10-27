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
    public partial class Pedidos : Form
    {
        List<Articulo> articulos;
        public Pedidos(List<Articulo> articulos)
        {
            InitializeComponent();
            this.articulos = articulos;
        }

        private void PedidoButton_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Formato de código incorrecto");
                    aceptable = false;
                }
            }
            if (String.IsNullOrEmpty(CantidadTextBox.Text))
            {
                MessageBox.Show("Falta cantidad");
                aceptable = false;
            } else
            {
                if (!int.TryParse(CantidadTextBox.Text, out _))
                {
                    MessageBox.Show("Formato de cantidad incorrecto");
                    aceptable = false;
                }
            }
            if (aceptable) 
            {
                Articulo articulo;
                bool encontrado = false;
                foreach (Articulo a in articulos)
                {
                    if (a.getCod() == int.Parse(CodigoTextBox.Text))
                    {
                        a.actualizarExistencias(int.Parse(CantidadTextBox.Text));
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("No se ha encontrado ningun articulo con ese ID");
                }

            }
        }
    }
}
