using System;
namespace diggersAndFliers{
    public class Terrapins:ISwimming{
        public void Swim(){
            Console.WriteLine("I like to swim.");
        }
        public int MaximumDepth {get; set;}
    }
}