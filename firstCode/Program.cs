using System;

namespace firstCode
{
    class Program
    {
         
      static void Greet(String name) {
        Console.WriteLine("Good Morning " + name);
      }

      static float avarage(int a, int b, int c) {
        float sum = a + b + c;
        return sum / 3;
      } 
      static float avarage(int a, int b) {
        float sum = a + b;
        return sum / 3;
      }

        static void Main(string[] args)
        {
           // Single line Comments
           /* Multi line Comments */

            /* int age = 13;
           Console.WriteLine("Hello World");
            Console.Write(" am " + age + " years old"); */
           /* Datatypes : 
             Integer - int age; --> 4 bytes
             Long - long chinmay; --> 8 bytes
             Floating point number - float d; --> 4 bytes
             Double - double chinmay; --> 8bytes
             Character - char a = 'A'; --> 2 bytes
             Boolean - bool isFantasy = true; --> 1 bytes
              String - string inp = "Chinmay"; --> 2 bytes per chararcter */ 
        /*    String inp = Console.ReadLine();
            Console.WriteLine(inp); */

            // Datatypes Example
           /* int a = 56;
            float b = 67.9F;
            double c = 67.9D;
            bool isGreat = true;
            char d = 'C';
            String str = "This is a String";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(isGreat);
            Console.WriteLine(d);
             Console.WriteLine(str); */
          /* Type Casting
          There are two types of type Casting
          1. Implicit Casting - char to int to long to float to double
          2. Explicit Casting */

            // int a = (int) 45.9;
           /* int a = 3;
            double b = 4;
            float c = 'A'; // ASCII VALUE
            float var = Convert.ToInt32(45.88);
            String v = "67 is amazing";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c); */
            
           /* Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("How many candies do you want?");
            string num = Console.ReadLine();
            Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(num) + 4)); */

            // Opreators
            /* 1. Arithmetic Operators
            2. Assignment Operators
            3. Logical Opreators
            4. Comparison Operators */
            /* int a = 6;
            int b = 4;
            Console.WriteLine("The value of a+b is : " + (a+b));
            Console.WriteLine("The value of a-b is : " + (a-b));
            Console.WriteLine("The value of a*b is : " + (a*b));
            Console.WriteLine("The value of a/b is : " + (a/b)); */

            // Assignment Operators
           /* int a = 47;
            int b = 67;
           b += 3;
            b -= 3;
            b *= 3;
            b /= 3;
            Console.WriteLine(b); */

            // Logical operators
            /* Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false); 
            
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false); 

            Console.WriteLine(!true);
            Console.WriteLine(!false); */

            // Comparison operators
           /* Console.WriteLine(455 < 899);
            Console.WriteLine(455 <= 899);
            Console.WriteLine(455 >= 899);
            Console.WriteLine(455 != 899);
            Console.WriteLine(455 == 899); */
            
            /* int a = Math.Max(34,89);
             int a = Math.Min(34,89);
             double a = Math.Sqrt(2);
             int a = Math.Abs(-2); 
            Console.WriteLine(a); */

           /* string str = "Hello I am Chinmay";
            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str + "You are great");
            Console.WriteLine(string.Concat(str, " You are great")); */

             /*  String name = Console.ReadLine(); 
               String candies = Console.ReadLine();

               Console.WriteLine($"Your name is {name}. you will get {candies} candies"); */
              /* string str = "Hello I am Chinmay";
               Console.WriteLine(str[0]);
               Console.WriteLine(str.IndexOf("Hello"));
               Console.WriteLine(str.Substring(1)); */

                /* Console.WriteLine("Hello who are \" you");
                Console.WriteLine("Hello who are \n you");
                Console.WriteLine("Hello who are \t you"); */

             /*  Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 18 && age < 100)
                {
                    Console.WriteLine("You can drive");
                }else if(age == 18){
                    Console.WriteLine("We will think about you");
                }else{
                  Console.WriteLine("You can't drive");
                } */

               /* int age = 20;
                switch (age)
                {
                   case 18:
                      Console.WriteLine("Please wait for an year");
                      break;

                   case 20:
                      Console.WriteLine("You are 20");
                      break;

                   default:
                      Console.WriteLine("Enjoy");
                      break;
                } */

              /* Arrays - int [] arr = {1,2,3,4,5};
                String [] strarr = {"Act","Airtel","Joister","VI","Vodaphone"};
                Console.WriteLine(arr[0]);
                Console.WriteLine(strarr[0]); */

                // Loops
                // For loop
               /* for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                    
                } 
                for (int i = 1; i <= 5; i++)
                {
                    // continue;
                    Console.WriteLine(i);
                    // break;
                } */

                // While loop
               /* int i = 1;
                while (i <= 5)
                {
                    Console.WriteLine(i);
                    i++;
                } */

                // Do while
              /*  int i = 1;
                do
                {
                    Console.WriteLine(i);
                    i++;
                } while (i <= 5); */
                
                // For Each loop
             /*   String [] strarr = {"Act","Airtel","Joister","VI","Vodaphone"};
              foreach (var item in strarr)
              {
                  Console.WriteLine(item);
              } */

              /* Break and continue;
               Break - leave this loop forever
               Continue - Leave this particular iteration of loop */
              /* Greet("Chinmay");
               Greet("Sam");
               Console.WriteLine(avarage(2,6,8));
               float temp = avarage(99,7,8);
               Console.WriteLine(temp);
               Console.WriteLine(avarage(3,3,3));
               Console.WriteLine(avarage(3,3)); */

              // OOPs - Classes and objects
              /* Player chinmay = new Player();
               Console.WriteLine(chinmay.getHealth());
               chinmay.setHealth(89);
               Console.WriteLine(chinmay.getHealth()); */
               
                // What is Encapsulation
                /* The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
               declare fields/variables as private
               provide public get and set methods, through properties, to access and update the value of a private field */


              //  Why Encapsulation?
              
               /* Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
               Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
               Flexible: the programmer can change one part of the code without affecting other parts
               Increased security of data */

              // Encapsulation - Properties

            /*  Player obj = new Player();
              obj.Name = "Chinmay";
              Console.WriteLine(obj.Name); */

              // Auto Properties
              Player obj = new Player();
              obj.Name = "Chinmay";
              Console.WriteLine(obj.Name);
        }
           
    }
}
