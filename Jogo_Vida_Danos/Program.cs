using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ataque = 20;
            int ct = 0;
            int jogador1 = 100;
            int jogador2 = 100;



            do
            {
                Console.Clear();
                Console.WriteLine("Pressione 1 para atacar o jogador 1: ");
                Console.WriteLine("Pressione 2 para atacar o jogador 2: ");
                Console.WriteLine("Pressione 3 para exibir o status dos jogadores: ");
                Console.WriteLine("Pressione 4 para reiniciar partida: ");
                Console.WriteLine("Pressione 5 para sair: ");
                ct = int.Parse(Console.ReadLine());


                switch (ct)
                {
                    case 1:
                        for (ct = 1; ct <= 1; ct++)
                        {
                            jogador1 = jogador1 - ataque;
                        }
                        Console.WriteLine("O dano foi de: " + ataque);
                        Console.WriteLine("A vida atual do jogador é de: " + jogador1);
                        break;
                    case 2:
                        for (ct = 1; ct <= 1; ct++)
                        {
                            jogador2 = jogador2 - ataque;
                        }
                        Console.WriteLine("O dano foi de: " + ataque);
                        Console.WriteLine("A vida atual do jogador é de: " + jogador2);
                        break;
                    case 3:
                        Console.WriteLine("A vida atual do jogador A é de: " + jogador1);
                        Console.WriteLine("A vida atual do jogador B é de: " + jogador2);
                        break;
                    case 4:
                        jogador1 = 100;
                        jogador2 = 100;
                        Console.WriteLine("Vidas resetadas!");
                        break;
                    case 5:
                        Console.WriteLine("Tchau Felas.");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida.");
                        break;
                }

                if ((jogador1 <= 0) || (jogador2 <= 0))
                {
                    Console.WriteLine("Partida finalizada!");
                    ct = 5;
                }

                if ((ct >= 1) && (ct <= 4))
                {
                    Console.WriteLine("");
                }

                Console.ReadKey();



            } while (ct != 5);

            Console.ReadKey();
        }
    }
}
// Maria Clara Rexende Vianna - 3ºCiclo Manhã - Jogos Digitais