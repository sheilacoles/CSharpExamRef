using JokeWebService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JokeWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFishService" in both code and config file together.
    [ServiceContract]
    public interface IFishService
    {
        [OperationContract]
        IEnumerable<Fish> GetFishes();

        [OperationContract]
        void SaveFish(Fish fish);
    }
}
