using System.Security.Cryptography;

public class Program
{
    static void Main(string[] args)
    {
        var activities = new List<IWorkFlow>
        {
            new Triangle(),
            new UntilTen()

        };
        
        var workflowEngine = new WorkflowEngine();

        workflowEngine.Run(activities);
    



    }
}
