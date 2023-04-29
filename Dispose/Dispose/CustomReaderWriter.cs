using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    public class MyWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposed;

        public MyWriter(string path)
        {
            _path = path;
            _sw = new StreamWriter(_path, true);
        }

        public void Write(string text)
        {
            if (text == "break")
                throw new Exception("Something broke");
            _sw.WriteLine(text);
        }

        private void _dispose(bool disposing)
        {
            if (!_disposed)
            {
                _sw.Dispose();
            }
            _path = string.Empty;
            _disposed = true;
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }

    public class MyReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool _disposed;

        public MyReader(string path)
        {
            _path = path;
            _sr = new StreamReader(path);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        private void _dispose(bool disposing)
        {
            if (!_disposed)
            {
                _sr.Dispose();
            }
            _path = string.Empty;
            _disposed = true;
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }
}
