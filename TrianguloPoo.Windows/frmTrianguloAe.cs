using System.Globalization;
using TrianguloPoo2026.Entidades;

namespace TrianguloPoo.Windows
{
    public partial class frmTrianguloAe : Form
    {
        private Triangulo? triangulo;
        public frmTrianguloAe()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (triangulo == null) return;
            txtLado1.Text = triangulo.Lado1.ToString();
            txtLado2.Text = triangulo.Lado2.ToString();
            txtLado3.Text = triangulo.Lado3.ToString();

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(out double l1, out double l2, out double l3))
            {
                try
                {
                    //double l1 = double.Parse(txtLado1.Text);
                    //double l2 = double.Parse(txtLado2.Text);
                    //double l3 = double.Parse(txtLado3.Text);

                    triangulo = new Triangulo(l1, l2, l3);
                    MessageBox.Show("Triángulo creado satisfactoriamente",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos(out double l1, out double l2, out double l3)
        {
            bool esValido = true;
            errorProvider1.Clear();
            if(!double.TryParse(txtLado1.Text,CultureInfo.InvariantCulture, out l1))
            {
                esValido = false;
                errorProvider1.SetError(txtLado1, "Número no válido");
            }
            if (!double.TryParse(txtLado2.Text, CultureInfo.InvariantCulture, out l2))
            {
                esValido = false;
                errorProvider1.SetError(txtLado2, "Número no válido");
            }
            if (!double.TryParse(txtLado3.Text, CultureInfo.InvariantCulture, out l3))
            {
                esValido = false;
                errorProvider1.SetError(txtLado3, "Número no válido");
            }

            return esValido;
        }
        public Triangulo? GetTriangulo()
        {
            return triangulo;
        }
        public void SetTriangulo(Triangulo t)
        {
            triangulo = t;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
