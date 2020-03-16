using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JokeWebService.Model
{
    [DataContract]
    public class Fish
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Id { get; set; }
    }
}