namespace TrianguloPoo.Windows
{
    partial class frmTrianguloAe
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
            txtLado1 = new TextBox();
            label2 = new Label();
            txtLado2 = new TextBox();
            label3 = new Label();
            txtLado3 = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 18);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado 1:";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(90, 15);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(100, 23);
            txtLado1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 47);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Lado 2:";
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(90, 44);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(100, 23);
            txtLado2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 76);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Lado 3:";
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(90, 73);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(100, 23);
            txtLado3.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(41, 124);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 54);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(170, 124);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 54);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTrianguloAe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 222);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtLado3);
            Controls.Add(label3);
            Controls.Add(txtLado2);
            Controls.Add(label2);
            Controls.Add(txtLado1);
            Controls.Add(label1);
            MaximumSize = new Size(305, 261);
            MinimumSize = new Size(305, 261);
            Name = "frmTrianguloAe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrianguloAe";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLado1;
        private Label label2;
        private TextBox txtLado2;
        private Label label3;
        private TextBox txtLado3;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}