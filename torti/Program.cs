using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torti
{
    public class Forma
    {
        public string forma;
        public string nameF;
        public static List<Forma> formas = new List<Forma>();
    }




    internal class ArrowMenu
    {
        private static int position = 3;
        public static int fullPrice = 0;

        public static void Arrow()
        {
            Console.Clear();
            Console.Write(" Заказывайте торты в кондитерской ШОКОЛАДНЫЙ ГЛАЗ, любые торты за ваши деньги \nВыберите параметры для торта\n");
            Console.WriteLine("----------------------------");
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Цена: " + fullPrice);
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Вот такой тортик: ");
        }
        
        public static int Choice()
        {
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (position < 3)
                    {
                        position = 4;
                    }
                    else
                    {
                        position--;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (position > 8)
                    {
                        position = 7;
                    }
                    else
                    {
                        position++;
                    }
                }
            } while (key.Key != ConsoleKey.Enter);

            return position;


        }
        public static int Movement()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (position < 4)
                    {
                        position = 3;
                    }
                    else
                    {
                        position--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (position > 8)
                    {
                        position = 9;
                    }
                    else
                    {
                        position++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine("\n\n  1)Круг - 300");
                    
                    if (position == 3)
                    {
                        Choice();
                        if (position == 2)
                        {
                            fullPrice += 300;
                        }
                        else if (position == 3)
                        {
                            fullPrice += 350;
                        }
                    }
                    break;
            }
            return position;
        }

       
    }

    internal class Program
    {
        public static void Paramets()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  1)Форма торта");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Forma a = new Forma()
            {
                nameF = "Форма торта",
                forma = "Квадрат - 300 \n Прямоугольник - 350"
            };
            Forma.formas.Add(a);
            ConsoleKeyInfo key;

            key = Console.ReadKey();
            
            while (key.Key != ConsoleKey.Escape)
            {
                Paramets();
                ArrowMenu.Arrow();
                ArrowMenu.Movement();

                
            } 

        }


    }
}
