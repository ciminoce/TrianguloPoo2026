namespace TrianguloPoo2026.Entidades
{
    public class Triangulo
    {
        public Guid TrianguloId { get;}
        public double Lado1 { get; }
        public double Lado2 { get; }
        public double Lado3 { get; }
        public Triangulo(double l1, double l2, double l3):
            this(Guid.NewGuid(), l1, l2, l3)
        {

        }
        public Triangulo(Guid id, double l1, double l2, double l3)
        {
            if (!EsValido(l1, l2, l3))
            {
                throw new ArgumentException("La suma de los lados debe ser superior al tercero y positivos");
            }
            var lados = new[] { l1, l2, l3 };
            Array.Sort(lados);
            TrianguloId = id;
            Lado1 = lados[0];
            Lado2 = lados[1];
            Lado3 = lados[2];

        }
        private bool EsValido(double l1, double l2, double l3)
		{
			return (l1 > 0 && l2 > 0 && l3 >0) && 
				(l1 + l2 > l3) && (l1 + l3 > l2)
				&& (l2 + l3 > l1);

        }
		public double Perimetro
		{
			get
			{
				return Lado1 + Lado2 + Lado3;
            }
		}
		public double Area
		{
			get
			{
                double sP = Perimetro / 2;
                return Math.Sqrt(sP * (sP - Lado1) * (sP - Lado2) * (sP - Lado3));

            }
        }
		public TipoTriangulo Tipo
		{
			get
			{
                if (Lado1 == Lado2 && Lado2 == Lado3) return TipoTriangulo.Equilátero;
                if (Lado1 != Lado2 && Lado1 != Lado3 && Lado2 != Lado3) return TipoTriangulo.Escaleno;
                return TipoTriangulo.Isósceles;

            }
        }

        public override string ToString()
        {
			return $"Lado 1: {Lado1} Lado 2: {Lado2} Lado 3: {Lado3}";
        }
    }
}
