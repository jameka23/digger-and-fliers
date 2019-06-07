using System;
namespace diggersAndFliers{
    public class Ants : IDigging, IWalking{
        public void Dig(){
            Console.WriteLine("As an ant, we like to dig our homes down below.");
        }
        public void Walk(){
            Console.WriteLine("We also like to walk on land and find food for the rest.");
        }
        public void Run(){
            Console.WriteLine("Not only do we walk, we move pretty fast when we need to.c");
        }
    }
}