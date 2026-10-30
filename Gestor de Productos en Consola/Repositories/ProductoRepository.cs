
using Gestor_de_Productos_en_Consola.Interfaces;
using Gestor_de_Productos_en_Consola.Models;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gestor_de_Productos_en_Consola.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        // Campos
        private List<Producto> _productos;

        // Constructor
        public ProductoRepository()
        {
            _productos = new List<Producto>()
            {
                new Producto()
                {
                    Id = 1,
                    Nombre = "Teclado",
                    Precio = 150000m,
                    Categoria = "Tecnologia",
                    Activo = true
                },

                new Producto()
                {
                    Id = 2,
                    Nombre = "Mouse",
                    Precio = 80000m,
                    Categoria = "Tecnologia",
                    Activo = true
                },

                new Producto()
                {
                    Id = 3,
                    Nombre = "Silla",
                    Precio = 450000m,
                    Categoria = "Muebles",
                    Activo = true
                },

                new Producto()
                {
                    Id = 4,
                    Nombre = "Escritorio",
                    Precio = 600000m,
                    Categoria = "Muebles",
                    Activo = false
                }
            };
        }

        // Métodos

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos.ToList();
        }

        public Producto ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return _productos
                .Where(p => p.Categoria == categoria)
                .ToList();
        }
    }
}
