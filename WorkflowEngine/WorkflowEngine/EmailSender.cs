using System;

namespace WorkflowEngine
{
    partial class Program
    {
        public class EmailSender : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Activity: Email being sent to video owner");
            }
        }
    }
}
