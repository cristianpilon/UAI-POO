using Repositorios.Modelos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Repositorios.Repositorios
{
    public class RepositorioAutos
    {
        /// <summary>
        /// Inicializo datos de prueba
        /// </summary>
        static List<Auto> autos = new List<Auto>
        {
            new Auto("ABC123", "Toyota", "Corolla", 2022, true, "Nafta"),
            new Auto("XYZ789", "Honda", "Civic", 2023, true, "Nafta"),
            new Auto("DEF456", "Ford", "Focus", 2020, true, "Diesel"),
            new Auto("GHI789", "Chevrolet", "Camaro", 2023, false, "Nafta"),
            new Auto("JKL012", "Volkswagen", "Golf", 2021, true, "Gas")
        };

        public ReadOnlyCollection<Auto> Listar()
        {
            return autos.AsReadOnly();
        }

        public bool Agregar(Auto nuevoAuto)
        {
            var autoExistente = autos.FirstOrDefault(auto => auto.Patente == nuevoAuto.Patente);
            if (autoExistente == null)
            {
                autos.Add(nuevoAuto);
                return true;
            }
            return false;
        }

        public bool Quitar(string patente)
        {
            var autoExistente = Buscar(patente);
            if (autoExistente != null)
            {
                autos.Remove(autoExistente);
                return true;
            }
            return false;
        }

        public Auto Buscar(string patente)
        {
            return autos.FirstOrDefault(auto => auto.Patente == patente);
        }

        public bool Modificar(Auto auto)
        {
            var autoExistente = Buscar(auto.Patente);//1
            if (autoExistente != null)
            {
                autos.Remove(autoExistente);
                autos.Add(auto);
                return true;
            }

            return false;
        }
    }
}
