using Repositorios.Modelos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Repositorios.Repositorios
{
    public class RepositorioMotos
    {
        /// <summary>
        /// Inicializo datos de prueba
        /// </summary>
        static List<Moto> motos = new List<Moto>
        {
            new Moto("MOT123", "Honda", "CBR 1000", 2022, 1000, true),
            new Moto("MOT456", "Kawasaki", "Ninja 400", 2023, 400, false),
            new Moto("MOT789", "Yamaha", "MT-09", 2020, 850, true),
            new Moto("MOT012", "Suzuki", "GSX-R750", 2023, 750, true),
            new Moto("MOT345", "Ducati", "Panigale V4", 2021, 1100, false)
        };

        public ReadOnlyCollection<Moto> Listar()
        {
            return motos.AsReadOnly();
        }

        public bool Agregar(Moto nuevaMoto)
        {
            var motoExistente = motos.FirstOrDefault(moto => moto.Patente == nuevaMoto.Patente);
            if (motoExistente == null)
            {
                motos.Add(nuevaMoto);
                return true;
            }
            return false;
        }

        public bool Quitar(string patente)
        {
            var motoExistente = Buscar(patente);
            if (motoExistente != null)
            {
                motos.Remove(motoExistente);
                return true;
            }
            return false;
        }

        public Moto Buscar(string patente)
        {
            return motos.FirstOrDefault(moto => moto.Patente == patente);
        }

        public bool Modificar(Moto moto)
        {
            var motoExistente = Buscar(moto.Patente);//1
            if (motoExistente != null)
            {
                motos.Remove(motoExistente);
                motos.Add(moto);
                return true;
            }

            return false;
        }
    }
}
