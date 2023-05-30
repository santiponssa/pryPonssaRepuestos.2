using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace pryPonssaRepuestos._2
{
    public class ClsArchivo
    {
        //Métodos
        public bool GuardarRepuesto(ClsRepuestos nuevoRep)
        {
            // recibe un objeto de tipo Repuesto y lo graba en el archivo
            bool resultado = false;
            // crea el stream en modo append
            StreamWriter sw = new StreamWriter("REPUESTOS.txt", true);
            // graba la linea con los valores de los campos
            sw.WriteLine(nuevoRep.Código + "," + nuevoRep.Nombre + "," +
                         nuevoRep.Marca + "," + nuevoRep.Precio + "," +
                         nuevoRep.Origen);
            sw.Close();
            sw.Dispose();
            resultado = true;
            return resultado;
        }
        public bool VerificarCódigoRepetido(string Código)
        {
         //recibe el código de repuesto a buscar, devuelve falso si el código no existe y
         //verdadero si el código ya está guardado
            bool resultado = false;
            string Linea;
            string CodigoRepuesto;
            StreamReader sr = new StreamReader("REPUESTOS.txt");
            while (sr.EndOfStream == false)
            {
                Linea = sr.ReadLine();
                CodigoRepuesto = Linea.Split(',')[0];
                if (Código == CodigoRepuesto)
                {
                    resultado = true;
                    break; //sale del ciclo de lectura
                }
            }
            sr.Close();
            sr.Dispose();
            return resultado;
        }
    }
}
