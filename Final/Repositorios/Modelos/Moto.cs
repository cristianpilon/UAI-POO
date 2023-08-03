using Repositorios.Modelos.Base;
using System;

namespace Repositorios.Modelos
{
    public class Moto : Vehiculo
    {
        private const string TipoMotoImportada = "Importada";
        private const string TipoMotoNacional = "Nacional";

        /// <summary>
        /// Constructor que envia variables para la creación del constructor base y utiliza variables para su propia construcción.
        /// </summary>
        /// <param name="patente">Patente del vehículo.</param>
        /// <param name="marca">Marca del vehículo.</param>
        /// <param name="modelo">Modelo del vehículo.</param>
        /// <param name="anioFabricacion">Año de fabricación del vehículo.</param>
        /// <param name="cilindrada">Cilindrada de la moto.</param>
        /// <param name="importada">Indica si la moto es importada.</param>
        public Moto(string patente, string marca, string modelo, int anioFabricacion, int cilindrada, bool importada)
            : base(patente, marca, modelo, anioFabricacion)
        {
            Cilindrada = cilindrada;
            Importada = importada;
            EsAuto = false;
        }

        public int Cilindrada { get; set; }
        
        public bool Importada { get; set; }

        /// <summary>
        /// Polimorfismo del método base Describir.
        /// </summary>
        /// <returns>Descripción completa de la moto.</returns>
        public override string Describir()
        {
            return $"MOTO: {Patente} | {Marca} | {Modelo} | {AnioFabricacion} | {Cilindrada} | {(Importada ? TipoMotoImportada : TipoMotoNacional)}";
        }
    }
}
