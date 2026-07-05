namespace Hw_7
{
    internal class Tak5
    {
        interface IDrivable
        {
            void StartEngine();
            void StopEngine();
            void Drive();
        }

        class Car : IDrivable
        {
            public void StartEngine()
            {
                Console.WriteLine("Автомобіль: двигун запущено.");
            }

            public void StopEngine()
            {
                Console.WriteLine("Автомобіль: двигун вимкнено.");
            }

            public void Drive()
            {
                Console.WriteLine("Автомобіль їде.");
            }
        }

        class Motorcycle : IDrivable
        {
            public void StartEngine()
            {
                Console.WriteLine("Мотоцикл: двигун запущено.");
            }

            public void StopEngine()
            {
                Console.WriteLine("Мотоцикл: двигун вимкнено.");
            }

            public void Drive()
            {
                Console.WriteLine("Мотоцикл їде.");
            }
        }

        class Program
        {
            static void Main()
            {
                IDrivable car = new Car();
                IDrivable bike = new Motorcycle();

                Console.WriteLine("=== Автомобіль ===");
                car.StartEngine();
                car.Drive();
                car.StopEngine();

                Console.WriteLine();

                Console.WriteLine("=== Мотоцикл ===");
                bike.StartEngine();
                bike.Drive();
                bike.StopEngine();
            }
        }
    }
}
