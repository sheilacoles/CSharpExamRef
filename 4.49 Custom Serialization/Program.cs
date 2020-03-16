using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _4._49_Custom_Serialization
{
    [Serializable]
    class Artist : ISerializable
    {
        public string Name { get; set; }
        protected Artist(SerializationInfo info, StreamingContext context)
        { Name = info.GetString("name"); }
        protected Artist()
        {

        }
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
