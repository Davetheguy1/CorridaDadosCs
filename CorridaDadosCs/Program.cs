namespace CorridaDadosCs
{
    internal class Program
    {
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("*Corrida de Dados\n\n");
            Console.WriteLine("1.Jogar\n2.Sair");
            string menuRequest = Console.ReadLine();
            if (menuRequest == "1")
            {
                SecondaryMenu();
            } else if (menuRequest == "2")
            {
                Console.WriteLine("Finalizando o Programa...");
                Environment.Exit(0);
            }
        }


        static void SecondaryMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha a Duração da Corrida:\n\n1.Curta (20 Casas)\n2.Média (35 Casas)\n3.Longa (50 casas)");
            Console.WriteLine("------------------");
            Console.WriteLine("4.Voltar ao Menu Principal\n");
            string menuRequest = Console.ReadLine();
            if (menuRequest == "1")
            {
                Game.Play(1, 1, 1, 20);
            } else if (menuRequest == "2")
            {
                Game.Play(1, 1, 1, 35);
            } else if (menuRequest == "3")
            {
                Game.Play(1, 1, 1, 50);
            } else if (menuRequest == "4")
            {
                MainMenu();
            }
        }

        public static void EndScreen()
        {
            Console.WriteLine("\nJogo Finalizado, Deseja Jogar Novamente? (y/n)\n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                SecondaryMenu();
            } else if (answer == "n")
            {
                Console.WriteLine("Finalizando o Programa...");
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Erro, Digite uma Opção Válida.\n");
                EndScreen();
            }

        }
        
        
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
