using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torti
{
    
    internal class ArrowMenu
    {
        private static int position = 3;
        public static int fullPrice = 0;
        public static int zakaz = 0;
        public static List<string> order = new List<string>();
        private static List<string> forma = new List<string>() { "Квадрат - 300", "Прямоугольник - 300", "Круг - 300", "Сердце - 400", "Конус - 500" };
        private static List<string> razmer = new List<string>() { "Мини - 650", "Маленький - 800", "Средний - 1000", "Большой - 1400", "Огромный - 1900" };
        private static List<string> taste = new List<string>() { "Шоколадный - 100", "Ванильные - 100", "Карамельный - 150", "Кокосовый - 300", "Ягодный - 200" };
        private static List<string> count = new List<string>() { "Один корж - 200", "Два коржа - 400", "Три коржа - 600", "Четыре коржа - 800", "Пять коржей - 1000" };
        private static List<string> decor = new List<string>() { "Кремовый - 150", "Цветная посыпка - 250", "Шоколадный - 150", "Ягодный - 200", "Желатиновый цветок - 600" };
        private static List<string> glasur = new List<string>() { "Из черного шоколада - 100", "Из какао - 150", "Ягодная - 100", "Из белого шоколада - 150", "Кофейная - 200" };

        public static void Arrow()
        {
            Console.Clear();
            Console.Write(" Заказывайте торты в кондитерской ШОКОЛАДНЫЙ ГЛАЗ, любые торты за ваши деньги \nВыберите параметры для торта\n");
            Console.WriteLine("----------------------------");
            Console.WriteLine("  1)Форма торта");
            Console.WriteLine("  2)Размер торта");
            Console.WriteLine("  3)Вкус коржей");
            Console.WriteLine("  4)Количество коржей");
            Console.WriteLine("  5)Глазурь");
            Console.WriteLine("  6)Декор");
            Console.WriteLine("  7)Конец заказа");
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Цена: " + fullPrice);
            Console.SetCursorPosition(0, 12);
            Console.Write("Вот такой тортик: " );
            order.ForEach(Console.WriteLine);
        }
        
        private static void Choice()
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
                        position = 2;
                    }
                    else
                    {
                        position--;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (position > 5)
                    {
                        position = 6;
                    }
                    else
                    {
                        position++;
                    }
                }
                else if ( key.Key == ConsoleKey.Backspace)
                {
                    position = 10;
                    break;
                }
            } while (key.Key != ConsoleKey.Enter);


            

        }
        public static int Movement()
        {
            DateTime ordertime = DateTime.Now;
            string orders = "Orders.txt";
            

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
                    if (position == 3)
                    {
                        Console.WriteLine("Выберите форму.Для выхода нажмите Backspace\n--------------\n  1)" + forma[0]);
                        Console.WriteLine("  2)" + forma[1]);
                        Console.WriteLine("  3)" + forma[2]);
                        Console.WriteLine("  4)" + forma[3]);
                        Console.WriteLine("  5)" + forma[4]);
                        Choice();
                        if (position == 2)
                        {
                            fullPrice += 300;
                            order.Add(forma[0] + "; ");

                        }
                        else if (position == 3)
                        {
                            fullPrice += 300;
                            order.Add(forma[1] + "; ");
                        }
                        else if(position == 4)
                        {
                            fullPrice += 300;
                            order.Add(forma[2] + "; ");

                        }
                        else if (position == 5)
                        {
                            fullPrice += 400;
                            order.Add(forma[3] + "; ");
                        }
                        else if (position == 6)
                        {
                            fullPrice += 500;
                            order.Add(forma[4] + "; ");
                        }
                    }
                    else if (position == 4)
                    {
                        Console.WriteLine("Выберите размер. Для выхода нажмите Backspace\n--------------\n  1)" + razmer[0]);
                        Console.WriteLine("  2)" + razmer[1]);
                        Console.WriteLine("  3)" + razmer[2]);
                        Console.WriteLine("  4)" + razmer[3]);
                        Console.WriteLine("  5)" + razmer[4]);
                        Choice();
                        if (position == 2)
                        {
                            fullPrice += 650;
                            order.Add(razmer[0] + "; ");
                        }
                        else if (position == 3)
                        {
                            fullPrice += 800;
                            order.Add(razmer[1] + "; "); 
                        }
                        else if (position == 4)
                        {
                            fullPrice += 1000;
                            order.Add(razmer[2] + "; ");
                        }
                        else if (position == 5)
                        {
                            fullPrice += 1400;
                            order.Add(razmer[3] + "; ");
                        }
                        else if (position == 6)
                        {
                            fullPrice += 1900;
                            order.Add(razmer[4] + "; ");
                        }
                    }
                    else if (position == 5)
                    {
                        Console.WriteLine("Выберите вкус коржей. Для выхода нажмите Backspace\n--------------\n  1)" + taste[0]);
                        Console.WriteLine("  2)" + taste[1]);
                        Console.WriteLine("  3)" + taste[2]);
                        Console.WriteLine("  4)" + taste[3]);
                        Console.WriteLine("  5)" + taste[4]);
                        Choice();
                        if (position == 2)
                        {
                            fullPrice += 100;
                            order.Add(taste[0] + "; ");
                        }
                        else if (position == 3)
                        {
                            fullPrice += 100;
                            order.Add(taste[1] + "; ");
                        }
                        else if (position == 4)
                        {
                            fullPrice += 150;
                            order.Add(taste[2] + "; ");
                        }
                        else if (position == 5)
                        {
                            fullPrice += 300;
                            order.Add(taste[3] + "; ");
                        }
                        else if (position == 6)
                        {
                            fullPrice += 200;
                            order.Add(taste[4] + "; ");
                        }
                    }
                    else if (position == 6) 
                    {
                        Console.WriteLine("Выберите количество коржей. Для выхода нажмите Backspace\n--------------\n  1)" + count[0]);
                        Console.WriteLine("  2)" + count[1]);
                        Console.WriteLine("  3)" + count[2]);
                        Console.WriteLine("  4)" + count[3]);
                        Console.WriteLine("  5)" + count[4]);
                        Choice();
                        if (position == 2)
                        {
                            fullPrice += 200;
                            order.Add(count[0] + "; ");
                        }
                        else if (position == 3)
                        {
                            fullPrice += 400;
                            order.Add(count[1] + "; ");
                        }
                        else if (position == 4)
                        {
                            fullPrice += 600;
                            order.Add(count[2] + "; ");

                        }
                        else if (position == 5)
                        {
                            fullPrice += 800;
                            order.Add(count[3] + "; ");
                        }
                        else if (position == 6)
                        {
                            fullPrice += 1000;
                            order.Add(count[4] + "; ");
                        }
                    }
                    else if (position == 7)
                    {
                        Console.WriteLine("Выберите глазурь.Для выхода нажмите Backspace\n--------------\n  1)" + glasur[0]);
                        Console.WriteLine("  2)" + glasur[1]);
                        Console.WriteLine("  3)" + glasur[2]);
                        Console.WriteLine("  4)" + glasur[3]);
                        Console.WriteLine("  5)" + glasur[4]);
                        Choice();
                        if (position == 2)
                        {
                            fullPrice += 100;
                            order.Add(glasur[0]  + "; ");
                        }
                        else if (position == 3)
                        {
                            fullPrice += 150;
                            order.Add(glasur[1] + "; ");
                        }
                        else if (position == 4)
                        {
                            fullPrice += 100;
                            order.Add(glasur[2] + "; ");

                        }
                        else if (position == 5)
                        {
                            fullPrice += 150;
                            order.Add(glasur[3] + "; ");
                        }
                        else if (position == 6)
                        {
                            fullPrice += 200;
                            order.Add(glasur[4] + "; ");
                        }
                    }
                    else if (position == 8)
                    {
                        Console.WriteLine("Выберите декор. Для выхода нажмите Backspace\n--------------\n  1)" + decor[0]);
                        Console.WriteLine("  2)" + decor[1]);
                        Console.WriteLine("  3)" + decor[2]);
                        Console.WriteLine("  4)" + decor[3]);
                        Console.WriteLine("  5)" + decor[4]);
                        Choice();
                        
                        
                            if (position == 2)
                            {
                                fullPrice += 150;
                                order.Add(decor[0] + "; ");
                            }
                            else if (position == 3)
                            {
                                fullPrice += 250;
                                order.Add(decor[1] + "; ");
                            }
                            else if (position == 4)
                            {
                                fullPrice += 150;
                                order.Add(decor[2] + "; ");

                            }
                            else if (position == 5)
                            {
                                fullPrice += 200;
                                order.Add(decor[3] + "; ");
                            }
                            else if (position == 6)
                            {
                                fullPrice += 600;
                                order.Add(decor[4] + "; ");
                            }
                        
                    }
                    else if (position == 9)
                    {
                        string text = "Время заказа: " + ordertime + "\nФорма: " + order[0] + "\nРазмер: " + order[1] + "\nВкус коржей: " + order[2] + "\nКоличество коржей: " + order[3]
                            + "\nГлазурь: " + order[4] + "\nДекор" + order[5] + "Цена тортика: " + fullPrice; 
                        File.AppendAllText(orders, text);
                        Console.WriteLine("Спасибо за заказ, для еще одного заказа нажмите Escape. Для продолжения заказа любую кнопку. Чтобы закончить заказывать нажмите Enter");
                        Console.WriteLine("Заказ сохранен.");
                        Console.WriteLine("Сумма заказа: " + fullPrice);
                        Console.Write("Ваш торт: ");
                        order.ForEach(Console.WriteLine);
                        
                        ConsoleKeyInfo chto;
                        chto = Console.ReadKey();
                        if (chto.Key == ConsoleKey.Enter)
                        {
                            zakaz = 1;
                        }
                        else if (chto.Key == ConsoleKey.Escape)
                        {
                            zakaz = 0;
                        }
                    }
                    break;
                case ConsoleKey.Escape:
                    zakaz = 1;
                    break;

                    
            }
            return position;
        }

       
    }

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
            

            do
            {


                ArrowMenu.Arrow();
                ArrowMenu.Movement();




            } while (ArrowMenu.zakaz == 0);

        }


    }
}
