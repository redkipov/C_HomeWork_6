using System;
using System.Threading.Tasks;
using System.Threading;
//HomeWork 6 C#
//Developer kipov.m.h
//28.08.2022

namespace HomeWork2
{

    class Program
    {
        ////////////Глобальные переменные////////////////
        public const string VerDev = "V.0.2.0";
        //////Номер задания//////
        public const string NamberWork = "Home work 6";
        //////Название программ///////
        public const string ProgramName_1 = "Программа принимает на вход отрицательные и положительные числa и выдает количетво чисел больше 0.";
        public const string ProgramName_2 = "Программа принимает на вход 4 различных числа. b1,k1,b2,k2 и находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.";
        public const string ProgramName_3 = "Null";
        public const string ProgramName_4 = "Null";
        public const string ProgramName_5 = "Null";
        //////////////////////////////
        public static bool LoadScrin = true;
        ///////

        ///////////////////////////////////////// Промежуточное меню для выхода или продолжнеия программы //////////////////////////////
        static void Contin()
        {
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы начать.");

            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.\n");
            Console.ResetColor();
        }
        //////////////////////////////////// Выход из программы по нажатию кнопок //////////////////////////////////////////////////////
        static int textWrite(int Exit_Play, string NameProg)
        {
            Contin();
           
            while (true)
            {
                String Presskey = Convert.ToString(Console.ReadKey().Key);
                if (Presskey == "q0" || Presskey == "End" || Presskey == "Backspace" || Presskey == "Escape" || Presskey == "Q1" || Presskey == "Q" || Presskey == "q")
                {
                    return 0;
                }
                else if (Presskey == "Enter" || Presskey == "Spacebar")
                {
                    return 1;
                }
                else
                {
                    devWrite(NameProg);
                    Contin();
                }

            }
        }
        ///////////////////////////////// Очистка экрана и вывод redkipov. ////////////////////////////////////////////////////////////
        static void devWrite(string s)
        {
            Console.Clear();
            const String nameDev = "redkipov";
            Console.ForegroundColor = ConsoleColor.Cyan; // цвет 
            Console.Write("developer - ");
            Console.ForegroundColor = ConsoleColor.DarkRed; // цвет 
            Console.WriteLine(nameDev);
            Console.ForegroundColor = ConsoleColor.DarkGray; // цвет 
            Console.WriteLine(VerDev);
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет 
            Console.WriteLine(s);
            Console.ResetColor();
        }
        /////////////////////////////////////////////////// Меню приветствия //////////////////////////////////////////////////////////
        //___________________________________________________________________________________________________________________________//
        static void WelcomeWrite(string NameProg)
        {
            devWrite(NameProg);
            Console.ForegroundColor = ConsoleColor.DarkCyan; //  цвет
            Console.WriteLine(NamberWork);
            Console.ForegroundColor = ConsoleColor.Green; //  цвет зеленый
            Console.Write("Введите соотвествующую цифру программы, которую вы хотите ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //  цвет
            Console.WriteLine("запустить");
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[1] "); ////// Первая программа.
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_1);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[2] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_2); /*
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[3] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_3); 
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[4] "); 
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_4);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[5] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_5); */
            ///////////////////////////////////////////////////////////
            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        //############################################### Программа 1 ###############################################################//
        //###########################################################################################################################//
        static void Program_1(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[1] {ProgramName_1}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((    
                int[] UserNumbers = { 0, 0, 0, 0, 0 };
                //int[] resultArrey = {0,0,0,0,0};
                int result = 0;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Введите 5 положительных и отрицательных чисел: ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Введите {i + 1}-e число: ");
                    UserNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                //
                for (int i = 0; i < UserNumbers.Length; i++)
                {
                    if (UserNumbers[i] > 0)
                    {
                        result++;
                    }
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                ////////............. Вывод результата .............//////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {5}");
                Console.Write("Введенные числа: ");
                WriteArray(UserNumbers, 1);
                Console.Write("Количестово чисел больше zero: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(result);
                //Console.ForegroundColor = ConsoleColor.White;
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 2 ###############################################################//
        //###########################################################################################################################//
        static void Program_2(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[2] {ProgramName_2}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                decimal[] UserNumbers = { 0, 0, 0, 0, 0 };
                decimal x = 0;
                decimal y = 0;
                decimal resultX = 0;
                int j = 1;
                int g = 1;
                char name = 'k';
                bool results = false;
                //))))))))))))))))) Logica (((((((((((((((((  
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Введите координаты отрезка b1 и k1 и отрезка b2 и k2: ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{j}-отрезок. Введите {g}-e число {name}{j}: ");
                    UserNumbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (i == 1 && j < 2) { j++; }
                    if (i == 0) { g = 2; name = 'b'; } else if (i == 1) { g = 1; name = 'k'; } else if (i == 2) { g = 2; name = 'b'; }
                }
                x = UserNumbers[0] - UserNumbers[2];
                if (UserNumbers[0] != UserNumbers[2])
                {
                    if (UserNumbers[3] < 0)
                    {
                        y = UserNumbers[3] - UserNumbers[1];
                    }
                    else
                    {
                        y = UserNumbers[3] - UserNumbers[1];
                    }
                    if (y == 0 && x == 0)
                    {
                        resultX = 0;
                    }
                    else
                    {
                        resultX = y / x;
                    }
                    x = UserNumbers[0] * resultX + UserNumbers[1];
                    y = UserNumbers[2] * resultX + UserNumbers[3];
                    results = true;
                }
                else
                {
                    results = false;
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                ////////............. Вывод результата .............//////
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Заданные числа: k1={UserNumbers[0]}, b1={UserNumbers[1]}, k2={UserNumbers[2]}, b2={UserNumbers[3]}. ");
                if (results)
                {
                    Console.Write("Точка пересечения по X: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(resultX);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Точка пересечения по Y: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(x + " сравнение " + y);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНет решения, линии лежат параллельно.");
                    Console.WriteLine("Нет точек пересечения.");
                }
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 3 ###############################################################//
        //###########################################################################################################################//
     /*   static void Program_3(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[3] {ProgramName_3}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica ((((((((((((((((( 
                Console.WriteLine("Введите размер массива (не больше 20-ти): ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                decimal[] array = CreaterArrayVi(UserNumbers);
                array = ShuffleVi(array);
                decimal max = array[0];
                decimal min = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Числа в массиве: ");
                WriteArrayVi(array, 1);
                Console.Write("Разница между минимальным и максимальным числом: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(max - min);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($", минимальное число: {min}, максимальное число: {max}.\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 4 ###############################################################//
        //###########################################################################################################################//
        static void Program_4(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[4] {ProgramName_4}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                //))))))))))))))))) Logica ((((((((((((((((( 
                int UserNumbers = 123;
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array, 0, 300);
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 9 && array[i] < 100)
                    {
                        result++;
                    }
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("123 сгенерерованных чисел в массиве: ");
                WriteArray(array, 1);
                Console.Write("\nКоличество элементов массива, которые лежат в отрезке от 10 до 99: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(result);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(".\n");
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 5 ###############################################################//
        //###########################################################################################################################//
        static void Program_5(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[5] {ProgramName_5}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                //))))))))))))))))) Logica ((((((((((((((((( 
                Console.WriteLine("Введите размер массива (не больше 20-ти): ");
                int UserNumbers = Convert.ToInt32(Console.ReadLine());
                int[] array = CreaterArray(UserNumbers);
                array = Shuffle(array, 1, 20);
                int[] resultArrey = new int[array.Length];
                int size = array.Length - 1;
                int trig = 0;
                if (array.Length % 2 == 0)
                {
                    for (int i = 0; i < size; i++)
                    {
                        resultArrey[i] = array[i] * array[size];
                        size--;
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        resultArrey[i] = array[i] * array[size];
                        size--;
                        trig = i + 1;
                    }
                    resultArrey[(array.Length - 1) - trig] = array[(array.Length - 1) - trig];
                }
                //))))))))))))))))) End Logica (((((((((((((((((
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Размер массива: {UserNumbers}");
                Console.Write("Числа в массиве: ");
                WriteArray(array, 1);
                Console.Write("Произведение пар чисел в массиве: ");
                Console.ForegroundColor = ConsoleColor.Green;
                WriteArray(resultArrey, 0);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
    */
        //############################################### Программа скрытая #########################################################//
        //###########################################################################################################################//
        static void Program_7(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = "Скрытое меню";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                devWrite(NameProg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Генератор 20 случайных чисел");
                Console.ResetColor();
                ////////**************** Logica **************////////
                int[] array = CreaterArray(20);
                WriteArray(array, 1);
                array = Shuffle(array, 0, 100);
                WriteArray(array, 1);
                ////////**************** End Logica **************////////
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        /////////////////// функции работы с массивами //////////////////
        static int WriteArray(int[] array, int zero)
        {
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                    else if (array[i] > 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                }
                else
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else if (array[i] > 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else
                    {
                        Console.Write(".......\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            if (zero == 1) { return numbers = 0;}
            else { return numbers;}
        }
        ////////////////////////////////////////////////   
        static int WriteArrayVi(decimal[] array, int zero) //2
        {
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (zero == 1 || zero == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                    else if (array[i] > 0 && zero == 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                }
                else
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else if (array[i] > 0 && zero == 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else
                    {
                        Console.Write(".......\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            if (zero == 1) {return numbers = 0;} else {return numbers;}
        }
        //
        static int[] CreaterArray(int number)
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        //
        static decimal[] CreaterArrayVi(int number) //2
        {
            decimal[] array = new decimal[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        //
        static int[] Shuffle(int[] array, int amount, int amount2)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int j = new Random().Next(0, i + 1);
                int number = new Random().Next(amount, amount2);

                // array[i] = array[i];
                array[i] = number;
            }
            return array;
        }
        static decimal[] ShuffleVi(decimal[] array) //2
        {

            for (int i = 0; i < array.Length; i++)
            {
                decimal j = new Random().Next(0, i + 1);
                decimal number = new Random().Next(10, 800);

                array[i] = array[i];
                array[i] = number;
            }
            return array;
        }

        //******************************************************** MAIN *********************************************************************//
        //###################################################################################################################################//

        static void Main(string[] args)
        {
            string PresskeyP = "Null";
            const String NameProg = "Главное меню";
            int Exit_Play = 1;
            WriteMenu(NameProg);
            while (true)
            {
                /////////////////////////////////////////// Ожидание нажатия кнопки //////////////////////////////////////////
                PresskeyP = Convert.ToString(Console.ReadKey().Key);

                //////////////////////////////////// Выбор пункта меню, нужной программы /////////////////////////////////////
                if (PresskeyP == "D1" || PresskeyP == "NumPad1")
                {
                    LoadScrin = false;
                    Console.CursorVisible = true;
                    Program_1(Exit_Play);//запуск функции
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "D2" || PresskeyP == "NumPad2")
                {
                    LoadScrin = false;
                    Console.CursorVisible = true;
                    Program_2(Exit_Play);//запуск функции
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "D3" || PresskeyP == "NumPad3")
                {
                    //Program_3(Exit_Play);

                }
                else if (PresskeyP == "D4" || PresskeyP == "NumPad4")
                {
                    //Program_4(Exit_Play);

                }
                else if (PresskeyP == "D5" || PresskeyP == "NumPad5")
                {
                    //Program_5(Exit_Play);
                }
                else if (PresskeyP == "D6" || PresskeyP == "NumPad6")
                {
                    //Program_6(Exit_Play);
                }
                else if (PresskeyP == "D7" || PresskeyP == "NumPad7")
                {
                    LoadScrin = false;
                    Console.CursorVisible = true;
                    Program_7(Exit_Play); //запуск 
                    LoadScrin = true;
                    WriteMenu(NameProg);
                }
                else if (PresskeyP == "q0" || PresskeyP == "End" || PresskeyP == "Backspace" || PresskeyP == "Escape" || PresskeyP == "Q1" || PresskeyP == "Q" || PresskeyP == "q")
                {
                    System.Environment.Exit(-1);
                    return;
                }

            }
        }

        static void WriteMenu(String NameProg)
        {
            WelcomeWrite(NameProg);
            Console.WriteLine(" ");
            Method();
        }

        static async void Method()
        {
            int k = 0;
            char[] LoadString = {'/' ,'/', '/', '/', '/', '/', '/' };
            ///////////////////////////////////////////////// Task 1
            await Task.Run(() =>
            {
                //async
            });
            ///////////////////////////////////////////////// Task 2
            while (LoadScrin)
            {
                await Task.Delay(500);
                k++;
                if (LoadScrin)
                {
                    //await Task.Delay(950);
                    //Thread.Sleep(1000);
                    Console.Write($"                                                 \r");
                    Console.CursorVisible = false;
                    //var Time = DateTime.Now;
                    //Console.Write($"{Time} ");
                }
                else if (!LoadScrin) {return;}

                for (int i = 0; i < k; i++) { Console.Write(LoadString[i]); if (k==LoadString.Length+1) {k = 0;} }
            }
            //await Task.Run(() => Program_7(1) );
        }
    }
        //######################################################## END ###############################################################//
}
//###########################################################################################################################//