using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaRepuestos._2
{
    public class ClsRepuestos
    {
         //Propiedades
         public string Código { get; set; }
         public string Nombre { get; set; }
         public string Marca { get; set; }
         public string Precio { get; set; }
         public string Origen { get; set; }
        
         //Métodos
         public void GuardarRepuesto()
         {
            StreamWriter sw = new StreamWriter("REPUESTOS.txt", false);
            sw.WriteLine(Código + "," + Nombre + "," + Marca + "," + Precio + "," + Origen);
            sw.Close();
            sw.Dispose();
         }
        public void VerificarCódigo()
        {
            StreamReader sr = new StreamReader("REPUESTOS.txt");
            sr.ReadToEnd();
            if (Código == sr.ReadLine())
            {

            }
        }
    }
}
