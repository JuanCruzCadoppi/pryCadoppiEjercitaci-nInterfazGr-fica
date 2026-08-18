namespace pryCadoppiEjercitaciónInterfazGráfica
{
    partial class frmCajaDeTexto
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
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblLaboratorio = new Label();
            lblMedicamento = new Label();
            lblCodigo = new Label();
            lblAltaDeMedicamento = new Label();
            txtCodigo = new TextBox();
            txtMedicamento = new TextBox();
            txtLaboratorio = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(52, 200);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(52, 169);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoría";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(52, 138);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 9;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(52, 107);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(81, 15);
            lblMedicamento.TabIndex = 8;
            lblMedicamento.Text = "Medicamento";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(52, 76);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Código";
            // 
            // lblAltaDeMedicamento
            // 
            lblAltaDeMedicamento.AutoSize = true;
            lblAltaDeMedicamento.Location = new Point(96, 36);
            lblAltaDeMedicamento.Name = "lblAltaDeMedicamento";
            lblAltaDeMedicamento.Size = new Size(121, 15);
            lblAltaDeMedicamento.TabIndex = 6;
            lblAltaDeMedicamento.Text = "Alta de medicamento";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(159, 68);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 12;
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(159, 99);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(100, 23);
            txtMedicamento.TabIndex = 13;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(159, 130);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(100, 23);
            txtLaboratorio.TabIndex = 14;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(159, 161);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 15;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(159, 192);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 16;
            // 
            // frmCajaDeTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 258);
            Controls.Add(txtPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtMedicamento);
            Controls.Add(txtCodigo);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblCodigo);
            Controls.Add(lblAltaDeMedicamento);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCajaDeTexto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacia versión 2";
            Load += frmCajaDeTexto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblLaboratorio;
        private Label lblMedicamento;
        private Label lblCodigo;
        private Label lblAltaDeMedicamento;
        private TextBox txtCodigo;
        private TextBox txtMedicamento;
        private TextBox txtLaboratorio;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
    }
}