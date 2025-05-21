using TP_Supermercado;

Producto productos = new Producto("manteca", 1500m, 10);

// Alta de productos
productos.alta("Yerba", 1500, 10);
productos.alta("Fideos", 800, 20);
productos.alta("Arroz", 950, 15);


// Modificar producto
productos.modificacion("Fideos", 850m, 10);

// Eliminar producto
productos.baja("Arroz");


// Intentar modificar un producto inexistente
productos.modificacion("Pan", 300m, 5);

// Intentar eliminar un producto inexistente
productos.baja("Azúcar");

Console.WriteLine("\nPresiona una tecla para salir...");
Console.ReadKey();

