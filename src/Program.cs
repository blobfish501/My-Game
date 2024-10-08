namespace game_1
{
    internal class Program
    {
        static void Main()
        {
            bool first_art_found = false;
            bool second_art_found = false;
            bool third_art_found = false;
            bool lock_found = false;
            bool chest_key_found = false;
            bool escaped = false;
            int vent_tries = 1;
            Console.WriteLine("Введите свое имя:");
            string? name = Console.ReadLine();
            while (escaped == false)
            {
                Console.WriteLine("" +
                    "\r\nЧто мне сделать?" +
                    "\r\n1. Открыть дверь" +
                    "\r\n2. Заглянуть под кровать" +
                    "\r\n3. Открыть ящик в углу комнаты" +
                    "\r\n4. Открыть вентиляцию" +
                    "\r\n5. Взглянуть на тумбочку" +
                    "\n6. Взглянуть на статую рядом с дверью");
                int step = Convert.ToInt32(Console.ReadLine());
// 1
                if (step == 1)
                {
                    Console.Clear();
                    if (lock_found == false)
                    {
                        Console.WriteLine("1. Открыть дверь");
                        Console.WriteLine("Не открывается. Возможно, тут поможет ключ или отмычка.");
                    }
                    else
                    {
                        Console.WriteLine("1. Открыть дверь");
                        Console.WriteLine($"{name}, у тебя получилось сбежать!");
                        escaped = true;
                    }
                }
// 2
                else if (step == 2)
                {
                    Console.Clear();
                    if (first_art_found == false)
                    {
                        Console.WriteLine("2. Заглянуть под кровать");
                        Console.WriteLine("Я нашел артефакт!");
                        first_art_found = true;
                    }
                    else
                    {
                        Console.WriteLine("2. Заглянуть под кровать");
                        Console.WriteLine("Я уже смотрел здесь.");
                    }
                }
// 3
                else if (step == 3)
                {
                    Console.Clear();
                    if (chest_key_found == false)
                    {
                        Console.WriteLine("3. Открыть ящик в углу комнаты");
                        Console.WriteLine("Не открывается. Возможно, я смогу найти ключ.");
                    }
                    else if (chest_key_found && lock_found == false)
                    {
                        Console.WriteLine("3. Открыть ящик в углу комнаты");
                        Console.WriteLine("Я нашел отмычку!");
                            lock_found = true;
                    }
                    else
                    {
                        Console.WriteLine("3. Открыть ящик в углу комнаты");
                        Console.WriteLine("Я уже смотрел здесь.");
                    }  
                }
// 4
                else if (step == 4)
                {
                    Console.Clear();
                    if (vent_tries < 3)
                    {
                        Console.WriteLine("4. Открыть вентиляцию");
                        Console.WriteLine("Не поддается. Может быть, попробовать еще раз?");
                        vent_tries++;
                    }
                    else if (vent_tries >= 3 && second_art_found == false)
                    {
                        Console.WriteLine("4. Открыть вентиляцию");
                        Console.WriteLine("Я нашел артефакт!");
                        second_art_found = true;
                    }
                    else
                    {
                        Console.WriteLine("4. Открыть вентиляцию");
                        Console.WriteLine("Я уже смотрел здесь.");
                    }
                }
// 5
                else if (step == 5)
                {
                    Console.Clear();
                    if (third_art_found == false)
                    {
                        Console.WriteLine("5. Взглянуть на тумбочку");
                        Console.WriteLine("Я нашел артефакт!");
                        third_art_found = true;
                    }
                    else
                    {
                        Console.WriteLine("5. Взглянуть на тумбочку");
                        Console.WriteLine("Я уже смотрел здесь.");
                    }
                }
// 6
                else if (step == 6)
                {
                    Console.Clear();
                    if (first_art_found == false || second_art_found == false || third_art_found == false)
                    {
                        Console.WriteLine("6. Взглянуть на статую рядом с дверью");
                        Console.WriteLine("В статуе есть разъемы под 3 предмета. Пока у меня их нет.");
                    }
                    else if (first_art_found && second_art_found && third_art_found && chest_key_found == false)
                    {
                        Console.WriteLine("6. Взглянуть на статую рядом с дверью");
                        Console.WriteLine("Я нашел ключ от ящика!");
                        chest_key_found = true;
                    }
                    else
                    {
                        Console.WriteLine("6. Взглянуть на статую рядом с дверью");
                        Console.WriteLine("Я уже смотрел здесь.");
                    }
                }
// Другое число
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введено неверное число. Ожидается число от 1 до 6.");
                }
            }
        }
    }
}