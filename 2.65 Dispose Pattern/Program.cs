using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._65_Dispose_Pattern
{
    class ResourceHolder : IDisposable
    {
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                //free any managed objects here
            }

            //free unmanaged objects here
        }

        ~ResourceHolder()
        {
            //Dispose only of unmanaged objects
            Dispose(false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ResourceHolder r = new ResourceHolder();
            r.Dispose();
        }
    }
}
