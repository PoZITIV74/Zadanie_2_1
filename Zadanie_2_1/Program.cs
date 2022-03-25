using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zadanie_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
               Console.WriteLine("Массив чисел в диапозоне от 0 до 10000:");
                int[] numbers = new int[10000];  // задаются строки и столбцы
                Random ran = new Random();
                var check = new HashSet<int>(); // будет смотреть дубль числа



                for (int i = 0; i < numbers.GetLength(0); i++) // numbers.GetLength(0) сьроки 5
                {
                    int newNumbers;
                    newNumbers = ran.Next(0, 10001);
                    while (check.Contains(newNumbers))  // если находит такоеже число то его пересоздает 
                    {
                        newNumbers = ran.Next(0, 10001);
                    }
                    check.Add(newNumbers);      // чистые
                    numbers[i] = newNumbers;
                }




                for (int i = 0; i < numbers.Length; i++) //задает строки
                {

                    Console.Write($"{numbers[i]} \t"); // выводит получившийся результат

                }

                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("");
                int[] numbers4 = new int[numbers.Length]; // новый массив
                numbers.CopyTo(numbers4, 0);        // копируется начальный
                Stopwatch stopwatch = new Stopwatch();
                //засекаем время начала операции
                stopwatch.Start(); // начало отсчета

                int puzir;          // сортировка пузырем
                for (int i = 0; i < numbers4.Length; i++)
                {
                    for (int j = i; j < numbers4.Length; j++)
                    {
                        if (numbers4[i] > numbers4[j])
                        {
                            puzir = numbers4[i];            // сравнивает массивы между собой до тех пор пока все не встанет
                            numbers4[i] = numbers4[j];      // большие элементы отправляет в конец наименьшие в начало
                            numbers4[j] = puzir;
                        }
                    }
                }



                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("Сортировка пузырем:");
                stopwatch.Stop(); // окончание расчета 
                TimeSpan time = stopwatch.Elapsed;
                // Создаем строку, содержащую время выполнения операции.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    time.Hours, time.Minutes, time.Seconds,
                    time.Milliseconds / 10);
                Console.WriteLine(elapsedTime);



                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("Сортировка вставками:");

                int[] numbers2 = new int[numbers.Length]; // новый массив
                numbers.CopyTo(numbers2, 0);        // копируется начальный
                Stopwatch stopwatch2 = new Stopwatch();
                //засекаем время начала операции
                stopwatch2.Start();

                for (int i = 1; i < numbers2.Length; i++)
                {
                    int inserts = numbers2[i];
                    int j = i;
                    while (j > 0 && inserts < numbers2[j - 1])      // переставляет числа
                    {
                        numbers2[j] = numbers2[j - 1];  // помещает в уже отсортрированное 
                        j--;
                    }
                    numbers2[j] = inserts;
                }

                stopwatch2.Stop(); // окончание расчета 
                TimeSpan time2 = stopwatch2.Elapsed;
                // Создаем строку, содержащую время выполнения операции.
                string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", // формат времени
                    time2.Hours, time2.Minutes, time2.Seconds,
                    time2.Milliseconds / 10, time2.Ticks * 100);
                Console.WriteLine(elapsedTime2);


                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("Сортировка выбором:");
                int[] numbers3 = new int[numbers.Length]; // новый массив
                numbers.CopyTo(numbers3, 0);        // копируется начальный
                Stopwatch stopwatch3 = new Stopwatch();
                //засекаем время начала операции
                stopwatch3.Start();

                for (int i = 0; i < numbers3.Length - 1; i++)
                {
                    int min = i;        // находит минимальное значение 
                    for (int j = i + 1; j < numbers3.Length; j++)
                    {
                        if (numbers3[j] < numbers3[min])    // производит обмен с первой
                        {
                            min = j;
                        }
                    }
                    int vibor = numbers3[i];        // сортирует 
                    numbers3[i] = numbers3[min];
                    numbers3[min] = vibor;


                }

                stopwatch3.Stop(); // окончание расчета 
                TimeSpan time3 = stopwatch3.Elapsed;
                // Создаем строку, содержащую время выполнения операции.
                string elapsedTime3 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    time3.Hours, time3.Minutes, time3.Seconds,
                    time3.Milliseconds / 10);
                Console.WriteLine(elapsedTime3);

                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("Сортировка Шелла:");

                int[] numbers5 = new int[numbers.Length]; // новый массив
                numbers.CopyTo(numbers5, 0);        // копируется начальный
                Stopwatch stopwatch4 = new Stopwatch();
                //засекаем время начала операции
                stopwatch4.Start();


                int shell = numbers5.Length / 2;
                while (shell > 0)
                {
                    for (int i = 0; i < (numbers5.Length - shell); i++)
                    {
                        int s = i;
                        while ((s >= 0) && (numbers5[s] > numbers5[s + shell]))
                        {
                            int t = numbers5[s];
                            numbers5[s] = numbers5[s + shell];  // сравнивает и сортируем между собой и затем она повторяется пока все не отсортируется
                            numbers5[s + shell] = t;
                            s -= shell;
                        }
                    }
                    shell = shell / 2;
                }


                stopwatch4.Stop();   // окончание расчета 
                TimeSpan time4 = stopwatch4.Elapsed;
                // Создаем строку, содержащую время выполнения операции.
                string elapsedTime4 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    time4.Hours, time4.Minutes, time4.Seconds,
                    time4.Milliseconds);
                Console.WriteLine(elapsedTime4);

                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("Сортировка Расчесткой:");



                int[] numbers6 = new int[numbers.Length]; // новый массив
                numbers.CopyTo(numbers6, 0);        // копируется начальный
                Stopwatch stopwatch6 = new Stopwatch();
                //засекаем время начала операции
                stopwatch6.Start();


                double ras = numbers6.Length;
                bool rasch = true;
                while (ras > 1 || rasch)
                {
                    ras /= 1.247330950103979;  // будет выбраное число делить на это
                    if (ras < 1) { ras = 1; }
                    int i = 0;
                    rasch = false;
                    while (i + ras < numbers6.Length)       
                    {
                        int igap = i + (int)ras;                       // округляет до целого
                        if (numbers6[i] > numbers6[igap])              // по убыванию сортитрует 
                        {
                            int swap = numbers6[i];
                            numbers6[i] = numbers6[igap];
                            numbers6[igap] = swap;
                            rasch = true;
                        }
                        i++;
                    }
                }


                stopwatch6.Stop();  // окончание расчета 
                TimeSpan time6 = stopwatch6.Elapsed;
                // Создаем строку, содержащую время выполнения операции.
                string elapsedTime6 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    time6.Hours, time6.Minutes, time6.Seconds,
                    time6.Milliseconds);
                Console.WriteLine(elapsedTime6);

                Console.WriteLine("___________________________________________________________");
                Console.WriteLine(""); 
            } // 1 задание

          
        }
    }
}
