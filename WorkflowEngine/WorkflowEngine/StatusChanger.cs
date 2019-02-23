using System;

namespace WorkflowEngine
{
    partial class Program
    {
        public class StatusChanger : IActivity
        {
            public void Execute()
            {
                Console.WriteLine(@"Activity: Changing status of video to 'processing'");
            }
        }
    }
}
