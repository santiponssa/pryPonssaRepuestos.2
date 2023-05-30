using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaRepuestos._2
{
    public class ClsRepuestos
    {
         //Propiedades del repuesto
         public string Código { get; set; }
         public string Nombre { get; set; }
         public string Marca { get; set; }
         public float Precio { get; set; }
         public string Origen { get; set; }

        //Métodos
        public void GuardarRepuesto()
        {
            StreamWriter sw = new StreamWriter("REPUESTOS.txt", true);
            sw.WriteLine(Código + "," + Nombre + "," + Marca + "," + 
                         Precio.ToString() + "," + Origen);
            sw.Close();
            sw.Dispose();
        }
        public void VerificarCódigoRepetido()
        {
            string Linea;
            StreamReader sr = new StreamReader("REPUESTOS.txt");
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                if (Código == Linea.Split(',')[0])
                {
                    MessageBox.Show("Código de repuesto repetido");
                    break;
                }
            }
            sr.Close();
            sr.Dispose();
        }
    }
}
