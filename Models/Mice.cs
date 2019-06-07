using System;
namespace diggersAndFliers{
    public class Mice : IWalking{
        public void Walk(){
            Console.WriteLine("I move about by scurring across land.");
        }

        public void Run(){
            Console.WriteLine("I can run fast if I am being chased by a cat. ");
        }
    }
}