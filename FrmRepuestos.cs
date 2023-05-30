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
        // definimos en nombre del archivo en una constante
        private const string PATH_ARCHIVO = "Repuestos.txt";

        public FrmAutocorRepuestos()
        {
            InitializeComponent();
        }

        private void FrmAutocorRepuestos_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {   // solo se pueden ingresar numeros
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            // Para que solo acepte un punto de decimal
            if ((e.KeyChar == '.') && txtPrecio.Text.Contains('.'))
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
        public bool ChequearDatosIngresados()
        {
            // devuelve falso si no se cumplen todas las condiciones
            bool resultado = false;
            if (txtCodigo.Text != "") // controla el valor del código
            {
                if (txtNombre.Text != "") // controla el nombre
                {
                    if (txtPrecio.Text != "") // controla el precio
                    {
                        ClsArchivo Repuestos = new ClsArchivo();
                        // controla que no se repita el código del repuesto
                        if (Repuestos.VerificarCódigoRepetido(txtCodigo.Text) == false)
                        {
                            resultado = true; // devuelve verdadero sólo si todas
                                              // las condiciones se cumplieron
                        }
                    }
                }
            }
            return resultado;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {     // si los datos son correctos
            if (ChequearDatosIngresados()) 
            {
                // crear nuevo repuesto
                ClsRepuestos nuevoRep = CrearRepuesto();
                // guardar en el archivo
                ClsArchivo Repuestos = new ClsArchivo();
                Repuestos.GuardarRepuesto(nuevoRep);
                Inicializar();
            }
            // si hay algún error
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
        private ClsRepuestos CrearRepuesto()
        {
            ClsRepuestos nuevoRep = new ClsRepuestos();
            nuevoRep.Código = txtCodigo.Text;
            nuevoRep.Nombre = txtNombre.Text;
            nuevoRep.Marca = lstMarca.SelectedItem.ToString();
            nuevoRep.Precio = txtPrecio.Text;
            if (optNacional.Checked)
            {
                nuevoRep.Origen = "Nacional";
            }
            else
            {
                nuevoRep.Origen = "Importado";
            }
            return nuevoRep; // devuelve el objeto creado
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
