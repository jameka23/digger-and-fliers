using System;
namespace diggersAndFliers{
    public class BettaFish : ISwimming{
        public void Swim(){
            Console.WriteLine("I love to swim in my tank.");
        }
        public int MaximumDepth {get; set;}
    }
}