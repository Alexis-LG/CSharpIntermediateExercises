using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Exercise
{
    class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;
        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _startTime = DateTime.Now;
            _isRunning = true;
        }
        public void Stop()
        {
            _isRunning = false;
            _stopTime = DateTime.Now;
            
        }

        public TimeSpan GetInterval()
        {
            var interval = _stopTime - _startTime;
            return (_stopTime - _startTime);
            
        }



    }
}
