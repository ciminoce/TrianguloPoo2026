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

        public void Editar(Triangulo triangulo)
        {
            var listaTriangulos = _repo.GetLista();
            if (!Existe(triangulo))
            {
                var index = listaTriangulos
            .FindIndex(t => t.TrianguloId == triangulo.TrianguloId);
                if (index != -1)
                {
                    listaTriangulos[index] = triangulo;
                    _repo.GuardarTodo(listaTriangulos);
                }
                else
                {
                    throw new Exception("Triángulo no encontrado");
                }

            }
            else
            {
                throw new Exception("Triángulo existente");
            }
        }
    }
}
