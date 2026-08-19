using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCadoppiEjercitaciónInterfazGráfica
{
    public partial class frmCajaDeTexto : Form
    {
        public frmCajaDeTexto()
        {
            InitializeComponent();
        }

        private void frmCajaDeTexto_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código: " + txtCodigo.Text + " \nMedicamento: " + txtMedicamento.Text + "\nLaboratorio: " + txtLaboratorio.Text + "\nCategoría: " + txtCategoria.Text + "\nPrecio: $" + txtPrecio.Text);
        }
    }
}
