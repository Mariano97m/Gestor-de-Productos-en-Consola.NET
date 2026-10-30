
using Gestor_de_Productos_en_Consola.Interfaces;
using Gestor_de_Productos_en_Consola.Models;
using Gestor_de_Productos_en_Consola.Repositories;

// Instanciar el repositorio mediante la interfaz
IProductoRepository repo = new ProductoRepository();


// ======================================
// 1. OBTENER TODOS LOS PRODUCTOS
// ======================================

Console.WriteLine("===== LISTA DE PRODUCTOS =====");

List<Producto> productos = repo.ObtenerTodos();

foreach (Producto producto in productos)
{
    Console.WriteLine($"ID: {producto.Id}");
    Console.WriteLine($"Nombre: {producto.Nombre}");
    Console.WriteLine($"Precio: {producto.Precio}");
    Console.WriteLine($"Categoria: {producto.Categoria}");
    Console.WriteLine($"Activo: {producto.Activo}");

    Console.WriteLine("-------------------------");
}


// ======================================
// 2. BUSCAR PRODUCTO POR ID
// ======================================

Console.WriteLine("\n===== BUSCAR POR ID =====");

Producto? productoEncontrado = repo.ObtenerPorId(2);

if (productoEncontrado != null)
{
    Console.WriteLine($"Producto encontrado: {productoEncontrado.Nombre}");
    Console.WriteLine($"Precio: {productoEncontrado.Precio}");
}
else
{
    Console.WriteLine("Producto no encontrado");
}


// ======================================
// 3. FILTRAR POR CATEGORIA
// ======================================

Console.WriteLine("\n===== BUSCAR POR CATEGORIA =====");

List<Producto> productosCategoria =
    repo.BuscarPorCategoria("Tecnologia");

foreach (Producto producto in productosCategoria)
{
    Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
}


// ======================================
// 4. AGREGAR UN NUEVO PRODUCTO
// ======================================

Console.WriteLine("\n===== AGREGAR PRODUCTO =====");

Producto nuevoProducto = new Producto()
{
    Id = 5,
    Nombre = "Monitor",
    Precio = 950000m,
    Categoria = "Tecnologia",
    Activo = true
};

repo.Agregar(nuevoProducto);

Console.WriteLine("Producto agregado correctamente.");


// ======================================
// 5. MOSTRAR LISTA ACTUALIZADA
// ======================================

Console.WriteLine("\n===== LISTA ACTUALIZADA =====");

foreach (Producto producto in repo.ObtenerTodos())
{
    Console.WriteLine(
        $"{producto.Id} - {producto.Nombre} - {producto.Precio}"
    );
}
