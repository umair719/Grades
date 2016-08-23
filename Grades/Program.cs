using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();


            /* When the name is changed, what method is called, in this case
            we are calling the OnNameChanged2

            you can add += to add more delegates or remove -= 
            */

            book.NameChanged += OnNameChanged;
            book.Name = "Umair's Grade Book";

            
            // events can still be added without a "new" keyword, since book.NameChanged is defined as a delegate
            // and adding a method to will automatically take place.
            //book.NameChanged += WriteResult;

            book.Name = "Hello";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);

        }

        // method which should be executed when the event is invoked
        static void OnNameChanged(object sender, NameChangedEventsArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }


        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }


        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }

        static void WriteResult(string existingName, string newName)
        {
            Console.WriteLine($"Name change from {existingName}: {newName:F2}", existingName, newName);
        }
    }
}