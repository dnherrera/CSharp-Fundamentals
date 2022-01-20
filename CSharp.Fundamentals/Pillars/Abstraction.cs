using System;

namespace CSharp.Fundamentals.Pillars
{
    /// <summary>
    ///  expose what is necessary and compulsory and we need to hide the unnecessary things from the outside world
    /// </summary>
    class Abstraction
    {
        public static void Main()
        {
            //Creating an instance of Car
            Car CarObject = new Car();
            //Accessing the Public Properties and methods
            string CarName = CarObject.CarName;
            string CarColur = CarObject.CarColur;
            CarObject.Brakes();
            CarObject.Gear();
            CarObject.Steering();
            //Try to access the private variables and methods
            //Compiler Error, 'Car._CarName' is inaccessible due to its protection level
            // --> CarObject._CarName;
            //Compiler Error, 'Car.CarEngine' is inaccessible due to its protection level
            // --> CarObject.CarEngine();
        }

        public class Car
        {
            private string _CarName = "Honda City";
            private string _CarColur = "Black";
            public string CarName
            {
                set
                {
                    _CarName = value;
                }
                get
                {
                    return _CarName;
                }
            }
            public string CarColur
            {
                set
                {
                    _CarColur = value;
                }
                get
                {
                    return _CarColur;
                }
            }
            public void Steering()
            {
                Console.WriteLine("Streering of the Car");
            }

            public void Brakes()
            {
                Console.WriteLine("Brakes of the Car");
            }
            public void Gear()
            {
                Console.WriteLine("Gear of the Car");
            }

            /// <summary>
            /// Hide from outside of the class
            /// </summary>
            private void CarEngine()
            {
                Console.WriteLine("Engine of the Car");
            }

            /// <summary>
            ///  Hide from outside of the class
            /// </summary>
            private void DiesalEngine()
            {
                Console.WriteLine("DiesalEngine of the Car");
            }

            /// <summary>
            ///  Hide from outside of the class
            /// </summary>
            private void Silencer()
            {
                Console.WriteLine("Silencer of the Car");
            }
        }
    }
}
