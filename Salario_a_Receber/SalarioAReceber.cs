using System;

namespace SalarioAReceber
{
    internal class Program
    {
        static void Main(string[] args)
        {  
             /* Autor: Felipe Matthew Moreira Nascimento
             * Turma: Análise e desenvolvimento de sistemas - Noturno - 1ºB
             * Programa: Exercicío 10 - Cálculo de salário
             * Problema: Descobrir o salário final que irá receber
             * Data: 7/4/2022
             * Professor: Adilson 
             */
         

            //Váriaveis de entrada
            float VH, HT, Smin, imposto, SB, Stotal;


            /* VH - Valor das horas trabalhadas
             * HT - Horas trabalahadas
             * Smin - Valor do salário mínimo
             * Imposto - Imposto
             * SB - Saldo bruto
             * Stotal - Saldo total ou saldo final
             */


            Console.WriteLine("Olá, vamos calcular o seu salário final:");
            Console.Write("Para começarmos por favor me informe as horas trabalhadas: ");
            HT = float.Parse(Console.ReadLine()); //Entrada das horas trabalhadas

            Console.Write("Agora por favor me informe o valor do salário minimo: ");
            Smin = float.Parse(Console.ReadLine()); //Entrada do salário mínimo

            Console.WriteLine("\nAgora espere alguns segundos para eu calcular seu salário final ok?");
            {
                Thread.Sleep(5000); // Congela programa
            }

            //Processamentos de dados 

            VH = Smin / 2; //Valor da hora de trabalho

            SB = HT * VH; //Valor do saldo em bruto

            imposto = SB * (3 / 100); //Valor do imposto

            Stotal = SB - imposto; //Salário final 

            //Saida de dados 
            Console.WriteLine("Obigador por esperar");
            Console.WriteLine($"O seu salário final é de: {Stotal:F2} reais"); // Resultado

            Console.ReadKey();
        }
    }
}