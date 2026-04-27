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
            if (Existe(t)) throw new ArgumentException("Triangulo existente");
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
        public bool Existe(Triangulo t)
        {
            var listaTriangulos = _repo.GetLista();
            return listaTriangulos.Any(x=>
                x.TrianguloId!=t.TrianguloId &&
                (x.Lado1==t.Lado1 && x.Lado2==t.Lado2 && x.Lado3==t.Lado3));
        }
    }
}
