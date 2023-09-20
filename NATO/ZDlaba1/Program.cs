namespace ZDlaba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The X variable: ");
            y(double.Parse(Console.ReadLine()));
        }

        static double y(double x)
        {
            return ((Math.Sqrt(x + 1) - Math.Sin(x - Math.PI)) / (Math.Cos(x - 3.1) + Math.Pow(Math.Log(x), 2))) + x * Math.Log(x);
        }
        static void Task_1()
        {

            // Кортеж "hardware"
            var hardware = Tuple.Create("комп'ютер", "монітор", "принтер", "клавіатура", "модем");

            // Список "software"
            var software = new List<string> { "операційна система", "браузер", "антивірус", "офісний пакет", "графічний редактор" };

            // Виведення назв елементів кортежу
            Console.WriteLine(hardware.Item1);
            Console.WriteLine(hardware.Item2);
            Console.WriteLine(hardware.Item3);
            Console.WriteLine(hardware.Item4);
            Console.WriteLine(hardware.Item5);

            // Заміна одного елемента в списку "software"
            software[2] = "відеоредактор";

            // Виведення назв елементів списку після заміни
            foreach (var item in software)
            {
                Console.WriteLine(item);
            }

            // Список професій
            var professions = new List<string> { "лікар", "вчитель", "інженер", "адвокат", "програміст" };

            // Додавання нового елемента до списку професій
            professions.Add("архітектор");

            // Видалення елемента зі списку професій
            professions.Remove("лікар");

            // Перевірка, чи існує певна професія в списку
            bool containsEngineer = professions.Contains("інженер");
            Console.WriteLine($"Чи є професія 'інженер' у списку: {containsEngineer}");

            // Отримання кількості елементів у списку
            int numberOfProfessions = professions.Count;
            Console.WriteLine($"Кількість професій у списку: {numberOfProfessions}");
        }

        static void Task_2()
        {
            // Створення словника для глосарію
            Dictionary<string, string> glossary = new Dictionary<string, string>();

            // Додавання термінів та їх визначень до глосарію
            glossary.Add("Змінна", "Об'єкт, який зберігає дані.");
            glossary.Add("Цикл", "Конструкція, що дозволяє повторювати виконання коду.");
            glossary.Add("Функція", "Блок коду, який можна викликати багато разів.");

            // Виведення глосарію на екран
            foreach (var term in glossary)
            {
                Console.WriteLine($"{term.Key}:\n\t{term.Value}\n");
            }
        }

    }
}