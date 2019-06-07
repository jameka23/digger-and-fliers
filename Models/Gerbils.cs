using System;
namespace diggersAndFliers{
    public class Gerbils: IWalking{
        public void Walk(){
            Console.WriteLine("I like to walk around my wheel. ");
        }
        public void Run(){
            Console.WriteLine("In my spare time, I will run around my tank.");
        }
    }
}