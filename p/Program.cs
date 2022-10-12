namespace pionino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете одну из октав : F1, F2, F3");
            ConsoleKeyInfo go = Console.ReadKey();
            while (true)
            {
                if (go.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("F1");
                    while (go.Key != ConsoleKey.F2 && go.Key != ConsoleKey.F3)
                    {
                        go = key(go, 0);
                    }
                }
                else if (go.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("F2");
                    while (go.Key != ConsoleKey.F1 && go.Key != ConsoleKey.F3)
                    {
                        go = key(go, 2);
                    }
                }
                else if (go.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("F3");
                    while (go.Key != ConsoleKey.F1 && go.Key != ConsoleKey.F2)
                    {
                        go = key(go, 3);
                    }
                }
                else if (go.Key == ConsoleKey.Escape)
                {                  
                        break;   
                }
                else
                {
                    Console.WriteLine(" Такой актавы нету");
                    go = Console.ReadKey();
                }
            }
        }
        static int sound(int i, int I) 
        {
            int[,] arr = new int[4, 7] { { 523, 587, 659, 698, 784, 880, 987, }, { 261, 293, 329, 349, 392, 440, 494,  }, { 65, 73, 82, 87, 98, 110, 123, }, { 130, 146, 164, 174, 196, 220, 246,} };
            return arr[i, I];
        }
        static ConsoleKeyInfo key(ConsoleKeyInfo go, int i) // функция клавиш
        {
            go = Console.ReadKey();
            if (go.Key == ConsoleKey.Q) //до
            {
                int N = sound(i, 0);
                sound2(N);
            }
            else if (go.Key == ConsoleKey.W) // ре
            {
                int N = sound(i, 1);
                sound2(N);
            }
            else if (go.Key == ConsoleKey.E) // ми
            {
                int N = sound(i, 2);
                sound2(N);
            }
            else if (go.Key == ConsoleKey.R) // фа
            {
                int N = sound(i, 3);
                sound2(N);
            }
            else if (go.Key == ConsoleKey.T) // соль
            {
                int N = sound(i, 4);
                sound2(N);
            }
            else if (go.Key == ConsoleKey.Y) // ля
            {
                int N = sound(i, 5);
                sound2(N);
            }
            else if (go.Key == ConsoleKey.U) // си
            {
                int N = sound(i, 6);
                sound2(N);
            }         
            else if (go.Key != ConsoleKey.F1 && go.Key != ConsoleKey.F2 && go.Key != ConsoleKey.F3 )
            {
                Console.WriteLine("Такой клавиши нету");
            }
            return go;
        }
        public static void sound2(int N)
        {
            Console.Clear();
            Console.Beep(N, 400);
        }
    }
}
    
