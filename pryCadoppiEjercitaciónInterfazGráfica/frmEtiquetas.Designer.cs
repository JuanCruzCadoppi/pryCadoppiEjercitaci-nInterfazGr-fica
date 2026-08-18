namespace pryCadoppiEjercitaciónInterfazGráfica
{
    partial class frmEtiquetas
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
            lblAltaDeMedicamento = new Label();
            lblCodigo = new Label();
            lblMedicamento = new Label();
            lblLaboratorio = new Label();
            lblCategoria = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // lblAltaDeMedicamento
            // 
            lblAltaDeMedicamento.AutoSize = true;
            lblAltaDeMedicamento.Location = new Point(99, 18);
            lblAltaDeMedicamento.Name = "lblAltaDeMedicamento";
            lblAltaDeMedicamento.Size = new Size(121, 15);
            lblAltaDeMedicamento.TabIndex = 0;
            lblAltaDeMedicamento.Text = "Alta de medicamento";
            lblAltaDeMedicamento.Click += lblAltaDeMedicamento_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(55, 58);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(55, 89);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(81, 15);
            lblMedicamento.TabIndex = 2;
            lblMedicamento.Text = "Medicamento";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(55, 120);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 3;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(55, 151);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(55, 182);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // frmEtiquetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 233);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblCodigo);
            Controls.Add(lblAltaDeMedicamento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEtiquetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacia";
            Load += frmEtiquetas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaDeMedicamento;
        private Label lblCodigo;
        private Label lblMedicamento;
        private Label lblLaboratorio;
        private Label lblCategoria;
        private Label lblPrecio;
    }
}