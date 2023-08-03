using Repositorios.Modelos.Base;
using System;

namespace Repositorios.Modelos
{
    /// <summary>
    /// Clase para representar un turno para el taller.
    /// </summary>
    public class Turno
    {
        /// <summary>
        /// Constructor de la clase turno.
        /// </summary>
        /// <param name="cliente">Instancia del cliente que registrará el turno.</param>
        /// <param name="vehiculo">Instancia del vehículo propiedad del cliente.</param>
        /// <param name="notas">Notas opciones acerca del trabajo a realizar en el taller.</param>
        /// <param name="fechaTurno">Fecha del turno. Opcional: Si este campo es nulo, se establecerá el horario al momento de la creación.</param>
        public Turno(Cliente cliente, Vehiculo vehiculo, string notas, DateTime? fechaTurno)
        {
            Id = Guid.NewGuid(); // Método estático para la creación de un ID al generar un nuevo turno.
            Cliente = cliente;
            Vehiculo = vehiculo;
            FechaTurno = fechaTurno.HasValue ? fechaTurno.Value : DateTime.Now;
            Notas = notas;
        }

        public Guid Id { get; }

        public Cliente Cliente { get; set; }

        public Vehiculo Vehiculo { get; set; }

        public DateTime FechaTurno { get; set; }

        public string Notas { get; set; }
    }
}
