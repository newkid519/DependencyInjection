using System;
using System.IO;

namespace DependencyInjection
{
	interface ILogger
	{
		void WriteLog(string msg);
	}
	
    class TextLogger : ILogger, IDisposable
    {
        StreamWriter _fsLog;

        public TextLogger()
        {
            Console.WriteLine("TextLogger is created." + this.GetHashCode().ToString());
            _fsLog = new StreamWriter("Log.txt", true);
        }

        public void WriteLog(string msg)
        {
            Console.WriteLine($"Simply {msg}");
            _fsLog.Write(msg);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    Console.WriteLine("Disposing StreamWriter.");
                    _fsLog.Close();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~TextLogger()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    class AdvancedLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{msg} at {DateTime.Now}");
        }
    }
}