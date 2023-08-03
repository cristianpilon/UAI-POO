using Controladoras;
using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class Form1 : Form
    {
        ControladoraClientes controladoraClientes;
        ControladoraVehiculos controladoraVehiculos;
        ControladoraTurnos controladoraTurnos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creo una instancias e inicializo las controladoras
            controladoraClientes = new ControladoraClientes();
            controladoraVehiculos = new ControladoraVehiculos();
            controladoraTurnos = new ControladoraTurnos();

            // Inicializo los componentes de ListView
            InicializarListViewDeClientes();
            InicializarListViewDeVehiculos();
            InicializarListViewDeTurnos();

            // Deshabilitar de Modificar y Eliminar botones al inicio
            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
            btnModificarVehiculo.Enabled = false;
            btnEliminarVehiculo.Enabled = false;
            btnEliminarTurno.Enabled = false;
        }

        private void InicializarListViewDeClientes()
        {
            // Agregar columnas al ListView de Clientes
            lstClientes.Columns.Add("Nombre", 150);
            lstClientes.Columns.Add("Apellido", 150);
            // Utilizo un identificador de columna 'DNI' para utilizarlo luego para obtener el valor
                                    // Identificador de columna
            lstClientes.Columns.Add("DNI", "DNI", 100);

            // Cargar los datos de los clientes en el ListView
            CargarClientesEnListView();

            // Suscribir al evento SelectedIndexChanged del ListView
            lstClientes.SelectedIndexChanged += LstClientes_SelectedIndexChanged;
        }

        private void CargarClientesEnListView()
        {
            // Limpiar el ListView antes de cargar los datos
            lstClientes.Items.Clear();

            var listaClientes = controladoraClientes.ObtenerTodos();

            // Recorrer la lista de clientes y agregar cada cliente como una fila en el ListView
            foreach (var cliente in listaClientes)
            {
                ListViewItem item = new ListViewItem(cliente.Nombre);
                item.SubItems.Add(cliente.Apellido);
                item.SubItems.Add(cliente.Dni.ToString());

                lstClientes.Items.Add(item);
            }

            // Deshabilito botones de Modificar y Eliminar
            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        private void LstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar botones según haya un elemento seleccionado o no
            if (lstClientes.SelectedItems.Count > 0)
            {
                btnModificarCliente.Enabled = true;
                btnEliminarCliente.Enabled = true;
            }
            else
            {
                btnModificarCliente.Enabled = false;
                btnEliminarCliente.Enabled = false;
            }
        }

        private void InicializarListViewDeVehiculos()
        {
            // Agregar columnas al ListView de Clientes
            // Utilizo un identificador de columna 'Patente' para utilizarlo luego para obtener el valor
                                     // Identificador de columna
            lstVehiculos.Columns.Add("Patente", "Patente", 100);
            lstVehiculos.Columns.Add("Marca", 150);
            lstVehiculos.Columns.Add("Modelo", 150);
            lstVehiculos.Columns.Add("Año de Fabricación", 150);

            // Cargar los datos de los clientes en el ListView
            CargarVehiculosEnListView();

            // Suscribir al evento SelectedIndexChanged del ListView
            lstVehiculos.SelectedIndexChanged += LstVehiculos_SelectedIndexChanged;
        }

        private void CargarVehiculosEnListView()
        {
            // Limpiar el ListView antes de cargar los datos
            lstVehiculos.Items.Clear();

            var listaVehiculos = controladoraVehiculos.ObtenerTodos();

            // Recorrer la lista de clientes y agregar cada cliente como una fila en el ListView
            foreach (var vehiculo in listaVehiculos)
            {
                ListViewItem item = new ListViewItem(vehiculo.Patente);
                item.SubItems.Add(vehiculo.Marca);
                item.SubItems.Add(vehiculo.Modelo);
                item.SubItems.Add(vehiculo.AnioFabricacion.ToString());

                lstVehiculos.Items.Add(item);
            }

            // Deshabilito botones de Modificar y Eliminar
            btnModificarVehiculo.Enabled = false;
            btnEliminarVehiculo.Enabled = false;
        }

        private void LstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar botones según haya un elemento seleccionado o no
            if (lstVehiculos.SelectedItems.Count > 0)
            {
                btnModificarVehiculo.Enabled = true;
                btnEliminarVehiculo.Enabled = true;
            }
            else
            {
                btnModificarVehiculo.Enabled = false;
                btnEliminarVehiculo.Enabled = false;
            }
        }

        private void InicializarListViewDeTurnos()
        {
            // Agregar columnas al ListView de Clientes
            lstTurnos.Columns.Add("Fecha turno", 100);
            lstTurnos.Columns.Add("Cliente", 150);
            lstTurnos.Columns.Add("Vehículo", 250);
            lstTurnos.Columns.Add("Notas", 250);

            // Cargar los datos de los clientes en el ListView
            CargarTurnosEnListView();

            // Suscribir al evento SelectedIndexChanged del ListView
            lstTurnos.SelectedIndexChanged += LstTurnos_SelectedIndexChanged;
        }

        private void CargarTurnosEnListView()
        {
            // Limpiar el ListView antes de cargar los datos
            lstTurnos.Items.Clear();

            var listaTurnos = controladoraTurnos.ObtenerTodos();

            // Recorrer la lista de clientes y agregar cada cliente como una fila en el ListView
            foreach (var turno in listaTurnos)
            {
                ListViewItem item = new ListViewItem(turno.FechaTurno.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(turno.Cliente.NombreCompleto());
                item.SubItems.Add(turno.Vehiculo.Describir());
                item.SubItems.Add(turno.Notas);

                // Guardar el ID en la propiedad Tag del ListViewItem
                // Este ID me sirve para identificar el turno y no deseo mostrarlo en la interfaz gráfica
                // Tag es una propiedad que nos permite almacenar un objeto relacionado con el ítem de la lista.
                item.Tag = turno.Id.ToString();

                lstTurnos.Items.Add(item);
            }

            // Deshabilito botón de Eliminar
            btnEliminarTurno.Enabled = false;
        }

        private void LstTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar botones según haya un elemento seleccionado o no
            if (lstTurnos.SelectedItems.Count > 0)
            {
                btnEliminarTurno.Enabled = true;
            }
            else
            {
                btnEliminarTurno.Enabled = false;
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            // Tomo el identificador del ListView
            var indiceIdentificador = lstClientes.Columns["DNI"].Index;
            var dni = Convert.ToInt32(lstClientes.SelectedItems[0].SubItems[indiceIdentificador].Text);
            
            // Llamo a la controladora para eliminar el cliente
            controladoraClientes.Eliminar(dni);

            // Recargo ListView de clientes
            CargarClientesEnListView();
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            // Tomo el identificador del ListView y llamo al método Eliminar de la controladora
            var indiceIdentificador = lstVehiculos.Columns["Patente"].Index;
            var patente = lstVehiculos.SelectedItems[0].SubItems[indiceIdentificador].Text;
            
            // Llamo a la controladora para eliminar el vehículo
            controladoraVehiculos.Eliminar(patente);

            // Recargo ListView de vehículos
            CargarVehiculosEnListView();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            // Tomo el identificador del ListView y se lo paso al formulario (el constructor lo espera)
            var indiceIdentificador = lstClientes.Columns["DNI"].Index;
            var dni = Convert.ToInt32(lstClientes.SelectedItems[0].SubItems[indiceIdentificador].Text);

            // Creo el formulario y lo muestro pasandole el identificador del ítem a modificar
            var form = new FormularioCliente(dni);
            var resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Si el resultado es OK, recargo la lista de clientes
                CargarClientesEnListView();
            }
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            // Tomo el identificador del ListView y se lo paso al formulario (el constructor lo espera)
            var indiceIdentificador = lstVehiculos.Columns["Patente"].Index;
            var patente = lstVehiculos.SelectedItems[0].SubItems[indiceIdentificador].Text;

            // Creo el formulario y lo muestro pasandole el identificador del ítem a modificar
            var form = new FormularioVehiculo(patente);
            var resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Si el resultado es OK, recargo la lista de vehículos
                CargarVehiculosEnListView();
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Creo el formulario y lo muestro
            var form = new FormularioCliente(null);
            var resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Si el resultado es OK, recargo la lista de clientes
                CargarClientesEnListView();
            }
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            // Creo el formulario y lo muestro
            var form = new FormularioVehiculo(null);
            var resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Si el resultado es OK, recargo la lista de clientes
                CargarVehiculosEnListView();
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            // Tomamos el ID almcenado en el Tag (ver método "CargarTurnosEnListView").
            // El método Guid.Parse me permite convertir una cadena en un identificador único 
            // (siempre que la misma respete el format esperado).
            // Luego, llamo al método Eliminar de la controladora
            var idTurno = Guid.Parse(lstTurnos.SelectedItems[0].Tag.ToString());
            
            // Llamo a la controladora para eliminar el turno
            controladoraTurnos.Eliminar(idTurno);

            // Recargo el ListView de turnos
            CargarTurnosEnListView();
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            // Creo el formulario y lo muestro
            var form = new FormularioTurno();
            var resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Si el resultado es OK, recargo la lista de clientes
                CargarTurnosEnListView();
            }
        }
    }
}
