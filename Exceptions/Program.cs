using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.

            When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error). */
          /*  try
            {
                int [] arr = {1,2,3,4,5};
                arr[6] = 77;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred : " + e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' executed");
            } */
            Console.WriteLine("Enter your age : ");
            var age = Convert.ToInt32(Console.ReadLine());
            Age myage = new Age();
            myage.checkAge(age);
        }
    }
}
