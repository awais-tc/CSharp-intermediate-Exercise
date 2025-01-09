using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running");
            Console.WriteLine("Stopwatch started");
            Console.WriteLine("Press 'stop' to stop the stopwatch");
            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running");
            Console.WriteLine("Stopwatch stopped");
            _endTime = DateTime.Now;
            _running = false;
        }
        public TimeSpan Duration
        {
            get
            {
                return _endTime - _startTime;
            }
        }
    }
}
