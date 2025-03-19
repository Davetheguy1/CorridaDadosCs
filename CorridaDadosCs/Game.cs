using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CorridaDadosCs
{
    class Game
    {
        static int RandGenerator()
        {
            Random randGen = new Random();
            int randNumber = randGen.Next(1, 7);

            return randNumber;
        }


        public static void Play(int turn,int player1,int player2,int lenght)
        {
            if (player1 >= lenght)
            {
                Console.WriteLine("Vitória do Jogador 1!");
                Program.EndScreen();
            } else if (player2 >= lenght)
            {
                Console.WriteLine("Vitória do Jogador 2!");
                Program.EndScreen();
            }

            Console.Clear();
            Console.WriteLine("\n\n*CORRIDA*\n\n");
            Console.WriteLine($"Jogador 1 (Você): {player1} de {lenght} casas");
            Console.WriteLine($"Jogador 2: {player2} de {lenght} casas\n\n");
            Console.WriteLine("Pressione Enter para Continuar.");
            Console.ReadLine();

            if (turn == 1)
            {
                Console.WriteLine("Vez do Jogador 1\n");
                Roll1(player1, player2, lenght);
            } else if (turn == 2)
            {
                Console.WriteLine("Vez do Jogador 2\n");
                Roll2(player1, player2, lenght);
            }
        }



        static void Roll1(int player1, int player2, int lenght)
        {
            int turn = 1;
            int generatedNum = RandGenerator();
            player1 = player1 + generatedNum;
            string casas;
            if (generatedNum == 1)
            {
                casas = "casa";
            }
            else
            {
                casas = "casas";
            }
            if (generatedNum == 6)
            {
                Console.WriteLine("O dado caiu no 6! um turno extra será concedido ao Jogador 1\nPressione Enter para continuar\n");
                Console.ReadLine();
            } else
            {
                turn = 2;
            }
            Console.WriteLine($"O Jogador 1 andará {generatedNum} {casas} \nPressione Enter para continuar\n\n");
            Console.ReadLine();
            
            Play(turn,player1,player2,lenght);
        }

        static void Roll2(int player1, int player2, int lenght)
        {
            int turn = 2;
            int generatedNum = RandGenerator();
            player2 = player2 + generatedNum;
            string casas;
            if (generatedNum == 1)
            {
                casas = "casa";
            } else
            {
                casas = "casas";
            }

            if (generatedNum == 6)
            {
                Console.WriteLine("O dado caiu no 6! um turno extra será concedido ao Jogador 2\nPressione Enter para continuar\n");
                Console.ReadLine();
            }
            else
            {
                turn = 1;
            }
            Console.WriteLine($"O Jogador 2 andará {generatedNum} {casas}\nPressione Enter para continuar\n");
            Console.ReadLine();

            Play(turn, player1, player2, lenght);
        }




    }
    
    
}
