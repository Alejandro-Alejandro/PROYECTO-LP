using System;
using System.Windows.Forms;

namespace GestorInventario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //Lleva a la pantalla de ingresar datos
        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();

            ingreso.Show();
        }

        //Boton de salir
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Lleva a la pantalla de actualizar datos
        private void button2_Click(object sender, EventArgs e)
        {
            Actualizar actualizo = new Actualizar();

            actualizo.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
