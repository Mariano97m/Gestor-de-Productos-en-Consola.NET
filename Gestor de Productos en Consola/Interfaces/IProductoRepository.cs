using Gestor_de_Productos_en_Consola.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_de_Productos_en_Consola.Interfaces
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);

        List<Producto> ObtenerTodos();

        Producto? ObtenerPorId(int id);

        List<Producto> BuscarPorCategoria(string categoria);
    }
}
