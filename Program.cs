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
            Diggers diggersContainer = new Diggers();
            diggersContainer.diggers.Add(ant);
            diggersContainer.diggers.Add(earthworm);

            Swimmers swimmersContainer = new Swimmers();
            swimmersContainer.swimmers.Add(betta);
            swimmersContainer.swimmers.Add(terrapin);

            Fliers fliersContainer = new Fliers();
            fliersContainer.fliers.Add(parakeet);
            fliersContainer.fliers.Add(finch);
            
            AboveGround aboveGroundContainer = new AboveGround();
            aboveGroundContainer.grounders.Add(coppersnake);
            aboveGroundContainer.grounders.Add(gerbil);
            aboveGroundContainer.grounders.Add(mice);
            aboveGroundContainer.grounders.Add(timbersnake);
            
        }
    }
}
