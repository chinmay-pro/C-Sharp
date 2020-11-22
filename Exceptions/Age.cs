using System;
namespace Exceptions
{
    class Age
    {
        public void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("You are not eligible for driving license.");
            } else if(age == 18)
            {
                throw new ArithmeticException("We wil think about you are driving license.");
            } else
            {
                Console.WriteLine("You are eligible for driving license.");
            }
        }
    }
}