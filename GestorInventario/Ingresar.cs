using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorInventario
{
    public partial class Ingresar : Form
    {
        //Crea la lista
        public static List<Productoo> listaProductos = new List<Productoo>();

        public Ingresar()
        {
            InitializeComponent();
        }

        private void Ingre_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los TextBox
            string id = IngresarID.Text;
            string producto = IngresarProducto.Text;
            string cantidad = IngresarCantidad.Text;
            string precio = IngresarPrecio.Text;
            string detalles = IngresarDetalles.Text;

            // Validaciones
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(producto) || string.IsNullOrEmpty(cantidad) || string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(detalles))
            {
                MessageBox.Show("Por favor, completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Crear un nuevo objeto Producto
                int cant = int.Parse(cantidad);
                double prec = double.Parse(precio);
                Productoo nuevoProducto = new Productoo(id, producto, cant, prec, detalles);

                // Agregar el producto a la lista
                listaProductos.Add(nuevoProducto);

                MessageBox.Show("Producto ingresado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBox
                IngresarID.Text = "";
                IngresarProducto.Text = "";
                IngresarCantidad.Text = "";
                IngresarPrecio.Text = "";
                IngresarDetalles.Text = "";
            }
        }

        // Clase para representar un producto
        public class Productoo
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public string Detalles { get; set; }

            public Productoo(string id, string nombre, int cantidad, double precio, string detalles)
            {
                Id = id;
                Nombre = nombre;
                Cantidad = cantidad;
                Precio = precio;
                Detalles = detalles;
            }
        }

        //Boton cancelar
        private void Cance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {

        }
    }
}