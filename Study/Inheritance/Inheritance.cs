using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Inheritance
{
    public class Inheritance
    {
       
    }

    class Tyre
    {
        protected void TyreType()
        {
            Console.WriteLine("This is Tubeless Tyre");
        }
    }

    class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter Color is Red");
            TyreType();
        }
    }

    class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car Type : Ferrari");
            TyreType();
        }
    }

}
