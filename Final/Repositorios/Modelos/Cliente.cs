namespace Repositorios.Modelos
{
    /// <summary>
    /// Clase de Cliente. 
    /// 1. Las propiedades no tienen set para que no puedan ser modificadas.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Clase para representar un cliente.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public string Nombre { get; }

        public string Apellido { get;  }

        public int Dni { get; }

        public string NombreCompleto()
        {
            // tecnica de string interpolation (
            return string.Format($"{Dni} | {Apellido}, {Nombre}");
        }
    }
}
