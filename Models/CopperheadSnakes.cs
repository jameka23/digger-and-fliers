using System;
namespace diggersAndFliers{
    public class CopperheadSnakes : IWalking{
        public void Walk(){
            Console.WriteLine("As a snake, I move on land.");
        }

        public void Run(){
            Console.WriteLine("Being a snake is hard, but I move extremely fast if need be.");
        }
    }
}