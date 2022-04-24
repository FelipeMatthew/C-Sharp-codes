using System;

namespace plano_de_viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Grupo: Rafael Sampaio de Morais | 11221103790 
                       Felipe Matthew | 11221103739
                       Mateus de Barros Gimenes | 11221103419

                Professor: Adilson Lima

                Data: 21/04/2022

                Titulo: Plano de viajens nacionais
                Problema: Selecionar e calcular os valores e local de viagem e o jeito que voce quer viajar.
            */


            //  Variaveis
             
            string Nome, Local, pacote, Classe, cartao, Gramado = "gramado", SantaC = "santa catarina", Brasilia = "brasilia",
                   escala; // strings dos locais disponiveis de viagem, nome da pessoa, classe de viagem e tipo de cartão a pagar

            double Vgramado = 250, Vsantac = 292, Vbra = 325, Escala = 170, Sescala = 250, Vnormal = 80,
                   Vpremiun = 120, vip=320, eco=200,Vdiaria = 100, Vfinal, Vdfinal, Diaria; // Valores de cada parte do problema
               


            // Cabeçalho ao qual pergunta nome da pessoa e o local ao qual ela vai viajar
            

            Console.WriteLine("Olá, seja bem vindo ao nosso plano de viajem");
            Console.Write("Para começar, digite seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine($" Olá {Nome}, Para onde gostaria de ir?"); //Nome da pessoa
            Console.WriteLine("\nALERTA ESCREVA TODAS AS INFORMAÇÕES EM MINUSCULO E COMPLETO"); //Prestar total atenção nessa linha

            Console.Write("\n\t Gramado - R$250,00");
            Console.Write("\n\t Santa Catarina - R$292,00");
            Console.Write("\n\t Brasilia - R$325,00\n\n");
            Local = Console.ReadLine(); //Local de viagem 

            Console.Clear(); //Limpar o código


            // Entrada das condicinais

            if(Local == Gramado) //Gramado
            {
                // Pergunta se quer viajar com escala ou sem 

                Console.WriteLine("Você escolheu Gramado");
                Console.WriteLine("\nAgora me informe como você quer viajar:");

                Console.WriteLine("\n\tCom escala - R$ 170,00");
                Console.WriteLine("\tSem escala - R$ 250,00");

                escala = Console.ReadLine();
                Vfinal = Vgramado;


                if(escala == "com escala") //Com escala
                {
                    Console.WriteLine("\nOk então seu voo sera com escala.");

                    Vfinal=Vgramado+Escala;

                }else if(escala=="sem escala")//Sem escala
                {
                    Console.WriteLine("\nOk então seu voo será sem escala");

                    Vfinal= Vgramado+Sescala;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return ;
                }
                    // Agora vai perguntar qual classe de viagem, vip ou economica

                Console.WriteLine("Perfeito, agora me informe qual classe voce vai viajar:");
                Console.WriteLine("\n\tClasse Vip - R$ 320,00");
                Console.WriteLine("\tClasse Economica - R$ 200,00");
                Classe = Console.ReadLine();

                Thread.Sleep(2000); // Serve para dar um congelamento no código durante 2 segundos 
                Console.Clear();


                if(Classe == "classe vip") // Classe vip
                {
                    Console.WriteLine("Você escolheu classe vip");
                    Vfinal = Vfinal + vip;
                }
                else if(Classe=="classe economica")// Classe economica
                {
                    Console.WriteLine("Você escolheu classe economica");
                    Vfinal = Vfinal + eco;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }
               

                    // Agora pergunta quantos dias você irá ficar

                Console.Write($" Agora {Nome}, por favor me informe quantos dias voce vai ficar:");               
                Diaria = double.Parse(Console.ReadLine());               
                Vdfinal = Diaria * Vdiaria;
                Console.WriteLine($"\nEntão o valor da sua diária ficou: R$ {Vdfinal:f2} reais"); // Valor até determinado momento

                Thread.Sleep(3000); // Congelamento de 3 segundos
                Console.Clear();

                // Pergunta qual pacote vai querer, o pacote normal ou premium

                Console.WriteLine("Tudo certo, agora me informe qual pacote você quer:");
                Console.WriteLine("\n\tPacote normal - Com café da manhã incluso, apenas - R$ 80,00");
                Console.WriteLine("\tPacote premium - Todas as refeições inclusas - R$ 120,00");
                pacote = Console.ReadLine();               

                if (pacote=="pacote normal") // Pacote normal
                {
                    Console.WriteLine("\nVocê escolheu o pacote normal");
                    Vfinal = Vfinal + Vnormal;                   
                }
                else if(pacote=="pacote premium") // Pacote premium
                {
                    Console.WriteLine("\nVocê escolheu o pacote premium");
                    Vfinal = Vfinal + Vpremiun;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }

                // Parte do calculo final 

                Console.WriteLine("\nAgora espere um pouco até eu calcular o valor final ok?");
                Thread.Sleep(5000); //Pausa de 5 segundos no código 
                Console.Clear();               
                

                Vfinal = Vfinal + Vdfinal;
                Console.WriteLine($"O valor total de sua viagem ficou: R$ {Vfinal:f2}"); //Exibição do valor final

                // Parte do tipo de pagamento a ser feito

                Console.WriteLine("\nQual forma de pagamento você vai fazer?");
                Console.WriteLine("\n\tCartão de crédito - 5% de desconto no valor final");
                Console.WriteLine("\tCartão de debito  - 10% de desconto no valor final");

                Console.WriteLine("Escreva: debito ou credito:");
                cartao = Console.ReadLine();    

                if (cartao == "debito") //Pagamento em débito
                {
                    Console.WriteLine("Debito certo?");
                    Vfinal=Vfinal-(Vfinal*0.1);
                    Console.WriteLine($"\n\nEntão valor final ficou: R${Vfinal}");
                }
                else if(cartao=="credito") // Pagamento em crédito
                {
                    Console.WriteLine("Crédito certo?");
                    Vfinal = Vfinal-(Vfinal * 0.05);
                    Console.WriteLine($"\n\nEntão valor final ficou: R${Vfinal}");
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }

            }
            else if (Local == SantaC)
            {
                // Pergunta se quer viajar com escala ou sem 

                Console.WriteLine("Você escolheu Santa Catarina");
                Console.WriteLine("\nAgora me informe como você quer viajar:");

                Console.WriteLine("\n\tCom escala - R$ 170,00");
                Console.WriteLine("\tSem escala - R$ 250,00");

                escala = Console.ReadLine();
                Vfinal = Vsantac;


                if (escala == "com escala") //Com escala
                {
                    Console.WriteLine("\nOk então seu voo sera com escala.");

                    Vfinal = Vsantac + Escala;

                }
                else if (escala == "sem escala")//Sem escala
                {
                    Console.WriteLine("\nOk então seu voo será sem escala");

                    Vfinal = Vsantac + Sescala;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }
                // Agora vai perguntar qual classe de viagem, vip ou economica

                Console.WriteLine("Perfeito, agora me informe qual classe voce vai viajar:");
                Console.WriteLine("\n\tClasse Vip - R$ 320,00");
                Console.WriteLine("\tClasse Economica - R$ 200,00");
                Classe = Console.ReadLine();

                Thread.Sleep(2000); // Serve para dar um congelamento no código durante 2 segundos 
                Console.Clear();


                if (Classe == "classe vip") // Classe vip
                {
                    Console.WriteLine("Você escolheu classe vip");
                    Vfinal = Vfinal + vip;
                }
                else if (Classe == "classe economica")// Classe economica
                {
                    Console.WriteLine("Você escolheu classe economica");
                    Vfinal = Vfinal + eco;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }


                // Agora pergunta quantos dias você irá ficar

                Console.Write($" Agora {Nome}, por favor me informe quantos dias voce vai ficar:");
                Diaria = double.Parse(Console.ReadLine());
                Vdfinal = Diaria * Vdiaria;
                Console.WriteLine($"\nEntão o valor da sua diária ficou: R$ {Vdfinal:f2} reais"); // Valor até determinado momento

                Thread.Sleep(3000); // Congelamento de 3 segundos
                Console.Clear();

                // Pergunta qual pacote vai querer, o pacote normal ou premium

                Console.WriteLine("Tudo certo, agora me informe qual pacote você quer:");
                Console.WriteLine("\n\tPacote normal - Com café da manhã incluso, apenas - R$ 80,00");
                Console.WriteLine("\tPacote premium - Todas as refeições inclusas - R$ 120,00");
                pacote = Console.ReadLine();

                if (pacote == "pacote normal") // Pacote normal
                {
                    Console.WriteLine("\nVocê escolheu o pacote normal");
                    Vfinal = Vfinal + Vnormal;
                }
                else if (pacote == "pacote premium") // Pacote premium
                {
                    Console.WriteLine("\nVocê escolheu o pacote premium");
                    Vfinal = Vfinal + Vpremiun;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }

                // Parte do calculo final 

                Console.WriteLine("\nAgora espere um pouco até eu calcular o valor final ok?");
                Thread.Sleep(5000); //Pausa de 5 segundos no código 
                Console.Clear();


                Vfinal = Vfinal + Vdfinal;
                Console.WriteLine($"O valor total de sua viagem ficou: R$ {Vfinal:f2}"); //Exibição do valor final

                // Parte do tipo de pagamento a ser feito

                Console.WriteLine("\nQual forma de pagamento você vai fazer?");
                Console.WriteLine("\n\tCartão de crédito - 5% de desconto no valor final");
                Console.WriteLine("\tCartão de debito  - 10% de desconto no valor final");

                Console.WriteLine("Escreva: debito ou credito:");
                cartao = Console.ReadLine();

                if (cartao == "debito") //Pagamento em débito
                {
                    Console.WriteLine("Debito certo?");
                    Vfinal = Vfinal - (Vfinal * 0.1);
                    Console.WriteLine($"\n\nEntão valor final ficou: R${Vfinal}");
                }
                else if (cartao == "credito") // Pagamento em crédito
                {
                    Console.WriteLine("Crédito certo?");
                    Vfinal = Vfinal - (Vfinal * 0.05);
                    Console.WriteLine($"\n\nEntão valor final ficou: R${Vfinal}");
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }
            }
            else if (Local == Brasilia)
            {
                // Pergunta se quer viajar com escala ou sem 

                Console.WriteLine("Você escolheu Brasilia");
                Console.WriteLine("\nAgora me informe como você quer viajar:");

                Console.WriteLine("\n\tCom escala - R$ 170,00");
                Console.WriteLine("\tSem escala - R$ 250,00");

                escala = Console.ReadLine();
                Vfinal = Vbra;


                if (escala == "com escala") //Com escala
                {
                    Console.WriteLine("\nOk então seu voo sera com escala.");

                    Vfinal = Vbra + Escala;

                }
                else if (escala == "sem escala")//Sem escala
                {
                    Console.WriteLine("\nOk então seu voo será sem escala");

                    Vfinal = Vbra + Sescala;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }
                // Agora vai perguntar qual classe de viagem, vip ou economica

                Console.WriteLine("Perfeito, agora me informe qual classe voce vai viajar:");
                Console.WriteLine("\n\tClasse Vip - R$ 320,00");
                Console.WriteLine("\tClasse Economica - R$ 200,00");
                Classe = Console.ReadLine();

                Thread.Sleep(2000); // Serve para dar um congelamento no código durante 2 segundos 
                Console.Clear();


                if (Classe == "classe vip") // Classe vip
                {
                    Console.WriteLine("Você escolheu classe vip");
                    Vfinal = Vfinal + vip;
                }
                else if (Classe == "classe economica")// Classe economica
                {
                    Console.WriteLine("Você escolheu classe economica");
                    Vfinal = Vfinal + eco;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }


                // Agora pergunta quantos dias você irá ficar

                Console.Write($" Agora {Nome}, por favor me informe quantos dias voce vai ficar:");
                Diaria = double.Parse(Console.ReadLine());
                Vdfinal = Diaria * Vdiaria;
                Console.WriteLine($"\nEntão o valor da sua diária ficou: R$ {Vdfinal:f2} reais"); // Valor até determinado momento

                Thread.Sleep(3000); // Congelamento de 3 segundos
                Console.Clear();

                // Pergunta qual pacote vai querer, o pacote normal ou premium

                Console.WriteLine("Tudo certo, agora me informe qual pacote você quer:");
                Console.WriteLine("\n\tPacote normal - Com café da manhã incluso, apenas - R$ 80,00");
                Console.WriteLine("\tPacote premium - Todas as refeições inclusas - R$ 120,00");
                pacote = Console.ReadLine();

                if (pacote == "pacote normal") // Pacote normal
                {
                    Console.WriteLine("\nVocê escolheu o pacote normal");
                    Vfinal = Vfinal + Vnormal;
                }
                else if (pacote == "pacote premium") // Pacote premium
                {
                    Console.WriteLine("\nVocê escolheu o pacote premium");
                    Vfinal = Vfinal + Vpremiun;
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }

                // Parte do calculo final 

                Console.WriteLine("\nAgora espere um pouco até eu calcular o valor final ok?");
                Thread.Sleep(5000); //Pausa de 5 segundos no código 
                Console.Clear();


                Vfinal = Vfinal + Vdfinal;
                Console.WriteLine($"O valor total de sua viagem ficou: R$ {Vfinal:f2}"); //Exibição do valor final

                // Parte do tipo de pagamento a ser feito

                Console.WriteLine("\nQual forma de pagamento você vai fazer?");
                Console.WriteLine("\n\tCartão de crédito - 5% de desconto no valor final");
                Console.WriteLine("\tCartão de debito  - 10% de desconto no valor final");

                Console.WriteLine("Escreva: debito ou credito:");
                cartao = Console.ReadLine();

                if (cartao == "debito") //Pagamento em débito
                {
                    Console.WriteLine("Debito certo?");
                    Vfinal = Vfinal - (Vfinal * 0.1);
                    Console.WriteLine($"\n\nEntão valor final ficou: R${Vfinal}");
                }
                else if (cartao == "credito") // Pagamento em crédito
                {
                    Console.WriteLine("Crédito certo?");
                    Vfinal = Vfinal - (Vfinal * 0.05);
                    Console.WriteLine($"\n\nEntão valor final ficou: R${Vfinal}");
                }
                else
                {
                    Console.WriteLine("\nNão entendi o que você falou");
                    Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                    Console.WriteLine("Reiniciando codigo...");
                    return;
                }
            }
            else
            {
                Console.WriteLine("\nNão entendi o que você falou");
                Console.WriteLine("Revise a ortografia e veja se está tudo minusculo");
                Console.WriteLine("Reiniciando codigo...");
                return;
            }
            Console.ReadKey();
        }
    }
}
