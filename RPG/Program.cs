using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string playerName = Console.ReadLine();
            string type = "", bonus = "";
            int choise, hp = 100, dmg = 30, luck = 30;

            while (type == "")
            {
                Console.WriteLine("--(1 -лучник, 2 -воин, 3 -маг)--");
                Console.Write("Выберите тип персонажа: ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1: 
                        type = "лучник";
                        break;
                    case 2:
                        type = "воин";
                        break;
                    case 3:
                        type = "маг";
                        break;
                    default: 
                        Console.WriteLine("Такого типа не существует");
                        break;
                }
            }
            Console.WriteLine($"Вы выбрали тип персонажа: {type}"); 
                

            while (bonus == "")
            {
                Console.WriteLine("--(1 - больше жизни, 2 - больше урона, 3 - больше удачи)--");
                Console.Write("Выберите бонус персонажа: ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        bonus = "больше жизни";
                        break;
                    case 2:
                        bonus = "больше урона";
                        break;
                    case 3:
                        bonus = " больше удача";
                        break;
                    default:
                        Console.WriteLine("Такого типа не существует");
                        break;
                }
            }
            Console.WriteLine($"Вы выбрали бонус: {bonus}");


            Random r = new Random();
            for (int day = 1; day <= 7; day++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("--(1 - идти, 2 - говорить, 3 - отдыхать, 4 - закончить день)--");
                    Console.Write("Выберите действие: ");
                    int numOfAction = int.Parse(Console.ReadLine());
                    switch (numOfAction)
                    {
                        case 1:
                            Console.WriteLine($"{playerName} Он пошел в домик на дереве");
                            break;
                        case 2:
                            Console.WriteLine($"{playerName} Он разговаривал с рапунцель");
                            break;
                        case 3:
                            int hours = r.Next(1,6);
                            Console.WriteLine($"{playerName} Он лег поспать с рапунцель {hours} часов");
                            i = 10;
                            break;
                        case 4:
                            Console.WriteLine($"{playerName} Он пошел обратно к себе домой,НАВСЕГДА!");
                            break;
                        default:
                            Console.WriteLine($"{playerName} Он не умеет выполнять эту задачу");
                            break;
                    }

                }
                Console.WriteLine($"{playerName} Он закончил свой {day} день");
                Console.WriteLine("Для продолжения нажмите Enter, а для выхода нажмите 0: ");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            } Console.ReadKey();
        }
    }
}
7