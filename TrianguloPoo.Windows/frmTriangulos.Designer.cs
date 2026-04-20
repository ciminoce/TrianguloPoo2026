namespace TrianguloPoo.Windows
{
    partial class frmTriangulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvTriangulos = new DataGridView();
            colLado1 = new DataGridViewTextBoxColumn();
            colLado2 = new DataGridViewTextBoxColumn();
            colLado3 = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblCantidad = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTriangulos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.new_file_48px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(52, 67);
            tsbNuevo.Text = "&Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_48px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(52, 67);
            tsbBorrar.Text = "&Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_48px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 67);
            tsbEditar.Text = "&Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.filter_48px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(52, 67);
            tsbFiltrar.Text = "&Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.restart_48px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 67);
            tsbActualizar.Text = "&Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = Properties.Resources.close_pane_48px;
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(52, 67);
            tsbCerrar.Text = "&Cerrar";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 70);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvTriangulos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblCantidad);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 380);
            splitContainer1.SplitterDistance = 321;
            splitContainer1.TabIndex = 1;
            // 
            // dgvTriangulos
            // 
            dgvTriangulos.AllowUserToAddRows = false;
            dgvTriangulos.AllowUserToDeleteRows = false;
            dgvTriangulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTriangulos.Columns.AddRange(new DataGridViewColumn[] { colLado1, colLado2, colLado3, colPerimetro, colArea, colTipo });
            dgvTriangulos.Dock = DockStyle.Fill;
            dgvTriangulos.Location = new Point(0, 0);
            dgvTriangulos.Name = "dgvTriangulos";
            dgvTriangulos.ReadOnly = true;
            dgvTriangulos.Size = new Size(800, 321);
            dgvTriangulos.TabIndex = 0;
            // 
            // colLado1
            // 
            colLado1.HeaderText = "Lado 1";
            colLado1.Name = "colLado1";
            colLado1.ReadOnly = true;
            // 
            // colLado2
            // 
            colLado2.HeaderText = "Lado 2";
            colLado2.Name = "colLado2";
            colLado2.ReadOnly = true;
            // 
            // colLado3
            // 
            colLado3.HeaderText = "Lado3";
            colLado3.Name = "colLado3";
            colLado3.ReadOnly = true;
            // 
            // colPerimetro
            // 
            colPerimetro.HeaderText = "Perímetro";
            colPerimetro.Name = "colPerimetro";
            colPerimetro.ReadOnly = true;
            // 
            // colArea
            // 
            colArea.HeaderText = "Área";
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(93, 18);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(14, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "0";
            // 
            // frmTriangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmTriangulos";
            Text = "frmTriangulos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTriangulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbCerrar;
        private SplitContainer splitContainer1;
        private DataGridView dgvTriangulos;
        private DataGridViewTextBoxColumn colLado1;
        private DataGridViewTextBoxColumn colLado2;
        private DataGridViewTextBoxColumn colLado3;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colTipo;
        private Label lblCantidad;
        private Label label1;
    }
}