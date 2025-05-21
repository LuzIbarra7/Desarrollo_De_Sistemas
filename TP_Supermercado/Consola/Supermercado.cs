namespace TP_Supermercado;

public class Supermercado
{
    public List<Producto> productos = new List<Producto>();


    void alta(string Nombre, decimal PrecioUnitario, int Cantidad)
    {
        Producto nuevo = new Producto(Nombre, PrecioUnitario, Cantidad);

        productos.Add(nuevo);
    }

    void baja(string Nombre)
    {
        foreach (Producto p in productos)
        {
            if (p.Nombre == Nombre)
            {
                productos.Remove(p);
                Console.WriteLine($"Producto '{Nombre}' eliminado correctamente.");
                return;
            }
        }

        Console.WriteLine($"Error: El producto '{Nombre}' no existe.");
    }

    void modificacion(string Nombre, decimal nuevoPrecio, int cantidad)
    {
        foreach (Producto p in productos)
        {
            if (p.Nombre == Nombre)
            {
                p.PrecioUnitario = nuevoPrecio;
                p.Cantidad += cantidad;
                Console.WriteLine($"Producto '{Nombre}' modificado correctamente.");
                return;
            }
        }

        Console.WriteLine($"Error: El producto '{Nombre}' no existe.");
    }

}