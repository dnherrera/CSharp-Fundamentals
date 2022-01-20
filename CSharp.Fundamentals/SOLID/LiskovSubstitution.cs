using System;

namespace CSharp.Fundamentals.SOLID
{
    /// <summary>
    /// <seealso cref="https://dotnettutorials.net/lesson/liskov-substitution-principle/"/>
    /// </summary>
    class LiskovSubstitution
    {
        class Program
        {
            static void Main(string[] args)
            {
                Fruit fruit = new Orange();
                Console.WriteLine(fruit.GetColor()); // "Orange"
                fruit = new Apple();
                Console.WriteLine(fruit.GetColor()); // "Red"

                AppleWithoutLsp apple = new OrangeWithoutLsp();
                Console.WriteLine(apple.GetColor()); // "Orange" - against LSP
            }
        }
        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            // override modifier is required to extend or modify the abstract
            // or virtual implementation of an inherited method, property, indexer, or event.
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
        /// <summary>
        /// Parent
        /// </summary>
        public class AppleWithoutLsp
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }

        /// <summary>
        /// Child Class - The child should not replaced his parent's behavior because it's against to this LSP.
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.SOLID.LiskovSubstitution.AppleWithoutLsp" />
        public class OrangeWithoutLsp : AppleWithoutLsp
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}
