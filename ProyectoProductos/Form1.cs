using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProductos
{
    public partial class Form1 : Form
    {
        // Lista en memoria para almacenar los productos guardados
        private List<Producto> listaDeProductos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento de carga del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            ValidarFormulario();

            // Configura la tabla visual para que se adapte al ancho de la pantalla
            if (dgvProductos != null)
            {
                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarFormulario();

            if (btnGuardar.Enabled)
            {
                // Extraemos valores y convertimos tipos de datos de forma segura
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                // Guardamos en la lista interna
                Producto nuevoProducto = new Producto(nombre, precio, cantidad);
                listaDeProductos.Add(nuevoProducto);

                // Refrescamos la interfaz visual
                ActualizarTabla();
                LimpiarCampos();

                MessageBox.Show("¡Producto guardado con éxito en la lista!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede guardar. Corrige los errores en rojo primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarFormulario();

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarFormulario();

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarFormulario();

        }

        // MÉTODO DE VALIDACIÓN
        private void ValidarFormulario()
        {
            // Especificamos el tipo explícito de la tupla para compatibilidad
            List<(TextBox txt, IValidadorCampo validador)> camposAValidar = new List<(TextBox txt, IValidadorCampo validador)>();

            camposAValidar.Add((txtNombre, new ValidadorTexto()));
            camposAValidar.Add((txtPrecio, new ValidadorDecimal()));
            camposAValidar.Add((txtCantidad, new ValidadorEntero()));

            bool todoOk = true;

            foreach (var item in camposAValidar)
            {
                if (!item.validador.EsValido(item.txt.Text))
                {
                    errorProvider1.SetError(item.txt, item.validador.MensajeError);
                    todoOk = false;
                }
                else
                {
                    errorProvider1.SetError(item.txt, string.Empty);
                }
            }

            // Habilita o deshabilita el botón de manera automática
            btnGuardar.Enabled = todoOk;
        }

        // Actualiza el control visual de la tabla
        private void ActualizarTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaDeProductos;
        }

        // Limpia las cajas de texto tras un guardado exitoso
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            ValidarFormulario();
        }
    }
}
