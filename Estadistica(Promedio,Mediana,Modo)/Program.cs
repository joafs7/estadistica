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
            List<int> Valores = new List<int> {3,7,9,10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }



        static double calcularPromedio(List<int> valores)
        {
            double promedio = valores.Average();
            return promedio;
            
        }

        static double calcularMediana(List<int> valores)
        {
            valores.Sort();
            int indice;
            int mediana;
            if(valores.Count%2 != 0)
            {
                indice = valores               
            }
            return;
        }
    }
}
