using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz;
            int m, n, raio,raio2, raio3;

            Console.WriteLine("informe o numero de linhas:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o numero de colunas:");
            n = int.Parse(Console.ReadLine());
            matriz = new int[m, n];
            Console.WriteLine("informe o numero de linhas que voce deseja tirar da matriz:");
            raio = int.Parse(Console.ReadLine());
            Console.WriteLine();

            raio2 = m - raio;
            raio3 = n - raio;
            
           
            
            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }


            //primeira linha e primeira coluna
            Console.WriteLine();
            for (int i = raio; i < m; i++)
            {
                for (int j = raio; j < n; j++)
                {

                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();

            }
         

            //primeira linha e ultima coluna
            
            Console.WriteLine();
            for (int i = raio; i < m; i++)
            {
                for (int j = 0; j < raio3; j++)
                {

                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            //ultima linha e primeira coluna
               
            Console.WriteLine();
            for (int i = 0; i < raio2; i++)
            {
                for (int j = raio; j < n; j++)
                {

                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();
            }


            //ultima linha e ultima coluna
           
            Console.WriteLine();
            for (int i = 0; i < raio2; i++)
            {
                for (int j = 0; j < raio3; j++)
                {

                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();


            }



            Console.ReadKey();

        }
            
    }


        
    
}
