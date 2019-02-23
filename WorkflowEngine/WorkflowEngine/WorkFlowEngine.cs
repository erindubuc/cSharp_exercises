namespace WorkflowEngine
{


    partial class Program
    {
        // The workflow engine class should have one method called Run() that takes a workflow, 
        // and then iterates over each activity in the workflow and runs it.
        public class WorkFlowEngine
        {
            public void Run(IWorkflow workflow)
            {
                foreach (IActivity activity in workflow.GetActivities())
                    activity.Execute();
            }
            
        }
    }
}
