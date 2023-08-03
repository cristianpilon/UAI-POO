using Controladoras;
using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class FormularioCliente : Form
    {
        readonly ControladoraClientes controladoraClientes;
        readonly bool modoEdicion = false;

        public FormularioCliente(int? dniCliente)
        {
            InitializeComponent();

            // Permito un tamaño máximo de caracteres de 8 para el TextBox de 'DNI'
            txtDni.MaxLength = 8;

            // Establezco los botones cancelar y aceptar como resultados de diálogo
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnAceptar.DialogResult = DialogResult.OK;

            // Creo una instancia de la controladora
            controladoraClientes = new ControladoraClientes();

            // Si se envía el DNI, significa que estamos intentando modificar un usuario existente
            if (dniCliente.HasValue)
            {
                modoEdicion = true;

                // En modo de edición obtengo los datos del cliente
                var cliente = controladoraClientes.Obtener(dniCliente.Value);
                
                txtDni.Text = cliente.Dni.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDni.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierro diálogo
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Valido los datos del formulario
            if (!ValidarDatos())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            // Convierto el valor de 'DNI' a un número entero
            var dni = Convert.ToInt32(txtDni.Text);

            if (modoEdicion)
            {
                // Si es edición, verifico si existe en nuestro repositorio
                var cliente = controladoraClientes.Obtener(dni);

                if (cliente != null)
                {
                    controladoraClientes.Modificar(txtNombre.Text, txtApellido.Text, dni);
                }
            }
            else
            {
                // Creación de un nuevo cliente
                controladoraClientes.Crear(txtNombre.Text, txtApellido.Text, dni);
            }

            // Cierro diálogo indicando que se realizó la acción correctamente
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Método de para validar que solo se ingresen números en el campo DNI.
        /// </summary>
        /// <param name="sender">Elemento que ejeuctó el evento</param>
        /// <param name="e">Evento que se ejecuta</param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número o una tecla especial (por ejemplo, flechas, teclas de navegación)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número, marcar el evento como manejado para evitar que el carácter se ingrese en el TextBox
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método para validar los campos del formulario.
        /// </summary>
        /// <returns>Retorna True si los campos son válidos. False en caso contrario.</returns>
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe completar el campo DNI");
                return false;
            }

            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 caracteres");
                return false;
            }

            if (!modoEdicion)
            {
                var dni = Convert.ToInt32(txtDni.Text);
                var clienteMismoDni = controladoraClientes.Obtener(dni);

                if (clienteMismoDni != null)
                {
                    MessageBox.Show("Ya existe un cliente con el DNI ingresado");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar el campo Nombre");
                return false;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe completar el campo Apellido");
                return false;
            }

            return true;
        }
    }
}
