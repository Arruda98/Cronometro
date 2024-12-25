using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos (10s, 20s)");
            Console.WriteLine("M - Minutos (10m, 20m)");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja Contar?");

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            //trata o input sempre pondo a string em minusculo
            string data = Console.ReadLine().ToLower();

            //Ler a quantidade de caractere e separa o ultimo
            char type = char.Parse(data.Substring(data.Length - 1, 1));

            //Ler a quantidade de caractere e separa do 0 até o penultimo numero
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;
            
            if(time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();

            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            //enquanto CurrentTime for diferente de Time
            while(currentTime != time)
            {
                //Só aparece o atual numero
                Console.Clear();

                //incrementa enquanto for diferente
                currentTime++;
                Console.WriteLine(currentTime);

                //"biblioteca" usada para dar um delay no loop
                Thread.Sleep(1000);
            }
            //limpa a função
            Console.Clear();

            //Mensagem avisando que acabou
            Console.WriteLine("Stopwatch finalizado");

            //após esses milisegundos se encerra o processo
            Thread.Sleep(2500);

            //volta pro menu
            Menu();
        }
    }
}