using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados");
            ClsRepuestos objR = new ClsRepuestos();
            objR.Código = txtCodigo.Text;
            objR.Nombre = txtNombre.Text;
            objR.Marca = lstMarca.Text;
            objR.Precio = txtPrecio.Text;
            if (optNacional.Checked = true)
            {
                objR.Origen = "Nacional";
            }
            else
            {
                objR.Origen = "Importado";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar los TextBox
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;

            lstMarca.SelectedItem = null;
            optNacional.Checked = true;
            txtCodigo.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultaRepuestos frm = new FrmConsultaRepuestos();
            frm.Show(); 
        }
    }
}
