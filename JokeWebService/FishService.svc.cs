using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using JokeWebService.Model;

namespace JokeWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FishService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FishService.svc or FishService.svc.cs at the Solution Explorer and start debugging.
    public class FishService : IFishService
    {
        private List<Fish> Fishes = new List<Fish> { new Fish { Id = 1, Name = "Jam" },
            new Fish { Id = 2, Name = "Butter" } };


        public IEnumerable<Fish> GetFishes()
        {
            return Fishes;
        }

        public void SaveFish(Fish fish)
        {
            Fishes.Add(fish);
        }
    }
}
