using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab1
    {
        class Box
        {
            public double height;   // высота
            public double width;    // ширина
            public double length;   // длина

            // Метод: показать данные о ящике
            public void Show()
            {
                Console.WriteLine($"Коробка: ширина = {width}, высота = {height}, длина = {length}");
            }

            // Метод: рассчитать объём коробки
            public float Volume()
            {
                return (float)(width * height * length);
            }
        }

        class Program
        {
            static void Main()
            {
                // Создаём объект класса Box
                Box box = new Box();

                // Задаём значения
                box.width = 2;    // ширина
                box.height = 3;   // высота
                box.length = 5;   // длина

                // Выводим данные объекта
                box.Show();

                // Рассчитываем объём и выводим на экран
                float v = box.Volume();
                Console.WriteLine($"Объём коробки = {v}");
                Console.ReadKey();
            }
        }
    }
