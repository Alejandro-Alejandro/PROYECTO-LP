using System.Collections.Generic;
using System;
using System.Windows.Forms;
using static GestorInventario.Ingresar;

namespace GestorInventario
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }
       
        //Boton buscar por ID
        private void button4_Click(object sender, System.EventArgs e)
        {
            MostrarProducto.Clear();
            MostrarCantidad.Clear();
            MostrarPrecio.Clear();
            MostrarDetalles.Clear();

            // Validar si el campo de texto del ID está vacío
            if (string.IsNullOrEmpty(buscarID.Text))
            {
                MessageBox.Show("ID necesario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el producto por ID
            var producto = Ingresar.listaProductos.Find(p => p.Id == buscarID.Text);

            // Validar si el producto existe
            if (producto != null)
            {
                // Mostrar los datos del producto
                MostrarProducto.Text = producto.Nombre;
                MostrarCantidad.Text = producto.Cantidad.ToString();
                MostrarPrecio.Text = producto.Precio.ToString();
                MostrarDetalles.Text = producto.Detalles;
            }
            else
            {
                // Mostrar mensaje de alerta si el producto no existe
                MessageBox.Show("El producto no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Boton cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el índice del producto seleccionado
                int indice = listaProductos.FindIndex(p => p.Id == buscarID.Text);

                // Validar si el producto existe
                if (indice != -1)
                {
                    // Crear un nuevo objeto Productoo con los datos actualizados
                    Productoo productoActualizado = new Productoo(
                        listaProductos[indice].Id,
                        MostrarProducto.Text,
                        int.Parse(MostrarCantidad.Text),
                        double.Parse(MostrarPrecio.Text),
                        MostrarDetalles.Text
                    );

                    // Reemplazar el objeto antiguo en la lista con el nuevo objeto
                    listaProductos[indice] = productoActualizado;

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Datos actualizados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpiar
                    buscarID.Clear();
                    MostrarProducto.Clear();
                    MostrarCantidad.Clear();
                    MostrarPrecio.Clear();
                    MostrarDetalles.Clear();
                }
                else
                {
                    // Mostrar mensaje de alerta si el producto no existe
                    MessageBox.Show("El producto no existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton eliminar por ID
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el índice del producto seleccionado
                int indice = listaProductos.FindIndex(p => p.Id == buscarID.Text);

                // Validar si el producto existe
                if (indice != -1)
                {
                    // Eliminar el producto de la lista
                    listaProductos.RemoveAt(indice);

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Datos eliminados correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los cuadros de texto
                    buscarID.Clear();
                    MostrarProducto.Clear();
                    MostrarCantidad.Clear();
                    MostrarPrecio.Clear();
                    MostrarDetalles.Clear();
                }
                else
                {
                    // Mostrar mensaje de alerta si el producto no existe
                    MessageBox.Show("Los datos no existen", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show("Error al eliminar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }
    }
}

