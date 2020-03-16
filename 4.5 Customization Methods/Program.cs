using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _4._5_Customization_Methods
{
    [Serializable]
    class Artist
    {
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            Console.WriteLine("Called before artist is serialized");
        }

        [OnSerialized()]
        internal void OnSerializedMethod(StreamingContext context)
        {
            Console.WriteLine("Called after artist is serialized");
        }

        [OnDeserializing()]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            Console.WriteLine("Called before artist is serialized");
        }

        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            Console.WriteLine("Called after artist is deserialized");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
