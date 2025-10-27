namespace ClasesArticulosSantiagoQuispeAbanto
{
    public partial class Form1 : Form
    {
        List<Articulo> articulos = new List<Articulo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto hecho por Santiago Quispe Abanto");
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Altas altas = new Altas(articulos);
            altas.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos(articulos);
            pedidos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CporNombre cporNombre = new CporNombre(articulos);
            cporNombre.ShowDialog();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CporCodigo cporCodigo = new CporCodigo(articulos);
            cporCodigo.ShowDialog();
        }

        private void mínimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (Articulo a in articulos)
            {
                if (a.getExistencias() < 10)
                {
                    str = str + a.ToString();
                }
            }
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("No hay ningun articulo con menos de 10 existencias");
            }
            else
            {
                MessageBox.Show(str);
            }
        }
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (Articulo a in articulos)
            {
                str = str + a.ToString();
            }
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("No hay ningun articulo");
            }
            else
            {
                MessageBox.Show(str);
            }
        }

        private void porCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LporCategoria lporCategoria = new LporCategoria(articulos);
            lporCategoria.ShowDialog();
        }
    }
    public enum Categoria
    {
        Informatica,
        Imagen,
        Telefonia,
        Sonido
    }
    /*
    codigoArticulo (int) – el constructor crea el código de forma automática y lo va incrementando
    nombreArticulo(string)
    categoriaArticulo(string): Informática, Imagen, Telefonía, Sonido
    precioArticulo(decimal)
    existenciasArticulo(int) 
     */
    public class Articulo
    {
        public static int cod_articulos = 1;
        private int cod;
        private string nombre;
        private string categoria;
        private decimal precio;
        private int existencias;

        public Articulo(string nombre, string categoria, decimal precio, int existencias)
        {
            cod = cod_articulos;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.existencias = existencias;
            cod_articulos++;
        }

        public int getCod()
        {
            return cod;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getCategoria()
        {
            return categoria;
        }
        public decimal getPrecio()
        {
            return precio;
        }
        public int getExistencias()
        {
            return existencias;
        }
        public void actualizarExistencias(int cantidadPedido)
        {
            if (existencias - cantidadPedido < 0)
            {
                MessageBox.Show("No hay suficientes existencias\nExistencias: " + existencias);
            }
            else
            {
                existencias = existencias - cantidadPedido;
                MessageBox.Show("Cantidad: " + cantidadPedido + "\nPrecio total: " + cantidadPedido * precio + "\nExistencias actuales: " + existencias);
            }
        }
        public override string ToString()
        {
            return "COD: " + cod + "\n" +
                "NOMBRE: " + nombre + "\n" +
                "CATEGORIA: " + categoria + "\n" +
                "PRECIO: " + precio + "\n" +
                "EXISTENCIAS: " + existencias + "\n" +
                "-----------------------------------" + "\n";
        }
    }
}
