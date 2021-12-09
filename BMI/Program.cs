using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabledecleration
            double height, weight,bmi;
            string bmiStatus = "string";

            //Input
            while (true) { 
            Console.WriteLine("***********************************************");
            Console.Write("Please give your height in cm: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please give your weight in kg: ");
            weight = Convert.ToDouble(Console.ReadLine());

            //Calculation
            height /= 100;
            bmi = weight / (height * height);

            if(bmi <= 18.5)
            {
                bmiStatus = "Untergewicht";
                Console.WriteLine("This is you Body-Mass-Index: {0:f2}\nThis is the category: {1}",bmi, bmiStatus);
                                                                  
            }                                                     
            else if(bmi <= 18.5 || bmi < 25.0)                    
            {                                                     
                bmiStatus = "Normalgewicht";                     
                Console.WriteLine("This is you Body-Mass-Index: {0:f2}\nThis is the category: {1}",bmi, bmiStatus);
                                                                  
            }                                                     
            else if (bmi <= 25.0 || bmi < 30.0)                    
            {                                                     
                bmiStatus = "leichtes Übergewicht";               
                Console.WriteLine("This is you Body-Mass-Index: {0:f2}\nThis is the category: {1}",bmi, bmiStatus);
                                                                  
            }                                                     
            else if (bmi <= 30.0 || bmi < 35.0)                   
            {                                                     
                bmiStatus = "starkes Übergewicht";                
                Console.WriteLine("This is you Body-Mass-Index: {0:f2}\nThis is the category: {1}",bmi, bmiStatus);
            }
            else if(bmi <=35.0 || bmi < 40)
            {
                bmiStatus = "extremes Übergewicht";
                Console.WriteLine("This is you Body-Mass-Index: {0:f2}\nThis is the category: {1}",bmi, bmiStatus);

            }
            //Output
            Console.WriteLine("***********************************************");
            Console.Write("One more test? y/n  : ");
            string yesno = Console.ReadLine();
            if(yesno == "n")
                {
                    System.Environment.Exit(1);
                }
                else { };
            };

        }
    }
}
