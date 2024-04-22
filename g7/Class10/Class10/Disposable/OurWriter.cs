using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    public class OurWriter : IDisposable
    {
        private string path;
        private StreamWriter _sw;
        private bool disposedValue = false;

        public OurWriter(string filePath)
        {
            path = filePath;
            _sw = new StreamWriter(path, true);
        }

        public void Write(string text)
        {
            if (text == "break")
                throw new Exception
                    ("Something broke unexpectedly");
            _sw.WriteLine(text);
        }
        // We implement private method that will
        // remeber when class is disposed
        // If the same class tries disposing again
        //the Dispose() method will not be called again
        private void _dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
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
