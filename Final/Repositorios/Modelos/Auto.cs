using Repositorios.Modelos.Base;
using System;

namespace Repositorios.Modelos
{
    public class Auto : Vehiculo
    {
        private const string TipoAutomatico = "Automatico";
        private const string TipoManual = "Manual";

        /// <summary>
        /// Constructor que envia variables para la creación del constructor base y utiliza variables para su propia construcción.
        /// </summary>
        /// <param name="patente">Patente del vehículo.</param>
        /// <param name="marca">Marca del vehículo.</param>
        /// <param name="modelo">Modelo del vehículo.</param>
        /// <param name="anioFabricacion">Año de fabricación del vehículo.</param>
        /// <param name="automatico">Inidica si el auto es automático.</param>
        /// <param name="tipoCombustible">Tipo de combustible del auto.</param>
        public Auto(string patente, string marca, string modelo, int anioFabricacion, bool automatico, string tipoCombustible)
            : base(patente, marca, modelo, anioFabricacion)
        {
            EsAutomatico = automatico;
            TipoCombustible = tipoCombustible;
            EsAuto = true;
        }

        public bool EsAutomatico { get; }
        
        public string TipoCombustible { get; }

        /// <summary>
        /// Polimorfismo del método base Describir.
        /// </summary>
        /// <returns>Descripción completa del auto.</returns>
        public override string Describir()
        {
            return $"AUTO: {Patente} | {Marca} | {Modelo} | {AnioFabricacion} | {(EsAutomatico ? TipoAutomatico : TipoManual)} | {TipoCombustible}";
        }
    }
}
