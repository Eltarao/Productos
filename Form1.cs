using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;

namespace Producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Productos> Misproductos = new Queue<Productos>();
        private decimal Precio;
        private decimal Unidades;

        private void btnagregar_Click(object sender, EventArgs e)
        {

            //verificacion para no dejar que ingresen datos en blanco.
            if (txtnombre.Text == "")
            {
                MessageBox.Show(txtnombre.Text, "Debe ingresar un nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
                return;
            }

            if (txtmarca.Text == "")
            {
                MessageBox.Show(txtmarca.Text, "Debe ingresar una marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmarca.Focus();
                return;
            }

            //Como son datos de tipo numerico, para que no permita ingresar caracteres
            if (!Decimal.TryParse(txtprecio.Text, out Precio))
            {
                MessageBox.Show(txtprecio.Text, "Debe ingresar un dato numerico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprecio.Focus();
                return;
            }

            if (!Decimal.TryParse(txtunidades.Text, out Unidades))
            {
                MessageBox.Show(txtunidades.Text, "Debe ingresar un dato numerico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtunidades.Focus();
                return;
            }

            //Metodo para encolar
            Productos Miproducto = new Productos();
            Miproducto.Nombre = txtnombre.Text;
            Miproducto.Marca = txtmarca.Text;
            Miproducto.Precio = Decimal.Parse(txtprecio.Text);
            Miproducto.Unidades = Decimal.Parse(txtunidades.Text);
            Misproductos.Enqueue(Miproducto);
            //Vaciar el data grid view
            dgv.DataSource = null;
            Limpiarcola();

            MessageBox.Show("Los datos se ingresaron de manera exitosa");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //Método para desencolar
            if (Misproductos.Count != 0)
            {   
                Productos Miproducto = new Productos();
                Miproducto = Misproductos.Dequeue();
                txtnombre.Text = Miproducto.Nombre;
                txtmarca.Text = Miproducto.Marca;
                txtprecio.Text = Miproducto.Precio.ToString();
                txtunidades.Text = Miproducto.Unidades.ToString();
                dgv.DataSource = Misproductos.ToList();
                MessageBox.Show("Los datos han sido eliminados");
                Limpiarcola();
            }
            //Mensaje de advertencia si la caja está vacía
            else
            {
                MessageBox.Show("La cola esta vacia", "Atencion");
                Limpiarcola();
            }
        }

        //Método para limpiar la cola
        public void Limpiarcola()
        {
            txtnombre.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtunidades.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgv.DataSource = Misproductos.ToList();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        { 
                // Obtener el nombre y la marca que se van a buscar
                string nombreabuscar = txtnombre.Text;


                // Bandera para indicar si se encontró el producto
                bool encontrado = false;

                // Iterar sobre la cola para buscar el producto por nombre
                foreach (var producto in Misproductos)
                {
                    if (producto.Nombre.Equals(nombreabuscar, StringComparison.OrdinalIgnoreCase))
                    {
                        // Producto encontrado
                        MessageBox.Show($"Producto encontrado:\nNombre:" +
                        $" {producto.Nombre}\nMarca: {producto.Marca}\nPrecio:" +
                        $" {producto.Precio}\nUnidades: {producto.Unidades}");
                    
                    Limpiarcola();

                    encontrado = true;
                        break;
                    }
                }

                // Si no se encontró el producto
                if (!encontrado)
                {
                    MessageBox.Show("Producto no encontrado");
                }

        }
    }
}
