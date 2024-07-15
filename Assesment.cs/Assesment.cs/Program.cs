using System.Linq.Expressions;

namespace Assesment.cs
{

    class Car
    {
        string Model;
        string Year;

        public Car(string Model, string Year)
        {
            this.Model = Model;
            this.Year = Year;


        }

        public void Read()
        {
            Console.WriteLine("enter the Model:");
            Model = Console.ReadLine();
            Console.WriteLine("enter the year:yyyy-mm-dd");
            Year = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine($"Model={Model} year={Year}");
        }



        static void Main(string[] args)
        {
            Car car = new Car("suzuki", "2024 - 03 - 02");
            car.Read();
            car.Show();

        }    }
       
    

    }
    
