using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    #region Abstractions Example
    public class AbstractionExample
    {
        public abstract class Animal
        {
            public virtual void AnimalSound() { }
            public void Sleep()
            {
                Console.WriteLine("zzzzzz");
            }
        }
        public class Pig : Animal
        {
            public override void AnimalSound()
            {
                Console.WriteLine("The pig says: auuee");
            }
        }

        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.AnimalSound();
            myPig.Sleep();
        }
    }
    #endregion
}
