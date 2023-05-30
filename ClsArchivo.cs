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
        public string NombreArchivo { get; set; }

        //Métodos
        public bool GuardarRepuesto(ClsRepuestos nuevoRep)
        {
            // recibe un objeto de tipo Repuesto y lo graba en el archivo
            bool resultado = false;
            // crea el stream en modo append
            StreamWriter sw = new StreamWriter("Repuestos.txt", true);
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

            StreamReader sr = new StreamReader("Repuestos.txt");
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
        public List<ClsRepuestos> ObtenerRepuestos()
        {
            // lee el contenido completo del archivo y lo
            // almacena en una lista de objetos 'Repuesto'
            List<ClsRepuestos> Lista = new List<ClsRepuestos>();
            string Linea;
            if ("Repuestos.txt" != "" && File.Exists("Repuestos.txt"))
            {
                StreamReader sr = new StreamReader("Repuestos.txt");
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea del archivo
                                           // crea un objeto 'Repuesto' y rellena sus propiedades
                    ClsRepuestos repuesto = new ClsRepuestos();
                    repuesto.Código = Linea.Split(',')[0];
                    repuesto.Nombre = Linea.Split(',')[1];
                    repuesto.Marca = Linea.Split(',')[2];
                    repuesto.Precio = Linea.Split(',')[3];
                    repuesto.Origen = Linea.Split(',')[4];
                    Lista.Add(repuesto); // se agrega el repuesto a la lista
                }
                sr.Close(); // cerrar
                sr.Dispose(); // liberar recursos
            }
            // devuelve la lista de repuestos completa
            return Lista;
        }
        public List<ClsRepuestos> ObtenerRepuestosOrdenados()
        {
            // lee el contenido completo del archivo y lo
            // almacena en una lista de objetos 'Repuesto'
            List<ClsRepuestos> Lista = ObtenerRepuestos();
            // convertir la lista en un arreglo con el método "ToArray()"
            ClsRepuestos[] repuestosArray = Lista.ToArray();
            // ordenar el arreglo con el método de Burbuja
            // por el campo Nombre en forma ascendente (de menor a mayor)
            for (int i = 0; i < repuestosArray.Length - 1; i++)
            {
                for (int j = 0; j < repuestosArray.Length - 1; j++)
                {
                    // se comparan los nombres de los repuestos
                    // usando el método 'Compare' de la clase string
                    if (string.Compare(repuestosArray[j].Nombre,
                    repuestosArray[j + 1].Nombre) > 0)
                    {
                        // se intercambian si el nombre en j es mayor al nombre en j+1
                        ClsRepuestos aux = repuestosArray[j];
                        repuestosArray[j] = repuestosArray[j + 1];
                        repuestosArray[j + 1] = aux;
                    }
                }
            }
            // convertir el arreglo ya ordenado en una lista
            List<ClsRepuestos> Ordenados = repuestosArray.ToList<ClsRepuestos>();
            // devuelve la lista de respuestos ordenada por nombre en forma ascendente
            return Ordenados;
        }
    }
}


