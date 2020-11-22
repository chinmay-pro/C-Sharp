using System;
namespace OOPs
{
    class Car // Base class (parent)
    {
        public virtual void carSound() {
            Console.WriteLine("The car makes a sound");
        }
    }

   class Mustang : Car // Derived class (child)
   {
       public override void carSound() 
       {
           Console.WriteLine("The Mustang says: mus mus");
       }
   }

   class Swift : Car
   {
       public override void carSound()
       {
       Console.WriteLine("The Swift says: swi swi");
       }
   }
   class Bugati : Car
   {
       public override void carSound()
       {
       Console.WriteLine("The Bugati says: bu bu");
       }
   }

   abstract class Internet
   {
       public abstract void internetSpeed();
       public void provider() 
       {
           Console.WriteLine("ACT");
       }
   }

   class Joister : Internet 
   {
        public override void internetSpeed()
        {
            Console.WriteLine("Joister : 40mbps");
        }
   }

   interface IMonitor
   {
       void monitorResolution();
   }

   class SyncMaster : IMonitor
   {
       public void monitorResolution()
       {
           Console.WriteLine("The Samsung SyncMaster 740n : 1280x720");
       }
   }

   interface IFirstInterface
   {
       void fMethod();
   }
   interface ISecondInterface
   {
       void sMethod();
   }

   class Demo : IFirstInterface, ISecondInterface
   {
       public void fMethod()
       {
           Console.WriteLine("I am First Interface Method");
       }
       public void sMethod()
       {
           Console.WriteLine("I am Second Interface Method");
       }
   }
}