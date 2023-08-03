using Repositorios.Modelos;
using Repositorios.Modelos.Base;
using Repositorios.Repositorios;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Controladoras
{
    /// <summary>
    /// Controladora de vehículos. Debido a que un vehículo es un concepto abstracto (puede ser moto o auto), esta controladora brinda todas las operaciones disponibles sobre vehículos.
    /// </summary>
    public class ControladoraVehiculos
    {
        readonly RepositorioAutos repositorioAutos;
        readonly RepositorioMotos repositorioMotos;

        public ControladoraVehiculos()
        {
            repositorioAutos = new RepositorioAutos();
            repositorioMotos = new RepositorioMotos();
        }

        public void CrearAuto(string patente, string marca, string modelo, int anioFabricacion, bool automatico, string tipoCombustible)
        {
            var nuevoAuto = new Auto(patente, marca, modelo, anioFabricacion, automatico, tipoCombustible);

            repositorioAutos.Agregar(nuevoAuto);
        }

        public void ModificarAuto(string patente, string marca, string modelo, int anioFabricacion, bool automatico, string tipoCombustible)
        {
            var auto = new Auto(patente, marca, modelo, anioFabricacion, automatico, tipoCombustible);

            repositorioAutos.Modificar(auto);
        }

        public Vehiculo ObtenerVehiculo(string patente)
        {
            var auto = ObtenerAuto(patente);

            if (auto == null)
            {
                return ObtenerMoto(patente);
            }

            return auto;
        }

        public void CrearMoto(string patente, string marca, string modelo, int anioFabricacion, bool importada, int cilindrada)
        {
            var nuevaMoto = new Moto(patente, marca, modelo, anioFabricacion, cilindrada, importada);

            repositorioMotos.Agregar(nuevaMoto);
        }

        public void ModificarMoto(string patente, string marca, string modelo, int anioFabricacion, bool importada, int cilindrada)
        {
            var moto = new Moto(patente, marca, modelo, anioFabricacion, cilindrada, importada);

            repositorioMotos.Modificar(moto);
        }

        private Auto ObtenerAuto(string patente)
        {
            return repositorioAutos.Buscar(patente);
        }

        private Moto ObtenerMoto(string patente)
        {
            return repositorioMotos.Buscar(patente);
        }

        /// <summary>
        /// La eliminación es exclusiva para ambos. Por medio de una patente verificamos que vamos a eliminar (auto ó moto).
        /// </summary>
        /// <param name="patente"></param>
        public void Eliminar(string patente)
        {
            var resultado = repositorioAutos.Quitar(patente);

            if (!resultado)
            {
                repositorioMotos.Quitar(patente);
            }
        }

        /// <summary>
        /// Método que obtiene todos los vehículos (independientemente de si sean motos o autos).
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<Vehiculo> ObtenerTodos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            var autos = repositorioAutos.Listar();
            var motos = repositorioMotos.Listar();

            // Agrego todos los autos y motos a la lista de vehículos por medio del método AddRange.
            // Esto es posible debido a que tanto Auto como Moto heredan de Vehículo.
            vehiculos.AddRange(autos);
            vehiculos.AddRange(motos);

            return vehiculos.AsReadOnly();
        }
    }
}
