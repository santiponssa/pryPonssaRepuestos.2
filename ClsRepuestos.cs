using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaRepuestos._2
{
    internal class ClsRepuestos
    {
         //Propiedades
         public string Código { get; set; }
         public string Nombre { get; set; }
         public string Marca { get; set; }
         public int Precio { get; set; }
         public string Origen { get; set; }
        
         //Métodos
         public void GuardarRepuesto()
        {
            StreamWriter sw = new StreamWriter("REPUESTOS.txt", false);
            sw.WriteLine(Código + "," + Nombre + "," + Marca + "," + Precio + "," + Origen);
        }
    }
}
