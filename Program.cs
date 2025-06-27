using System;

namespace MuzykantApp 
{
    
    enum Repertuar
    {
        Bach,        
        Chaikovsky,  
        List,        
        Mozart,      
        Rossini   
    }

    
    class Muzykant
    {
        // Свойство (переменная) уровня концерта — сколько очков набрано за исполнение
        public int ConcertLevel { get; private set; }

        // Конструктор — вызывается при создании объекта. Уровень концерта изначально 0.
        public Muzykant()
        {
            ConcertLevel = 0;
        }

        // Метод исполнения — принимает одного композитора из перечисления
        public void Ispolnenie(Repertuar composer)
        {
            // Выбираем поведение в зависимости от композитора
            switch (composer)
            {
                case Repertuar.Bach: // Если выбран Бах
                    ConcertLevel += 10; // Увеличиваем уровень на 10
                    Console.WriteLine("Исполняется Бах. Классика строгости."); // Сообщение на экран
                    break;

                case Repertuar.Chaikovsky: // Если выбран Чайковский
                    ConcertLevel += 15; // Уровень +15
                    Console.WriteLine("Исполняется Чайковский. Душевная глубина.");
                    break;

                case Repertuar.List: // Если выбран Лист
                    ConcertLevel += 12; // Уровень +12
                    Console.WriteLine("Исполняется Лист. Виртуозность на пределе.");
                    break;

                case Repertuar.Mozart: // Если выбран Моцарт
                    ConcertLevel += 8; // Уровень +8
                    Console.WriteLine("Исполняется Моцарт. Легкость и грация.");
                    break;

                case Repertuar.Rossini: // Если выбран Россини
                    ConcertLevel += 20; // Уровень +20
                    Console.WriteLine("Исполняется Россини. Энергия и блеск.");
                    break;

                default: // Если передано что-то другое (в принципе невозможно в этом контексте)
                    Console.WriteLine("Неизвестный композитор.");
                    break;
            }
        }

        // Метод для вывода уровня концерта на экран
        public void PrintLevel()
        {
            Console.WriteLine($"Уровень концерта: {ConcertLevel}"); // Печатаем текущий уровень
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём первого музыканта
            Muzykant m1 = new Muzykant();

            // Создаём второго музыканта
            Muzykant m2 = new Muzykant();

            // Первый музыкант исполняет двух композиторов
            m1.Ispolnenie(Repertuar.Bach);     // Бах (уровень +10)
            m1.Ispolnenie(Repertuar.Rossini);  // Россини (уровень +20)

            // Выводим уровень концерта первого музыканта
            m1.PrintLevel(); // Ожидаемый результат: 30

            Console.WriteLine(); // Пустая строка для отделения вывода

            // Второй музыкант исполняет трёх композиторов
            m2.Ispolnenie(Repertuar.Mozart);      // +8
            m2.Ispolnenie(Repertuar.Chaikovsky);  // +15
            m2.Ispolnenie(Repertuar.List);        // +12

            // Выводим уровень концерта второго музыканта
            m2.PrintLevel(); // Ожидаемый результат: 35

            Console.WriteLine("\nНажмите любую клавишу для выхода...");

            Console.ReadKey();
        }
    }
}


//Используя Visual Studio,создайте проект по шаблону Console Application.
//Создфть несколько экземпляров класса и выдать на консоль значение свойства при выбранной константе из перечисления
//Создайте класс МУзыкант.У музыканта будет свойство "Уровень концерта" и метод "Исполнение".Создайте перечисление Репертуар(Бах,Чайковский,Лист,Моцарт,Россини).Каждый композитор в концертной программе должен по -разному влиять на уровень концерта.