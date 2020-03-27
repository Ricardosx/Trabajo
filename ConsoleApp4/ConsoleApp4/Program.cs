using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {

        static int[,] TablaV = {

                //   x1  x2    x3   r
     /*{0}*/       { -1, -1 , -1, -1},
     /*{1}*/       { -1, -1 ,  1, -1},
    /*{2}*/        { -1,  1 , -1, -1},
   /*{3}*/         { -1,  1 ,  1, -1},
  /*{4}*/          {  1, -1 , -1, -1},
  /*{5}*/          {  1, -1 ,  1, -1},
   /*{6}*/         {  1,  1 , -1, -1},
      /*{7}*/      {  1,  1 ,  1,  1},

        };

        //n > 0 =  1 2.5
        //n < 0 = -1

        static double w1 = 0, w2 = 0, w3 = 0, umbral = 0;
        static double resultado;
        static int y = 0, cont = 0;
        static int[] TablaY = new int[8];
        static List<double> contenedora = new List<double>();


        static void Main(string[] args)
        {
            Console.Write("Ingresa W1: ");
            w1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa W2: ");
            w2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa W3: ");
            w3 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa  U: ");
            umbral = Double.Parse(Console.ReadLine());

            while (cont < 8)
            {
                operacion(cont);
                cont++;
            }

            for (int i = 0; i < contenedora.Count; i++)
            {
                Console.WriteLine("[" + i + "]  " + contenedora[i] + " = " + TablaY[i]);
            }

        }


        static void operacion(int cont)
        {
            resultado = (TablaV[cont, 0] * w1) + (TablaV[cont, 1] * w2) + (TablaV[cont, 2] * w3) + (umbral);
            
            if (resultado > 0)
            {
                y = 1;
                TablaY[cont] = 1;
            }
            else
            {
                y = -1;
                TablaY[cont] = -1;
            }

            if (y == TablaV[cont, 3])
            {
                contenedora.Add(resultado);
            }
            else
            {
                w1 += TablaV[cont, 3] * TablaV[cont, 0];
                w2 += TablaV[cont, 3] * TablaV[cont, 1];
                w3 += TablaV[cont, 3] * TablaV[cont, 2];
                umbral += TablaV[cont, 3];
                operacion(cont);
            }

        }


    }
}
