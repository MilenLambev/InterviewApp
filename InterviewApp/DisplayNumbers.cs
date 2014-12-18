using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    public class DisplayNumbers
    {
        /// <summary>
        /// Displays and returns string, containing the numbers in the given range, 
        /// adding "fizz" for all folds of 3 and "buzz" for al folds of 5.
        /// </summary>
        /// <param name="startNumber">A number to start from.</param>
        /// <param name="endNumber">A number to end to.</param>
        /// <exception cref="ArgumentException">Throws an exception in case of </exception>
        /// <returns>Returns the formatted output to display.</returns>
        public string DisplayNumbersInRange(int startNumber, int endNumber)
        {
            if (startNumber > endNumber)
            {
                throw new ArgumentException("Invalid arguments. Start number cannot be greater than end number.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = startNumber; i <= endNumber; i++)
            {
                string valueToPrint = i.ToString();

                if (i % 3 == 0)
                {
                    valueToPrint += " fizz";
                }

                if (i % 5 == 0)
                {
                    valueToPrint += " buzz";
                }

                Console.WriteLine(valueToPrint);
                result.AppendLine(valueToPrint);
            }

            return result.ToString();
        }
    }
}
