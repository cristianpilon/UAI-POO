using Repositorios.Modelos;
using Repositorios.Repositorios;
using System.Collections.ObjectModel;

namespace Controladoras
{
    /// <summary>
    /// Controladora de cliente. Es la mas sencilla. Sólo opera la obtención, alta baja y modificación de clientes.
    /// </summary>
    public class ControladoraClientes
    {
        readonly RepositorioClientes repositorioClientes;

        public ControladoraClientes()
        {
            repositorioClientes = new RepositorioClientes();
        }

        public void Crear(string nombre, string apellido, int dni)
        {
            var nuevoCliente = new Cliente(nombre, apellido, dni);

            repositorioClientes.Agregar(nuevoCliente);
        }

        public void Modificar(string nombre, string apellido, int dni)
        {
            var cliente = new Cliente(nombre, apellido, dni);

            repositorioClientes.Modificar(cliente);
        }

        public void Eliminar(int dni)
        {
            repositorioClientes.Quitar(dni);
        }

        public Cliente Obtener(int dni)
        {
            return repositorioClientes.Buscar(dni);
        }

        public ReadOnlyCollection<Cliente> ObtenerTodos()
        {
            return repositorioClientes.Listar();
        }
    }
}
