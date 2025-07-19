using System;
using System.Collections.Generic;
using LSP;
using LSPViolation;


namespace LSPViolation
{
    public class LSPViolation
    {
        public abstract class Bird
        {
            public abstract void Fly();
            public abstract void Eat();
        }

        /// <summary>
        /// Crow
        /// </summary>
        public class Crow : Bird
        {
            public override void Fly()
            {
                Console.WriteLine("Crow flying");
            }

            public override void Eat()
            {

            }

        }

        /// <summary>
        /// Ostrich
        /// </summary>
        public class Ostrich : Bird
        {
            public override void Fly()
            {
                throw new InvalidOperationException("Come On, I cannot fly");
            }

            public override void Eat()
            {

            }
        }

        private static void Main(string[] args)
        {
            List<Bird> Birds = new List<Bird>();
            Crow crow = new Crow();
            Ostrich ostrich = new Ostrich();
            Birds.Add(crow);
            Birds.Add(ostrich);

            foreach (var bird in Birds)
            {
                if (bird is Crow)
                {
                    bird.Fly();
                    bird.Eat();
                }
                else if (bird is Ostrich)
                {
                    bird.Eat();
                }
            }
        }
    }

}

