using System.Collections.Generic;

namespace WorkflowEngine
{
    partial class Program
    {
        // A workflow is a series of steps or activities. 
    public class Workflow : IWorkflow
        {
            private readonly List<IActivity> _activities;

            public Workflow()
            {
                _activities = new List<IActivity>();
            }

            public void Add(IActivity activity)
            {
                _activities.Add(activity);
            }

            public void Remove(IActivity activity)
            {
                _activities.Remove(activity);
            }

            public IEnumerable<IActivity> GetActivities()
            {
                return _activities;
            }

            //public void Execute()
            //{
            //    throw new System.NotImplementedException();
            //}
        }
    }
}
