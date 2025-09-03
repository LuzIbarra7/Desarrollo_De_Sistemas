namespace Prueba
{
public class GestorTareas
{
    private readonly List<string> _tareas = new List<string>();

    public void Agregar(string tarea)
    {
        if (string.IsNullOrWhiteSpace(tarea))
            throw new ArgumentException("La tarea no puede estar vacía");

        _tareas.Add(tarea);
    }

    public bool Eliminar(string tarea)
    {
        return _tareas.Remove(tarea);
    }

    public List<string> Listar()
    {
        return _tareas.ToList();
    }

    public bool Existe(string tarea)
    {
        return _tareas.Contains(tarea);
    }
}

    }
