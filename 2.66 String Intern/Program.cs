using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._66_String_Intern
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "hello";

            string h1 = "he";
            string h2 = "llo";
            string s3 = h1 + h2;
            s3 = string.Intern(s3);
        }
    }
}
