using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
          // Inheritance
          /* In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:
          Derived Class (child) - the class that inherits from another class
          Base Class (parent) - the class being inherited from
          To inherit from a class, use the : symbol. */

        /*  Router myRouter = new Router();

          myRouter.speed();

        Console.WriteLine(myRouter.provider + " " + myRouter.routerName); */

        /* Polymorphism - Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
         Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways. */

        /* Car myCar = new Car();
         Car mustang = new Mustang();
         Car swift = new Swift();
         Car bugati = new Bugati();

         myCar.carSound();
         mustang.carSound();
         swift.carSound();
         bugati.carSound(); */

         /* Abstraction - Data abstraction is the process of hiding certain details and showing only essential information to the user.
         Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

         The abstract keyword is used for classes and methods:

         Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

         Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from). */

        /* Joister myProvider = new Joister();
         myProvider.internetSpeed(); // abstract method
         myProvider.provider(); // regular method */

          /* Why And When To Use Abstract Classes and Methods?
            To achieve security - hide certain details and only show the important details of an object.
 
            Note: Abstraction can also be achieved with Interfaces, which you will learn more about in the next chapter. */

            /* Interfaces -
               Another way to achieve abstraction in C#, is with interfaces.

               An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies) */
               
              /* SyncMaster myMonitor = new SyncMaster();
               myMonitor.monitorResolution(); */

              /* Demo mydemo = new Demo();
               mydemo.fMethod();
               mydemo.sMethod(); */
        }
    }
}
