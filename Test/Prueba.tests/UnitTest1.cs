using Prueba;

namespace Prueba.tests
{
    public class UnitTest1
    {
        private readonly GestorTareas _gestor;

        public UnitTest1()
        {
            _gestor = new GestorTareas();
        }

        [Fact]
        public void Agregar_TareaValida_DeberiaGuardarla()
        {
            _gestor.Agregar("Estudiar C#");
            Assert.True(_gestor.Existe("Estudiar C#"));
        }

        [Fact]
        public void Agregar_TareaVacia_DeberiaLanzarExcepcion()
        {
            Assert.Throws<ArgumentException>(() => _gestor.Agregar(""));
        }

        [Fact]
        public void Eliminar_TareaExistente_DeberiaRetornarTrue()
        {
            _gestor.Agregar("Comprar pan");
            var resultado = _gestor.Eliminar("Comprar pan");
            Assert.True(resultado);
        }

        [Fact]
        public void Listar_DeberiaRetornarTodasLasTareas()
        {
            _gestor.Agregar("Tarea 1");
            _gestor.Agregar("Tarea 2");
            var lista = _gestor.Listar();

            Assert.Equal(2, lista.Count);
            Assert.Contains("Tarea 1", lista);
        }
    }
}


