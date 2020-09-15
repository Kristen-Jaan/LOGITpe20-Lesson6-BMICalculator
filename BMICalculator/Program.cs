using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What Is Your Name?");
            string Name = Console.ReadLine();
            Console.WriteLine("How Old Are You?");
            int Age = Int32.Parse(Console.ReadLine());
            if (Age <= 20)
            {
                Console.WriteLine("You Are Too Young To Use This Calculator.");
            }                
            else if (Age >= 60)
            {
                Console.WriteLine("You Are Too Old To Use This Calculator.");
            }
                
            else
            {
                Console.WriteLine("How Tall Are You (In Metres) ?");
                double Height;
                Height = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your Height Is {Height} Metres.");
                Console.WriteLine("How Much To You Weight?");
                double Weight;
                Weight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"You Weight {Weight} Kilograms.");
                double BMI;
                double Height2 = Height * Height;
                BMI = Weight / Height2;
                Console.WriteLine($"Your BMI is {BMI} (kg/m2).");
                if (BMI < 19)
                {
                    Console.WriteLine("You Are Underweight.");
                }
                else if (BMI <= 24.9)
                {
                    Console.WriteLine("You Are Normal Weight.");
                }
                else if (BMI <= 29.9)
                {
                    Console.WriteLine("You Are OverWeight.");
                }
                else if (BMI > 30)
                {
                    Console.WriteLine("You Are Rasvane");
                }
                    


                
                    
                
                   


                

                

                
                
                

                
                
            }
















        }
    }
}
