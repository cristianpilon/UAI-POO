using Controladoras;
using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class FormularioTurno : Form
    {
        ControladoraClientes controladoraClientes;
        ControladoraVehiculos controladoraVehiculos;
        ControladoraTurnos controladoraTurnos;

        public FormularioTurno()
        {
            // Creo una instancias e inicializo las controladoras
            controladoraClientes = new ControladoraClientes();
            controladoraVehiculos = new ControladoraVehiculos();
            controladoraTurnos = new ControladoraTurnos();

            InitializeComponent();

            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establezco los botones cancelar y aceptar como resultados de diálogo
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnAceptar.DialogResult = DialogResult.OK;

            this.AcceptButton = btnAceptar;
            this.CancelButton = btnCancelar;

            // Establezco el formato del DateTimePicker (día/mes/año hora:mes - formato de 24hs, por eso HH y no hh)
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            
            // Permito que el DateTimePicker deje seleccionar la hora
            dtpFecha.ShowUpDown = true;
        }

        private void FormularioTurno_Load(object sender, EventArgs e)
        {
            // Cargo clientes
            var clientes = controladoraClientes.ObtenerTodos();

            foreach (var cliente in clientes)
            {
                var nuevoItem = new ComboboxItem(cliente.Dni, cliente.NombreCompleto());
                cboCliente.Items.Add(nuevoItem);
            }

            // Cargo vehículos
            var vehiculos = controladoraVehiculos.ObtenerTodos();

            foreach (var vehiculo in vehiculos)
            {
                var nuevoItem = new ComboboxItem(vehiculo.Patente, vehiculo.Describir());
                cboVehiculo.Items.Add(nuevoItem);
            }

            // Establezco la fecha actual como fecha mínima (el turno puede comenzar el mismo día pero no ser menos a la fecha actual).
            dtpFecha.MinDate = DateTime.Now;
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

            // Obtengo el DNI del cliente seleccionado del combo de clientes
            var comboItemCliente = (ComboboxItem)cboCliente.SelectedItem;
            var dniCliente = Convert.ToInt32(comboItemCliente.Value);

            // Obtengo la patente del vehículo seleccionado del combo de vehículos
            var comboItemPatente = (ComboboxItem)cboVehiculo.SelectedItem;
            var patente = comboItemPatente.Value.ToString();

            // Llamo a la controladora para crear el turno
            controladoraTurnos.Crear(dniCliente, patente, txtNotas.Text, dtpFecha.Value);

            // Cierro diálogo indicando que se realizó la acción correctamente
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Método para validar los campos del formulario.
        /// </summary>
        /// <returns>Retorna True si los campos son válidos. False en caso contrario.</returns>
        private bool ValidarDatos()
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return false;
            }

            if (cboVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehículo");
                return false;
            }

            return true;
        }
    }
}
