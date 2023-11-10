using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEric1
{
    public class Metodos
    {
        public void Calificaciones()
        {

            int[] matriz = { 0, 9, 7, 8, 5, 6, 2, 1, 3, 4 };
            int menor = 0;
            int posicion = 0;
            int cambio = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
                menor = matriz[i];
                posicion = i;
                for (int j = i + 1; i < matriz.Length; i++)
                {
                    menor = matriz[j];
                    posicion = j;

                    if (posicion != i)
                    {
                        cambio = matriz[menor];
                        matriz[menor] = matriz[posicion];
                        matriz[posicion] = cambio;
                    }
                }

            }
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Ingresa numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < matriz.Length; i++)
            {
                if (i == numero)
                {
                    Console.WriteLine($"Tu numero esta en la posicion {i + 1}");
                    encontrado = true;

                    break;
                }

            }
            if (!encontrado)
            {
                Console.WriteLine("Tu numero no esta en el arreglo");
            }
        }
        public void curp()
        {
            Console.WriteLine("Ingresa tu curp");
            string curp1 = Console.ReadLine();
            char[] curp = curp1.ToCharArray();
            if (curp.Length != 18)
            {
                Console.WriteLine("Escribe una curp valida (18 digitos)");
            }
            else if (curp[10] == 'H')
            {
                Console.WriteLine("Usted es del sexo masculino");
            }
            else
            {
                Console.WriteLine("Usted es del sexo Femenino");
            }

            int año = int.Parse(curp1.Substring(4, 2));
            int mes = int.Parse(curp1.Substring(6, 2));
            int dia = int.Parse(curp1.Substring(8, 2));

            if (año >= 0 && año <= 49)
            {
                año += 2000;
            }
            else
            {
                año += 1900;
            }
            Console.WriteLine($" Y usted nacio en {dia}/{mes}/{año}");

        }
        public void matriz()
        {
            int[,] arreglo = { {500,3000,100,400},
                               { 1000,150 , 200 ,500 },
                               {250, 1800 , 2900 , 300 },
                               {400, 130,    90,  2400, },
                               { 60,  20,  4000,  3600}};

            int vendedor1Total = 0;
            int vendedor2Total = 0;
            int vendedor3Total = 0;
            int vendedor4Total = 0;

            int producto1Total = 0;
            int producto2Total = 0;
            int producto3Total = 0;
            int producto4Total = 0;
            int producto5Total = 0;


            for (int i = 0; i < 5; i++)
            {

                vendedor1Total += arreglo[i, 0];
                vendedor2Total += arreglo[i, 1];
                vendedor3Total += arreglo[i, 2];
                vendedor4Total += arreglo[i, 3];

            }

            for (int j = 0; j < 4; j++)
            {
                producto1Total += arreglo[0, j];
                producto2Total += arreglo[1, j];
                producto3Total += arreglo[2, j];
                producto4Total += arreglo[3, j];
                producto5Total += arreglo[4, j];

            }

            Console.WriteLine($"El vendedor 1 tuvo una ganancia total de {vendedor1Total}");
            Console.WriteLine($"El vendedor 2 tuvo una ganancia total de {vendedor2Total}");
            Console.WriteLine($"El vendedor 3 tuvo una ganancia total de {vendedor3Total}");
            Console.WriteLine($"El vendedor 4 tuvo una ganancia total de {vendedor4Total}");
            Console.WriteLine();
            Console.WriteLine($"El producto 1 genero {producto1Total} pesos de ganancia");
            Console.WriteLine($"El producto 2 genero {producto2Total} pesos de ganancia");
            Console.WriteLine($"El producto 3 genero {producto3Total} pesos de ganancia");
            Console.WriteLine($"El producto 4 genero {producto4Total} pesos de ganancia");
            Console.WriteLine($"El producto 5 genero {producto5Total} pesos de ganancia");


            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write($" {arreglo[i, j]} ");

                }
                Console.WriteLine();

            }


        }
    }
}
