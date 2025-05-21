namespace TP_Supermercado;

public class Producto
{
    public string Nombre;
    public decimal PrecioUnitario;
    public int Cantidad;
    public List<Producto> productos = new List<Producto>();

    public Producto(string nombre, decimal precioUnitario, int cantidad)
    {
        this.Nombre = nombre;
        this.PrecioUnitario = precioUnitario;
        this.Cantidad = cantidad;
    }

    public void alta(string Nombre, decimal PrecioUnitario, int Cantidad)
    {
        Producto nuevo = new Producto(Nombre, PrecioUnitario, Cantidad);

        productos.Add(nuevo);
    }

    public void baja(string Nombre)
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

    public void modificacion(string Nombre, decimal nuevoPrecio, int cantidad)
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