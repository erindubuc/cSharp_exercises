using System.Collections;
using System.Collections.Generic;

namespace WorkflowEngine
{
    partial class Program
    {
        public interface IWorkflow
        {
            void Add(IActivity activity);
            void Remove(IActivity activity);
            IEnumerable<IActivity> GetActivities();

        }
    }
}
