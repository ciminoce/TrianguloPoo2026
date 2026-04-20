namespace TrianguloPoo2026.Entidades
{
    public class Triangulo
    {
		private double lado1;

		public double Lado1
		{
			get { return lado1; }
			set { lado1 = value; }
		}
		private double lado2;

		public double Lado2
		{
			get { return lado2; }
			set { lado2 = value; }
		}
		private double lado3;

		public double Lado3
		{
			get { return lado3; }
			set { lado3 = value; }
		}
        public Triangulo(double l1, double l2, double l3)
        {
			if(l1<=0 || l2<=0 || l3 <= 0)
			{
				throw new ArgumentException("Los lados deben ser positivos");
			}
			if (!EsValido(l1,l2,l3))
			{
				throw new ArgumentException("La suma de los lados debe ser superior al tercero");

			}
            Lado1 = l1;
            Lado2 = l2;
            Lado3 = l3;

        }
        private bool EsValido(double l1, double l2, double l3)
		{
			return (l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1);

        }
		public double GetPerimetro()=>lado1+lado2+lado3;
		public double GetArea()
		{
			double sP = GetPerimetro() / 2;
			return Math.Sqrt(sP * (sP - lado1) * (sP - lado2) * (sP - lado3));
		}
		public string GetTipo()
		{
			if(lado1==lado2 && lado2 == lado3)
			{
				return "Equilátero";
			}else if(lado1!=lado2 && lado1!=lado3 && lado2!= lado3)
			{
				return "Escaleno";
			}
			return "Isósceles";
		}
        public override string ToString()
        {
			return $"Lado 1: {lado1} Lado 2: {lado2} Lado 3: {lado3}";
        }
    }
}
