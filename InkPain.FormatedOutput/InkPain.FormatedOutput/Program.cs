using System;

namespace InkPain.FormatedOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Александр";
            string lastName = "Пушки";
            string specalisation = "Писатель";

            byte age = 37;
            ulong yarOfBirth = 1799;

            //АлександрПушкинПисатель371799
            Console.WriteLine(firstName + lastName + specalisation + age + yarOfBirth); //так все выводится в одну строк
                                                                                        //поэтому иже будет другой способ для правильного вывода

            //Александр Пушкин Писатель 37 1799
            Console.WriteLine(firstName + " " + lastName + " " + specalisation + " " + age + " " + yarOfBirth); // так мы написали все раздельно

            //Имя: Александр Фамилия: Пушкин Специализация: Писатель возраст: 37 год рождения: 1799
            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Специализация: " + specalisation + " возраст: " + age + " год рождения: " + yarOfBirth); //так мы написали
                                                                                                                                                                         //с пояснением
                                                                                                                                                                         //Но эта запись в коде очень длинная
                                                                                                                                                                         //И выгледит не красиво и не удобно

            //Имя: Александр Фамилия: Пушкин Специализация: Писатель возраст: 37 год рождения: 1799
            Console.WriteLine("Имя {0} Фамилия {1} Специализация {2} возраст {3} год рождения {4}", //таким образм мы
                               firstName,                                                           //сделали код более
                               lastName,                                                            //вертикальным
                               specalisation,
                               age,
                               yarOfBirth);

            //Имя: Александр Фамилия: Пушкин Специализация: Писатель возраст: 37 год рождения: 1799
            string pattern = "Имя: {0}, Фамилия: {1}, Специализация: {2}, возраст: {3}, год рождения: {4}";
            Console.WriteLine(pattern,                                                              //А задав переменную и затем
                              firstName,                                                            //просот перечисля нужные переменные
                              lastName,                                                             // мы сделали код еще вертикальнее
                              specalisation,                                                        //и это правильно
                              age,
                              yarOfBirth);

            //Использование Паттернов, делаем чтоб каждое наиминование
            //было на отдельной строке
            string newPattern = "Имя: {0} \nФамилия: {1} \nСпециализация: {2} \nвозраст: {3} \nгод рождения: {4}";
            string fName = "Адда";
            string lName = "Лавлейс";
            string proff = "Кашевар";

            byte yars = 32;
            ulong birth = 1815;

            Console.WriteLine(pattern,      
                              fName,     
                              lName,        
                              proff,
                              yars,
                              birth);

            Console.WriteLine();

            Console.WriteLine(newPattern,   //из-за нового паттерна с 
                              fName,        //символом \n
                              lName,        //теперь каждая строка пишется отдельно
                              proff,
                              yars,
                              birth);

            // \n новая строка
            // \r Возврат каретки
            // \t горизонтальная табуляция
            // \' одиночкая кавычка
            // \" двойная кавычка
            // \\ обратный слеш
            // \? литерал вопросительного знака

            //Интерполяция строк проходит чере знак $
            Console.WriteLine($"имя: {firstName} Фамилия: {lastName} Специализация: {specalisation} возраст: {age} Год рождения {yarOfBirth} ");

            Console.WriteLine();

            Console.WriteLine(
                $"имя: {firstName} " +
                $"Фамилия: {lastName} " +
                $"Специализация: {specalisation} " +
                $"возраст: {age} " +
                $"Год рождения {yarOfBirth} ");

            Console.WriteLine();

            Console.WriteLine(
                $"\nимя: {firstName} " +
                $"\nФамилия: {lastName} " +
                $"\nСпециализация: {specalisation} " +
                $"\nвозраст: {age} " +
                $"\nГод рождения {yarOfBirth} ");

            //Типо калькулятор
            int a = 100;
            int b = 11;
            int c = 111;

            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine();

            //база данных

            string name1 = "Агата", lastname1 = "Лебедева";
            string name2 = "Мадина", lastname2 = "Виноградова";
            string name3 = "Катя", lastname3 = "Апельсинова";
            string name4 = "Алима", lastname4 = "Яблокова";
            string name5 = "Чурка", lastname5 = "Черная";

            Console.WriteLine($"{name1} {lastname1}");
            Console.WriteLine($"{name2} {lastname2}");
            Console.WriteLine($"{name3} {lastname3}");
            Console.WriteLine($"{name4} {lastname4}");
            Console.WriteLine($"{name5} {lastname5}");

            Console.WriteLine();

            //Сделаем так чтоб при отображении все было четко друг под другом
            //Для этого нужно указать число отступов после выведения переменной
            Console.WriteLine($"{name1,10} {lastname1,11}"); //указываем что под вывод первой переменной отступаем 10 символо
            Console.WriteLine($"{name2,10} {lastname2,11}"); // А от второй 11 символов
            Console.WriteLine($"{name3,10} {lastname3,11}");
            Console.WriteLine($"{name4,10} {lastname4,11}");
            Console.WriteLine($"{name5,10} {lastname5,11}");

            Console.WriteLine();

            //как работать с числовыми типами

            double d = 123456.654321;
            Console.WriteLine(d);                               //выводит 123456.654321

            string dFormated = d.ToString("#.###");             //переводим дабл в стрин и указываем как хотим это отбразить #.###
            Console.WriteLine(dFormated);                       //в нашем случаии мы показываем целое и 3 числа после запятой

            Console.WriteLine("{0:0.000}", d);                  //тоже самое что сверху только с помощю форматированого вывода

            Console.WriteLine(d.ToString("#.###"));             //теже яйца только в профиль

            dFormated = d.ToString("### ###.## ## ## ##");
            Console.WriteLine(dFormated);                       //Можно разделять числа пробелами

            Console.WriteLine(d.ToString("### ###.## ##"));

            Console.WriteLine();

            //вывод даты на экран
            var date = new DateTime(2025, 09, 28, 01, 30, 59); //28 сентября 2025 года new выделяем память под что-то
            Console.WriteLine(date);

            Console.WriteLine($"{date:HH:mm}");
            Console.WriteLine($"{date:yyyy-MM-dd}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"{date:dd.MM.yyyy}");































        }
    }
}
