using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_Promedio_Mediana_Modo_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> datos = new List<int> { 15, 11, 17, 13, 17, 14, 12, 18, 17, 17, 20, 13, 18, 15, 17, 11, 19, 20, 14, 11 };

            Console.WriteLine($"lA MEDIA ES {CalcularMedia(datos)}");
            Console.WriteLine($"lA MEDIANA ES {CalcularMediana(datos)}");
            CalcularModa(datos);


            Console.ReadKey();
        }

        static List<int> CalcularModa(List<int> datos)
        {
            List<int> modas = new List<int>();
            Dictionary<int, int> frecuenciaDatos = new Dictionary<int, int>();
            foreach (int dato in datos)
            {
                if (!frecuenciaDatos.ContainsKey(dato)) frecuenciaDatos[dato] = 1;
                else frecuenciaDatos[dato]++;
            }
            foreach(var item in frecuenciaDatos)
            {
                Console.WriteLine($"Variable {item.Key}------Frecuencia {item.Value}");
            }

            return modas;
        }
        static double? CalcularMedia(List<int> datos)
        {
            if (datos.Count == 0) return null;
     
            return datos.Average();
        }

        static double? CalcularMediana(List<int> datos)
        {
            
            if (datos.Count == 0) return null;//cantidad inpar de datos
            datos.Sort();
            if (datos.Count % 2 != 0)
            {
                int numeroDeDato = (datos.Count + 1) / 2;
                int indiceDeMediana = numeroDeDato - 1;

                return datos[indiceDeMediana];
            }
            else // cantidad par de datos
            {
                int indiceDato2 = datos.Count / 2;// 6 datos/2=3 ----> es el cuarto dato a partir del 0
                int indiceDato1 = indiceDato2 - 1;// 6 datos------>3-1=2
            
            double mediana = (datos[indiceDato1] + datos[indiceDato2])/2.0;
            return mediana;
            }
        }

       
       
    }
}
