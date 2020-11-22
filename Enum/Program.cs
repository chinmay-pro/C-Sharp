using System;

namespace Enum
{
    class Program
    {
   /*  enum ProgrammingLanguages
    {
        C = 8,
        Java,
        Cpp
    } */
     enum Levels
    {
        Top,
        Bottom,
        Middle
    }
        static void Main(string[] args)
        {
       /* Enum - An enum is a special "class" that represents a group of constants (unchangeable/read-only   variables).
    To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma */
       
        /* ProgrammingLanguages langVar = ProgrammingLanguages.Java;
        Console.WriteLine(langVar); */
         
        Levels levelVar = Levels.Top;
        switch (levelVar)
        {
           case Levels.Bottom:
           Console.WriteLine("Low level");
           break;
           case Levels.Middle:
           Console.WriteLine("Medium level");
           break;
           case Levels.Top:
           Console.WriteLine("High level");
           break;
        }

        /* Why And When To Use Enums?
           Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc. */
        }
    }
}
