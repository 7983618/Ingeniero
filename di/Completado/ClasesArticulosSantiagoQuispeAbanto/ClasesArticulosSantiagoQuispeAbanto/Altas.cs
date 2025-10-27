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
    public partial class Altas : Form
    {
        List<Articulo> articulos;
        public Altas(List<Articulo> artiulos)
        {
            InitializeComponent();
            codLabel.Text = "" + Articulo.cod_articulos;
            this.articulos = artiulos;
            CategoriaListBox.Items.Add(Categoria.Informatica);
            CategoriaListBox.Items.Add(Categoria.Imagen);
            CategoriaListBox.Items.Add(Categoria.Sonido);
            CategoriaListBox.Items.Add(Categoria.Telefonia);
        }


        private void AltaButton_Click(object sender, EventArgs e)
        {
            bool aceptable = true;
            if (String.IsNullOrEmpty(NombreTextBox.Text))
            {
                MessageBox.Show("Falta el nombre");
                aceptable = false;
            }
            if (String.IsNullOrEmpty(CategoriaListBox.Text))
            {
                MessageBox.Show("Falta la categoría");
                aceptable = false;
            }
            if (String.IsNullOrEmpty(PrecioTextBox.Text))
            {
                MessageBox.Show("Falta la precio");
                aceptable = false;
            }
            else
            {
                if (!Decimal.TryParse(PrecioTextBox.Text, out _))
                {
                    MessageBox.Show("El precio no tiene un buen formato");
                    aceptable = false;
                }
            }
            if (String.IsNullOrEmpty(ExistenciasTextBox.Text))
            {
                MessageBox.Show("Faltan las existencias");
                aceptable = false;
            }
            else
            {
                if (!int.TryParse(ExistenciasTextBox.Text, out _))
                {
                    MessageBox.Show("Las existencias no tienen un buen formato");
                    aceptable = false;
                }
            }
            if (aceptable)
            {
                Articulo nuevo = new Articulo(NombreTextBox.Text, CategoriaListBox.Text, Decimal.Parse(PrecioTextBox.Text), int.Parse(ExistenciasTextBox.Text));
                articulos.Add(nuevo);
                MessageBox.Show("ARTICULO CREADO\nDETALLES:\n" + nuevo.ToString());
                codLabel.Text = "" + Articulo.cod_articulos;
            }
        }
    }
}
