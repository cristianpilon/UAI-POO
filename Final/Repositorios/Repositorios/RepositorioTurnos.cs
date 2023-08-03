using Repositorios.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Repositorios.Repositorios
{
    public class RepositorioTurnos
    {
        /// <summary>
        /// Inicializo datos de prueba
        /// </summary>
        static List<Turno> turnos = new List<Turno>
        {
            new Turno(new Cliente("Juan", "Perez", 12345678), new Auto("ABC123", "Toyota", "Corolla", 2022, true, "Gasolina"), "Cambio de aceite", DateTime.Parse("2023-08-01 09:00")),
            new Turno(new Cliente("María", "Gomez", 23456789), new Moto("MOT456", "Kawasaki", "Ninja 400", 2023, 400, false), "Revisión general", DateTime.Parse("2023-08-02 14:30")),
            new Turno(new Cliente("Juan", "Perez", 12345678), new Auto("GHI789", "Chevrolet", "Camaro", 2023, false, "Gasolina"), "Reparación de motor", DateTime.Parse("2023-08-03 11:15")),
            new Turno(new Cliente("María", "Gomez", 23456789), new Moto("MOT789", "Yamaha", "MT-09", 2020, 850, true), "Cambio de frenos", DateTime.Parse("2023-08-04 10:00")),
            new Turno(new Cliente("Juan", "Perez", 12345678), new Auto("DEF456", "Ford", "Focus", 2020, true, "Diesel"), "Inspección técnica", DateTime.Parse("2023-08-05 16:45"))
        };

        public ReadOnlyCollection<Turno> Listar()
        {
            return turnos.AsReadOnly();
        }

        public bool Agregar(Turno nuevoTurno)
        {
            var turnoExistente = turnos.FirstOrDefault(turno => turno.Id == nuevoTurno.Id);
            if (turnoExistente == null)
            {
                turnos.Add(nuevoTurno);
                return true;
            }
            return false;
        }

        public bool Quitar(Guid id)
        {
            var turnoExistente = Buscar(id);
            if (turnoExistente != null)
            {
                turnos.Remove(turnoExistente);
                return true;
            }
            return false;
        }

        public Turno Buscar(Guid id)
        {
            return turnos.FirstOrDefault(turno => turno.Id == id);
        }
    }
}
