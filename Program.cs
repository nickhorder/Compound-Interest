using System;

namespace Compound_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
//
/* GET VARIABLES FROM USER, CONVERT TO DOUBLES WITH EXCEPTION HANDLING                */
//
// Ask user for their Starting Balance:
         Console.Write("What's your starting balance? £");
         string StartingBalString = Console.ReadLine();
            // Convert StartingBalString
            if (Double.TryParse(StartingBalString, out double StartingBalDoub));
            //            Console.WriteLine("Converted '{0}' to {1}.", StartingBalString, StartingBalDoub);
            else
                Console.WriteLine("The value you provided for Starting Balance was not " +
                "recognised. Please enter a numerical figure '{0}'.", StartingBalDoub);
//
// Ask user for the Interest Rate:
            Console.Write("What's the interest rate? %");
         string InterestRateString = Console.ReadLine();
            // Convert InterestRateString
            if (Double.TryParse(InterestRateString, out double InterestRateDoub));
            //    Console.WriteLine("Converted '{0}' to {1}.", InterestRateString, InterestRateDoub);
            else
                Console.WriteLine("The value you provided for the Interest Rate was not " +
                "recognised. Please enter a numerical figure '{0}'.", InterestRateDoub);
//
// Ask user for the Term:
            Console.Write("In years, how long are you saving for? ");
         string TermString = Console.ReadLine();
            // Convert TermString
            if (Double.TryParse(TermString, out double TermDoub));
            //    Console.WriteLine("Converted '{0}' to {1}.", TermString, TermDoub);
            else
                Console.WriteLine("The value you provided was not a valid number of " +
                "years. Please check and re-input a numerical value '{0}'.", TermDoub);
//
/* CONVERT PERCENTAGE FROM INT TO MULTIPLIABLE DECIMAL, i.e 4 to 1.04                 */
//   
            double Interest = InterestRateDoub / 100 + 1;
            //           Console.WriteLine(Interest);
//
/* CALCULATE COMPOUND INTEREST AND FINAL SUM AT END OF THE SAVINGS TERM               */
//           
             double FinalBal = StartingBalDoub * (Math.Pow(Interest, TermDoub));
//
/* DISPLAY THAT FIGURE TO NEAREST ROUNDED DOWN FULL INTEGER                           */
//
            Console.WriteLine("The amount you will have at the end of the savings period is £"
              + (Math.Floor(FinalBal)) + ". I do hope this helps you.");
        }
    }
}
