using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDeMatrices
{
    class SumaMatrices
    {
        static void Main(string[] args)
        {
            //SE CREAN LAS MATRICES CON LOS ARREGLOS Y SE DEFINE SU PARAMETRO
            int[,] matrizA = new int[3,3];
            int[,] matrizB = new int[3,3];

            int[,] matrizResult = new int[3,3];

            Console.WriteLine("Ingrese los Valores para la primera Matriz"); 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese los valores: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los Valores para la segunda Matriz");

            for (int i = 0; i < 3; i ++) 
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese los valores: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++) //SUMA DE LAS MATRICES A Y B
            {
                for( int j = 0; j < 3; j++) //SE GUARDAN EN LA MATRIZ RESULT
                {
                    matrizResult[i, j] = matrizA[i,j] + matrizB[i,j];
                }
            }

            Console.WriteLine("");
            Console.WriteLine("El resultado de la Suma es: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for (int j =0; j < 3; j++)
                {
                    Console.Write(matrizResult[i,j] + " ");
                }
            }
        }
    }
}