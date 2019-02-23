using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    // Design a workflow engine that takes a workflow object and runs it. 

    partial class Program
    {

        static void Main(string[] args)
        {
            var workflow = new Workflow();

            // add tasks to workflow
            workflow.Add(new VideoUploader());
            workflow.Add(new CallService());
            workflow.Add(new EmailSender());
            workflow.Add(new StatusChanger());

            // run objects
            var workflowEngine = new WorkFlowEngine();
            workflowEngine.Run(workflow);

            Console.ReadLine();
        }
    }
}
