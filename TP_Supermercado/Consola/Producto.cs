namespace TP_Supermercado;

public class Producto
{
    public string Nombre;
    public decimal PrecioUnitario;
    public int Cantidad;

    public Producto(string nombre, decimal precioUnitario, int cantidad)
    {
        this.Nombre = nombre;
        this.PrecioUnitario = precioUnitario;
        this.Cantidad = cantidad;
    }
}