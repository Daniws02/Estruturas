using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo2.Codigo();
        }
    }
    /*
    class Metodo1
    {   
        // Arrumar depois ****

        public static void Codigo()
        {

            int[] Arr = {0, 0, 0, 0};

            int valor = int.Parse(Console.ReadLine());

            int Solu = Random(Arr, valor);

            Console.WriteLine(Solu);

            
        }
        public static int Random(Array Arr, int max)
        {
            Random random = new Random();
            for(int i = 0; i<Arr.Length; i++)
            {   
                int P = Arr[i];
                P = random.Next(max);

                return P;
            }
        }
        
    }
    */
    class Metodo2
    {
        // Metodo que localiza um valor e retorna a posição dele
        public static void Codigo()
        {
            int[] Arr = {1, 2, 3, 4};

            int valor = int.Parse(Console.ReadLine());

            int posicao_valor = BinarySearch(Arr, valor);

            Console.WriteLine(posicao_valor);
        }
        public static int BinarySearch(Array Arr, int procurado)
        {
        
        int posicao = Array.BinarySearch(Arr, procurado);

        return posicao;
        }
    }
}