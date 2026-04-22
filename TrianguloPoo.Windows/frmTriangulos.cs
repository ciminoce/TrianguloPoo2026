using TrianguloPoo.Servicios;
using TrianguloPoo2026.Entidades;

namespace TrianguloPoo.Windows
{
    public partial class frmTriangulos : Form
    {
        private readonly ServicioTriangulos _servicio;
        private List<Triangulo>? _listaTriangulos;
        public frmTriangulos()
        {
            _servicio = new ServicioTriangulos();
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmTrianguloAe() { Text = "Nuevo Triángulo" })
            {
                DialogResult dr =
                    frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    Triangulo? triangulo = frm.GetTriangulo();
                    if (triangulo == null) return;

                    DataGridViewRow r = CrearFila(dgvTriangulos);

                    SetearFila(r, triangulo);

                    AgregarFila(dgvTriangulos, r);

                    _servicio.Agregar(triangulo);
                    lblCantidad.Text = _servicio.GetCantidad().ToString();
                }
                else
                {
                    MessageBox.Show("Joder!!");
                }
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTriangulos_Load(object sender, EventArgs e)
        {
            _listaTriangulos = _servicio.GetLista();
            if (_listaTriangulos.Count == 0)
            {
                MessageBox.Show("No se han guardado registros todavía",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (_listaTriangulos is null) return;
            foreach (Triangulo t in _listaTriangulos)
            {
                var r = CrearFila(dgvTriangulos);
                SetearFila(r, t);

                AgregarFila(dgvTriangulos, r);
            }
        }
        //Métodos de la grilla
        public DataGridViewRow CrearFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;
        }
        public void SetearFila(DataGridViewRow r, Triangulo t)
        {
            r.Cells[0].Value = t.TrianguloId.ToString()[..8];
            r.Cells[1].Value = t.Lado1;
            r.Cells[2].Value = t.Lado2;
            r.Cells[3].Value = t.Lado3;

            r.Cells[4].Value = t.Perimetro;
            r.Cells[5].Value = t.Area;
            r.Cells[6].Value = t.Tipo;

            //Agregado para luego borrar y/o modificar
            r.Tag = t;
        }
        public void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }
    }
}
