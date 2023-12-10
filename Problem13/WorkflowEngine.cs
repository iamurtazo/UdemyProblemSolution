public class WorkflowEngine
{  
    public void Run(List<IWorkFlow> workflow)
    {
        foreach(var activity in workflow)
        {
            activity.Execute();
            Console.WriteLine();
        }
    }
    
}
