using System;

namespace WorkflowEngine
{
    partial class Program
    {
        public class CallService : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Activity: Calling web service to encode video");
            }
        }
    }
}
