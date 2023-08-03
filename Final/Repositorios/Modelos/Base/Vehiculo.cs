namespace Repositorios.Modelos.Base
{
    /// <summary>
    /// Clase abstracta de vehiculo para representar una herencia en Auto y Moto
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Constructor de la clase vehículo.
        /// </summary>
        /// <param name="patente">Patente del vehículo.</param>
        /// <param name="marca">Marca del vehículo.</param>
        /// <param name="modelo">Modelo del vehículo.</param>
        /// <param name="anioFabricacion">Año de fabricación del vehículo.</param>
        public Vehiculo(string patente, string marca, string modelo, int anioFabricacion)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            AnioFabricacion = anioFabricacion;
        }

        public string Patente { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }
        
        public int AnioFabricacion { get; set; }

        public bool EsAuto { get; set; }

        /// <summary>
        /// Método abstracto para representar polimorfismo en Auto y Moto
        /// </summary>
        public abstract string Describir();
    }
}
