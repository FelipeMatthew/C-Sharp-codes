using System;

namespace felpsApp
{
    class ExercisesCallBack
    {
        public virtual void exerciseOne(string[] prod_name, float[,] prod_price ) 
        {
            Console.WriteLine("### Produtos - Preço 1º trimestre");

            for (int line = 0; line < 4; line++)
            {
                Console.Write($"Digite o nome do {line + 1}º produto: ");
                prod_name[line] = Console.ReadLine();

                for (int month = 0; month < 3; month++)
                {
                    Console.Write($"Digite o valor do {month + 1}º mês: ");
                    prod_price[line, 0] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
            Console.Clear();
            Console.WriteLine("###Registro");

            for (int line = 0; line < 4; line++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Poduto {line + 1}: {prod_name[line]}\n\n");
                Console.Write($"Valor do 1º mes: {prod_price[line, 0]}\n");
                Console.Write($"Valor do 2º mes: {prod_price[line, 1]}\n");
                Console.Write($"Valor do 3º mes: {prod_price[line, 2]}");
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExercisesCallBack callBack = new ExercisesCallBack();
            callBack.exerciseOne(new string [4], new float[4, 3]);


        }
    }
}
