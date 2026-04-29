using TrianguloPoo2026.Entidades;

namespace TrianguloPoo.Windows
{
    public partial class frmFiltrarTriangulo : Form
    {
        private TipoTriangulo? tipo;
        public frmFiltrarTriangulo()
        {
            InitializeComponent();
        }

        private void frmFiltrarTriangulo_Load(object sender, EventArgs e)
        {
            CargarDatosCombo();
        }

        private void CargarDatosCombo()
        {
            cboTipos.Items.Add("Seleccione");
            foreach (TipoTriangulo tipo in Enum.GetValues(typeof(TipoTriangulo)))
            {
                cboTipos.Items.Add(tipo);
            }
            cboTipos.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cboTipos.SelectedItem!=null)
                {
                    tipo = (TipoTriangulo)cboTipos.SelectedItem;
                    DialogResult = DialogResult.OK;
                } 
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (cboTipos.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(cboTipos, "Debe seleccionar un tipo");
            }
            return valido;
        }
        public TipoTriangulo? GetTipo()
        {
            return tipo;
        }
    }
}
