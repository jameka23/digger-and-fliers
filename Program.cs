using System;
using System.Collections.Generic;

namespace diggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an instance(OBJECT) of each animal class
            Ants ant = new Ants();
            BettaFish betta = new BettaFish{
                MaximumDepth = 50
            };
            CopperheadSnakes coppersnake = new CopperheadSnakes();
            Earthworms earthworm = new Earthworms();
            Finches finch = new Finches();
            Gerbils gerbil = new Gerbils();
            Mice mice = new Mice();
            Parakeets parakeet = new Parakeets();
            Terrapins terrapin = new Terrapins{
                MaximumDepth = 50
            };

            TimberRattlesnakes timbersnake = new TimberRattlesnakes();

            // add the animals to thier corresponding container
            // Diggers dig = new Diggers();
            // Diggers diggingMammals = new Diggers();
            List<Diggers> diggers = new List<Diggers>();
            diggers.Add(ant);
        }
    }
}
