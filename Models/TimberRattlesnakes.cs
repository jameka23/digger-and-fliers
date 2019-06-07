using System;
namespace diggersAndFliers{
    public class TimberRattlesnakes : IWalking{
        public void Walk(){
            Console.WriteLine("I walk on land, but since I am a snake, I move on land.");
        }
        public void Run(){
            Console.WriteLine("Although I am a snake that moves on land, I can be very quick. ");
        }
    }
}