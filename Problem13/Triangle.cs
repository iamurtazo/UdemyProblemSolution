public class Triangle : IWorkFlow
{
    public void Execute()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = i; j >= 0; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
