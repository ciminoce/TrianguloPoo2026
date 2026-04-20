using TrianguloPoo2026.Entidades;

namespace TrianguloPoo2026.Datos
{
    public class RepositorioTriangulos
    {
        private List<Triangulo> _triangulos;
        public RepositorioTriangulos()
        {
            _triangulos = new List<Triangulo>();
        }
        public void Agregar(Triangulo t)
        {
            _triangulos.Add(t);
        }
        public List<Triangulo> GetLista() => _triangulos;
        public int Cantidad() => _triangulos.Count;
    }
}
