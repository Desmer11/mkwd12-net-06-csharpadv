using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    public class OurReader : IDisposable
    {
        private string path;
        private StreamWriter _sr;
        private bool disposedValue = false;

        public OurReader(string filePath)
        {
            path = filePath;
            _sr = new StreamWriter(filePath);
        }
        public string Read()
        {
            return _sr.ReadToEnd();


        }
        private void _dispose(bool disposing) 
        {
            if(!disposedValue)
            {
                if(disposing)
                {
                    _sr.Dispose();
                }
                path = "";
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            _dispose(true);
        }
    }
}
