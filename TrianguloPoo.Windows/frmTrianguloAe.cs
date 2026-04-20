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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                try
                {
                    double l1 = double.Parse(txtLado1.Text);
                    double l2 = double.Parse(txtLado2.Text);
                    double l3 = double.Parse(txtLado3.Text);

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

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            return esValido;
        }
        public Triangulo? GetTriangulo()
        {
            return triangulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
