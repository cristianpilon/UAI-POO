using Repositorios.Modelos;
using Repositorios.Modelos.Base;
using Repositorios.Repositorios;
using System;
using System.Collections.ObjectModel;

namespace Controladoras
{
    /// <summary>
    /// Controladora de turno. Esta controladora maneja las operaciones sobre los turnos, que es una asociación de vehículos con un cliente particular.
    /// </summary>
    public class ControladoraTurnos
    {
        readonly RepositorioTurnos repositorioTurnos;
        readonly RepositorioClientes repositorioClientes;
        readonly RepositorioAutos repositorioAutos;
        readonly RepositorioMotos repositorioMotos;

        public ControladoraTurnos()
        {
            repositorioTurnos = new RepositorioTurnos();
            repositorioClientes = new RepositorioClientes();
            repositorioAutos = new RepositorioAutos();
            repositorioMotos = new RepositorioMotos();
        }

        public void Crear(int dniCliente, string patenteVehiculo, string notas, DateTime? fechaTurno)
        {
            var cliente = repositorioClientes.Buscar(dniCliente);
            var vehiculo = BuscarVehiculo(patenteVehiculo);

            var nuevoTurno = new Turno(cliente, vehiculo, notas, fechaTurno);

            repositorioTurnos.Agregar(nuevoTurno);
        }

        public void Eliminar(Guid id)
        {
            repositorioTurnos.Quitar(id);
        }

        public ReadOnlyCollection<Turno> ObtenerTodos()
        {
            return repositorioTurnos.Listar();
        }

        private Vehiculo BuscarVehiculo(string patente)
        {
            Vehiculo vehiculo = repositorioAutos.Buscar(patente);

            if (vehiculo == null)
            {
                vehiculo = repositorioMotos.Buscar(patente);
            }

            return vehiculo;
        }
    }
}
