using System;

namespace KcalCalculator
{
    class KcalCalculator
    {
        static void Main()
        {
            Console.Write("Име = ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Години = ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("********************** Интензивност при тренировки/кардио:");
            var maximumHeartRate = 220 - age;
            Console.WriteLine("Максималния за вас пулс е = {0}", maximumHeartRate);
            Console.WriteLine();
            Console.WriteLine("Цел");
            Console.WriteLine("(% от максималния пулс: 1 = начинаещ 55%, 2 = изгаряне на мазнини 65%-75%, 3 = развиване на мускулна маса с интервално кардио с ВИСОК ИНТЕНЗИТЕТ 85%-90%)");
            Console.Write("= ");
            int goal = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            if (goal == 1)
            {
                var maximumHeartRateTrain = maximumHeartRate * 0.55;
                Console.WriteLine($"{name}, максималния пулс за поддържане по време на вашата тренировка е = {Math.Round(maximumHeartRateTrain)}.");
            }
            else if (goal == 2)
            {
                var maximumHeartRateTrain = maximumHeartRate * 0.65;
                var maximumHeartRateTrain2 = maximumHeartRate * 0.75;
                Console.WriteLine($"{name}, максималния пулс за поддържане по време на вашата тренировка е = {Math.Round(maximumHeartRateTrain)}-{Math.Round(maximumHeartRateTrain2)}.");
            }
            else if (goal == 3)
            {
                var maximumHeartRateTrain = maximumHeartRate * 0.85;
                var maximumHeartRateTrain2 = maximumHeartRate * 0.90;
                Console.WriteLine($"{name}, максималния пулс за поддържане по време на вашата интервална тренировка е = {Math.Round(maximumHeartRateTrain)}-{Math.Round(maximumHeartRateTrain2)}.");
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Изчисление на калориите ->");
            Console.WriteLine();

            Console.WriteLine("********************** BASAL METABOLIC RATE - BMR по формулата на Harrys–Benedict:");
            Console.WriteLine();

            Console.Write("Пол (male или famale) = ");
            string gender = Console.ReadLine().ToLower();
            Console.WriteLine();

            Console.WriteLine("Дневна активност");
            Console.WriteLine("(1 = заседнала, 2 = спорт 1-3 на седм., 3 = спорт 3-5 на седм., 4 = спорт 6-7 на седм., 5 спорт всеки ден на седм. или двуразови тренировки)");
            Console.Write("= ");
            int activity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Тегло (в кг.) = ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Височина (в см.) = ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{name}, твоят резултат е:");
            Console.WriteLine();
            if (gender == "male")
            {
                var kcalMinimum = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);

                if (activity == 1)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.2);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 2)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.375);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 3)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.55);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 4)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.725);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 5)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.9);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
            }
            else if (gender == "famale")
            {
                var kcalMinimum = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);

                if (activity == 1)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.2);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 2)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.375);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 3)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.55);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 4)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.725);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
                else if (activity == 5)
                {
                    var kcalPerDay = Math.Round(kcalMinimum * 1.9);
                    Console.WriteLine($"{kcalPerDay} cal./day - за поддържане на теглото");
                    Console.WriteLine();
                    Console.WriteLine("***** Отслабване");
                    Console.WriteLine($"За отслабване с 0.5 кг. на седмица - {kcalPerDay - 550} cal./day");
                    Console.WriteLine($"За отслабване с 1 кг. на седмица - {kcalPerDay - 1100} cal./day");
                    Console.WriteLine();
                    Console.WriteLine("Общите нива на калории по-малки от 1100-1200 не се препоръчват!");
                    Console.WriteLine("По-добре желаните за намаляване калории под 1100-1200, да се намаляват с физическа активност.");
                    Console.WriteLine();
                    Console.WriteLine("***** Покачване");
                    Console.WriteLine($"За покачване с 0.5 кг. на седмица - {kcalPerDay + 550} cal./day");
                    Console.WriteLine($"За покачване с 1 кг. на седмица - {kcalPerDay + 1100} cal./day");
                }
            }
            else
            {
                Console.WriteLine("!!! ERROR !!!");
                Console.WriteLine("Информацията не е попълнена коректно.");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
