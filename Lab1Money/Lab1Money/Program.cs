using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Lab1Money
{
    class Program
    {
        static void Main(string[] args)
        { 

            string input;
            Double a, b, c, d;
            
             
                              
          start:
            Console.WriteLine("Please enter your first amount.");
            input = Console.ReadLine();
            a = Convert.ToDouble(input);
            
            

            Console.WriteLine("Please enter your second amount.");
            input = Console.ReadLine();
            b = Convert.ToDouble(input);
            

            Console.WriteLine("please enter your third amount.");
            input = Console.ReadLine();
            c = Convert.ToDouble(input);
           

            d = a + b + c;

                               
            Console.WriteLine("Your total is $" + d.ToString("n2"));
           

            Console.WriteLine("your average is " + ((d / 3).ToString("n2")));
            

            double [] numbers = { a, b, c};
            double lowest = numbers.Min();
            double highest = numbers.Max();

            Console.WriteLine("Your lowest amount is $" + lowest.ToString("n2"));
           
            Console.WriteLine("Your highest amount is $" + highest.ToString("n2"));
            
            Console.WriteLine("Your USD amount is $" + d.ToString("n2"));
            

            d = Convert.ToInt64(d);
            Console.WriteLine("Your YEN amount is ¥" + d);
                       

            d = a + b + c;

            Console.WriteLine("Your SEK amount is " + d.ToString("C2", 
                  CultureInfo.CreateSpecificCulture("da-DK")));
            

          //  Console.WriteLine(+ d.ToString("#") + " ," + d.ToString("!#.##") + "kr");
            //Console.ReadLine();

            //Console.WriteLine("Your Krona amount is " + string.Format("{0:0.00}", d) + "kr");
            //Console.ReadLine();

            d = a + b + c;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Your THB amount is ฿ " + d.ToString("n2"));
            
            here:
            Console.WriteLine("Would you like to try again? Y/N");
            string answer = Console.ReadLine();
            switch (answer)
                {
                case "y":
                case "Y":
                    goto start;

                case "n":
                case "N":
                    break;

                default:
                    Console.WriteLine("Sorry I do not understand.");
                    goto here;
                }
            
            Console.WriteLine("Perfect! Good bye!");
            Console.ReadLine();

        }

    }
}