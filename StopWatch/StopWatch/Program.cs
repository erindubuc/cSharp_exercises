using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch
{
    /* 
    Design a class called Stopwatch. The job of this class is to simulate a stopwatch. 
    It should provide two methods: Start and Stop. We call the start method first, and 
    the stop method next. Then we ask the stopwatch about the duration between start and stop. 
    Duration should be a value in TimeSpan. Display the duration on the console.
    We should also be able to use a stopwatch multiple times. So we may start and stop it and 
    then start and stop it again. Make sure the duration value each time is calculated properly.
    We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). 
    So the class should throw an InvalidOperationException if its started twice. 
    Educational tip: The aim of this exercise is to make you understand that a class should be always in a valid 
    state. We use encapsulation and information hiding to achieve that. The class should not reveal its 
    implementation detail. It only reveals a little bit, like a blackbox. From the outside, you should not be 
    able to misuse a class because you shouldn’t be able to see the implementation detail.
    */
    
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.StartRunning();
                Thread.Sleep(1000);
                stopwatch.StopRunning();

                Console.WriteLine("Duration: " + stopwatch.GetDuration());
                Console.WriteLine("Press ENTER if you'd like to run the stop watch for a second time.");
                Console.ReadLine();
            }
        }

        public class StopWatch
        {
            private DateTime _start;
            private DateTime _stop;
            private bool _isRunning;

            public void StartRunning()
            {
                if (_isRunning)
                    throw new InvalidOperationException("The stopwatch is currently running.");

                _start = DateTime.Now;
                _isRunning = true;
            }

            public void StopRunning()
            {
                if (!_isRunning)
                    throw new InvalidOperationException("The stopwatch is not currently running.");

                _stop = DateTime.Now;
                _isRunning = false;
            }

            public TimeSpan GetDuration()
            {
                return _stop - _start;
            }
        }
    }
}
