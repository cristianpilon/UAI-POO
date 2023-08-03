using Repositorios.Modelos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Repositorios.Repositorios
{
    public class RepositorioClientes
    {
        /// <summary>
        /// Inicializo datos de prueba
        /// </summary>
        static List<Cliente> clientes = new List<Cliente>
        {
            new Cliente("Juan", "Perez", 12345678),
            new Cliente("María", "Gomez", 23456789),
        };

        public ReadOnlyCollection<Cliente> Listar()
        {
            return clientes.AsReadOnly();
        }

        public bool Agregar(Cliente nuevoCliente)
        {
            var clienteExistente = clientes.FirstOrDefault(cliente => cliente.Dni == nuevoCliente.Dni);
            if (clienteExistente == null)
            {
                clientes.Add(nuevoCliente);
                return true;
            }
            return false;
        }

        public bool Quitar(int dni)
        {
            var clienteExistente = Buscar(dni);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
                return true;
            }
            return false;
        }

        public Cliente Buscar(int dni)
        {
            return clientes.FirstOrDefault(cliente => cliente.Dni == dni);
        }

        public bool Modificar(Cliente cliente)
        {
            var clienteExistente = Buscar(cliente.Dni);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
                clientes.Add(cliente);
                return true;
            }

            return false;
        }
    }
}
