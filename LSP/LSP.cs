using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class LSP
    {
        public interface IFlyingBird
        {
            void Fly();
        }

        public abstract class Bird
        {
             public abstract void Eat();
             public abstract void Walk();
        }

        public class Crow : Bird, IFlyingBird
        {
            public override void Eat()
            {
                Console.WriteLine("Crow can eat");
            }

            public override void Walk()
            {
                Console.WriteLine("Crow can Walk");
            }

            public void Fly()
            {
                Console.WriteLine("Hurray, I am a Crow and can Fly");
            }
        }


        public class Eagle : Bird, IFlyingBird
        {
            public override void Eat()
            {
                Console.WriteLine("Crow can eat");
            }

            public override void Walk()
            {
                Console.WriteLine("Crow can Walk");
            }

            public void Fly()
            {
                Console.WriteLine("Hurray, I am an Eagle and can Fly");
            }
        }

        public class Ostrich : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("Ostrich can eat");
            }

            public override void Walk()
            {
                Console.WriteLine("Ostrich can Walk");
            }
        }

        public class Penguin : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("Penguin can eat");
            }

            public override void Walk()
            {
                Console.WriteLine("Penguin can Walk");
            }
        }

        //private static void Main(string[] args)
        //{
        //    List<Bird> Birds = new List<Bird>();
        //    Crow crow = new Crow();
        //    Ostrich ostrich = new Ostrich();
        //    Eagle eagle = new Eagle();
        //    Penguin penguin = new Penguin();

        //    Birds.Add(crow);
        //    Birds.Add(ostrich);
        //    Birds.Add(eagle);
        //    Birds.Add(penguin);

        //    foreach (var bird in Birds)
        //    {
        //        bird.Eat();
        //        bird.Walk();

        //        if (bird is IFlyingBird)
        //        {
        //            IFlyingBird flyingBird = (IFlyingBird)bird;
        //            flyingBird.Fly();
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
