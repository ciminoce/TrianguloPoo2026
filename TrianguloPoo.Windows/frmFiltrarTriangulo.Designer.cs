namespace TrianguloPoo.Windows
{
    partial class frmFiltrarTriangulo
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cboTipos = new ComboBox();
            btnOK = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipos de Triángulos:";
            // 
            // cboTipos
            // 
            cboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipos.FormattingEnabled = true;
            cboTipos.Location = new Point(160, 44);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(121, 23);
            cboTipos.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(124, 87);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 54);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmFiltrarTriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 157);
            Controls.Add(btnOK);
            Controls.Add(cboTipos);
            Controls.Add(label1);
            MaximumSize = new Size(339, 196);
            MinimumSize = new Size(339, 196);
            Name = "frmFiltrarTriangulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFiltrarTriangulo";
            Load += frmFiltrarTriangulo_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTipos;
        private Button btnOK;
        private ErrorProvider errorProvider1;
    }
}