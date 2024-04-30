<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
=======
﻿namespace Disposable
>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
{
    public class OurWriter : IDisposable
    {
        private string path;
        private StreamWriter _sw;
        private bool disposedValue = false;
<<<<<<< HEAD

=======
        
>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
        public OurWriter(string filePath)
        {
            path = filePath;
            _sw = new StreamWriter(path, true);
        }

        public void Write(string text)
        {
<<<<<<< HEAD
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
=======
            if (text == "break") throw new Exception("Something brok unexpectedly...");
            
            _sw.WriteLine(text);
        }

        // We implement this private methot that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if(!disposedValue)
            {
                if(disposing)
                {
                    _sw.Dispose();
                }

>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
                path = "";
                disposedValue = true;
            }
        }
<<<<<<< HEAD
=======

>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
        public void Dispose()
        {
            _dispose(true);
        }
    }
}
