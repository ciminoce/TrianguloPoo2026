using System.Globalization;
using TrianguloPoo2026.Entidades;

namespace TrianguloPoo2026.Datos
{
    public class RepositorioTriangulos
    {
        private List<Triangulo> _triangulos;
        private readonly string _rutaArchivo = "Triangulos.txt";
        public RepositorioTriangulos()
        {
            _triangulos = LeerArchivo();
        }
        public void Borrar(Triangulo t)
        {
            var trianguloEnLista = GetById(t.TrianguloId);
            if (trianguloEnLista==null)
            {
                throw new ArgumentException("Triangulo no encontrado");
            }
            _triangulos.Remove(t);
            GuardarTodo(_triangulos);
        }

        public void GuardarTodo(List<Triangulo> lista)
        {
            var lineas = lista.Select(t => ConstruirLinea(t));
            File.WriteAllLines(_rutaArchivo, lineas);
        }

        public void Agregar(Triangulo t)
        {
            _triangulos.Add(t);

            string linea = ConstruirLinea(t);

            File.AppendAllLines(_rutaArchivo, new[] { linea });
        }

        private string ConstruirLinea(Triangulo t)
        {
            string lado1=t.Lado1.ToString(CultureInfo.InvariantCulture);
            string lado2 = t.Lado2.ToString(CultureInfo.InvariantCulture);
            string lado3 = t.Lado3.ToString(CultureInfo.InvariantCulture);
            return $"{t.TrianguloId}|{lado1}|{lado2}|{lado3}";
        } 
        public Triangulo? GetById(Guid id)
        {
            return _triangulos.FirstOrDefault(t => t.TrianguloId == id);
        }
        public List<Triangulo> GetLista() => _triangulos;
        public int Cantidad() => _triangulos.Count;
        private List<Triangulo> LeerArchivo()
        {
            List<Triangulo> lista = new List<Triangulo>();
            if (File.Exists(_rutaArchivo))
            {
                using (var lector = new StreamReader(_rutaArchivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string? lineaLeida = lector.ReadLine();
                        if (lineaLeida != null)
                        {
                            Triangulo? t = ConstruirTriangulo(lineaLeida);
                            if (t is not null)
                            {
                                lista.Add(t);
                            }
                        }

                    }
                }
            }
            return lista;
        }

        private Triangulo? ConstruirTriangulo(string lineaLeida)
        {
            var campos=lineaLeida.Split('|');
            if (campos.Length != 4) return null;
            if (!Guid.TryParse(campos[0],out var id))return null;
            if (!double.TryParse(campos[1], CultureInfo.InvariantCulture, out var l1)) return null;
            if (!double.TryParse(campos[2], CultureInfo.InvariantCulture, out var l2)) return null;
            if (!double.TryParse(campos[3], CultureInfo.InvariantCulture, out var l3)) return null;
            try
            {
                return new Triangulo(id,l1, l2, l3);

            }
            catch (Exception)
            {

                return null;
            }
        }
        public void Editar(Triangulo triangulo)
        {
            var index = _triangulos
                .FindIndex(t => t.TrianguloId == triangulo.TrianguloId);
            if (index != -1)
            {
                _triangulos[index] = triangulo;
                GuardarTodo(_triangulos);
            }
            else
            {
                throw new Exception("Triángulo no encontrado");
            }

        }
    }
}
