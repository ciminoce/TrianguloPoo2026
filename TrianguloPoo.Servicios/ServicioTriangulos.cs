using TrianguloPoo2026.Datos;
using TrianguloPoo2026.Entidades;

namespace TrianguloPoo.Servicios
{
    public class ServicioTriangulos
    {
        private readonly RepositorioTriangulos _repo;

        public ServicioTriangulos()
        {
            _repo = new RepositorioTriangulos();

        }
        public void Borrar(Triangulo t)
        {
            _repo.Borrar(t);
        }
        public void Agregar(Triangulo t)
        {
            _repo.Agregar(t);
        }
        public List<Triangulo> GetLista()
        {
            return _repo.GetLista();
        }
        public int GetCantidad()
        {
            return _repo.Cantidad();
        }
    }
}
