using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroQualquer = 20 + 20;
            int numeroMult = 10 * 90;
            float numeroDiv = 5f / 2;
            
            int teste = 2 + 20 * numeroMult;

            // 6 / 2 => // int
            // 5 / 2 => // decimal //float 
             


            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);   
            Console.WriteLine(teste); 
        }
    }
}