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
    public class OurReader : IDisposable
    {
        private string path;
<<<<<<< HEAD
        private StreamWriter _sr;
=======
        private StreamReader _sr;
>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
        private bool disposedValue = false;

        public OurReader(string filePath)
        {
            path = filePath;
<<<<<<< HEAD
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
=======
            _sr = new StreamReader(filePath);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        //We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }

>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
                path = "";
                disposedValue = true;
            }
        }
<<<<<<< HEAD
=======

        // We can implement this methodf alone and add the disposing here
>>>>>>> a7c7a5c716daabc4e7f559b43ff470666d87a5c7
        public void Dispose()
        {
            _dispose(true);
        }
    }
}
