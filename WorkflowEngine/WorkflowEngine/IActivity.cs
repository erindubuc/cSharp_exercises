namespace WorkflowEngine
{
    partial class Program
    {
        //  We want our workflows to be extensible, so we can create new activities without 
        //    impacting the existing activities.
        //Each activity should have a method called Execute(). The workflow engine does not
        //care about the concrete implementation of activities.All it cares about is that
        //these activities have a common interface: they provide a method called Execute(). 
        
        public interface IActivity
        {
            void Execute();
        }
    }
}
