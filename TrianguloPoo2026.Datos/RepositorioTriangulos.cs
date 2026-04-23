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
            _triangulos.Remove(t);
            GuardarTodo();
        }

        private void GuardarTodo()
        {
            var lineas = _triangulos.Select(t => $"{t.TrianguloId}|{t.Lado1}|{t.Lado2}|{t.Lado3}");
            File.WriteAllLines(_rutaArchivo, lineas);
        }

        public void Agregar(Triangulo t)
        {
            _triangulos.Add(t);
            using (var escritor=new StreamWriter(_rutaArchivo,true))
            {
                string linea = ConstruirLinea(t);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(Triangulo t)
        {
            return $"{t.TrianguloId}|{t.Lado1}|{t.Lado2}|{t.Lado3}";
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
    }
}
