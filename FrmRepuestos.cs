using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaRepuestos._2
{
    public partial class FrmAutocorRepuestos : Form
    {
        public FrmAutocorRepuestos()
        {
            InitializeComponent();
        }

        private void FrmAutocorRepuestos_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        { //Cierra el formulario
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Para que solo acepte un punto de decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void Inicializar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            lstMarca.SelectedItem = null;
            txtPrecio.Text = "";
            optNacional.Checked = true;
            txtCodigo.Focus();
        }
        public void ChequearDatosIngresados()
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" ||
                lstMarca.SelectedItem == null)
            {
                MessageBox.Show("Completar correctamente los datos del repuesto.");
            }
            ClsRepuestos rep = new ClsRepuestos();
            rep.VerificarCódigoRepetido(txtCodigo.Text);
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados");
            ClsRepuestos objR = new ClsRepuestos();
            objR.Código = txtCodigo.Text;
            objR.Nombre = txtNombre.Text;
            objR.Marca = lstMarca.Text;
            objR.Precio = txtPrecio.Text;
            
            if (optNacional.Checked == true)
            {
                objR.Origen = "Nacional";
            }
            else
            {
                objR.Origen = "Importado";
            }
            ChequearDatosIngresados();
            Inicializar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultaRepuestos frm = new FrmConsultaRepuestos();
            frm.Show(); 
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
