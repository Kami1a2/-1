using System.Linq;
using System;

namespace Лабораторная_1_з2
{
    class Program
    {

        static void Main()
        {
            //Создание элементов для подсчета баллов и попыток
            
            double attempts = 0;
            double corect = 0;
     
            Console.WriteLine("Игра в слоги начинается! Ведите слово состоящее из 3 слогов. Введите пустую строку для завершения.");
            // Вход в цикл для взаимодействия с пользователем
            while (true)
            {
                // Запрос от пользователя 
                Console.Write("Введите слово: ");
                string word = Console.ReadLine().Trim();
                // Проверка на выход из цикла
                if (string.IsNullOrEmpty(word))
                {
                    Console.WriteLine("Игра завершена.");
                    break;
                }
                attempts++;
              
                // Проверяем правильность ввода слова с заданным числом слогов (например, 3 слога)
                if (IsWordWithSyllables(word, 3))
                {
                    Console.WriteLine("Правильно!");
                    corect ++; // За каждый правильный ответ добавляем 1 баллов
                }
                else
                {
                    Console.WriteLine("Неправильно :(");
                }


            }
            // Вывод результатов
            double score = (corect / attempts) * 100.0;
            int score2 = (int)score;
            Console.WriteLine($"Игра завершена. Количество баллов: "+ score2);
           
            Console.WriteLine($"Количество попыток: {attempts}");
            Console.ReadLine();
        }

        static bool IsWordWithSyllables(string word, int syllables)
        {
            // метод для определения числа слогов в слове.
            // считаем слоги как количество гласных букв.
            int count = 0;
            foreach (char letter in word.ToLower())
            {
                if ("aeiouаеёиоуыэюя".Contains(letter))
                {
                    count++;
                }
            }
            return count == syllables;
        }
    }
}