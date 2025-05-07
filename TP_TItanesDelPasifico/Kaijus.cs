namespace TP_TItanesDelPasifico
{
    public class Kaijus
    {
        public string Nombre;
        public List<Habilidad> Habilidades;
        public Categoria categoria;
        public float Peso;
        public float Tamaño;

        
        public Kaijus(string Nombre, List<Habilidad> Habilidades, Categoria categoria, float Peso, float Tamaño)
    {
        this.Nombre = Nombre;
        this.Habilidades = Habilidades;
        this.categoria = categoria;
        this.Peso = Peso;
        this.Tamaño = Tamaño;
    }

    public int danioTotalDeHabilidades(List<Habilidades> habilidades)
    {
        int danioTotal = 0;

        for (int i = 0; i < habilidades.Cont; i++)
        {
            danioTotal += habilidades[i].danio;
        }

        return danioTotal;

    }




    }


}