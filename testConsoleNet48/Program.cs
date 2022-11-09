using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleNet48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            createAndShowMatrixWithJaggedArrays();

        }

        public static int[,] createMatrix(int x, int y)
        {
            Random rnd = new Random();
            int[,] matrix = new int[x, y];
            
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            return matrix;
        }

        public static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i,j]);
                }
                Console.WriteLine();
            }

        }

        public static void createAndShowMatrixWithJaggedArrays()
        {
            Console.WriteLine("Kaca kac matrix olusturacaksiniz?");
            Console.Write("m : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("m x n = {0} x {1} tipinde bir matris oluşturuyorsunuz!", m, n);

            int[][] matrix = new int[m][];


            for (int i = 0; i < m; i++)
            {
                int[] tempArray = new int[n]; //bunu burada oluşturdum çünkü referans tip yukarıda tanımlı olsaydı her seferinde sabit kalacaktı eşitleme yaptığımda ilk referansının ram bellekte tutulduğu bölüme giderdi.
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine();
                    Console.Write("M[{0},{1}] : ", i, j);
                    tempArray[j] = Convert.ToInt32(Console.ReadLine());
                }
                matrix[i] = tempArray;
                Console.WriteLine("\n------");
                Console.Write("M[{0}] : ",i);
                foreach (var k in tempArray)
                {
                    Console.Write("{0} ", k);
                }
                Console.WriteLine("\n------");
            }

            Console.WriteLine("\n-+-+-+-+-+-+-+-");
            Console.WriteLine("Oluşturduğunuz matris : \n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
