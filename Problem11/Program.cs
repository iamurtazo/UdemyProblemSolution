class Program
{
    static void Main(string[] args)
    {
        
    }
    static void UseStopwatch()
    {
        var stopwatch = new Stopwatch();
        for(int i = 0; i < 3; i++)
        {
            stopwatch.Start();
            
            Thread.Sleep(2000);
            stopwatch.Stop();

            Console.WriteLine("Duration: " + stopwatch.Duration());
            Console.WriteLine("Press Enter to run the stopwatch one more time");
            Console.ReadLine();

        }
    }

    static void UseStopwatchElapsed()
    {
        var stopwatchElapse = new StopwatchElapsed();
        for(int i = 0; i < 3; i++)
        {
            stopwatchElapse.Start();
            Thread.Sleep(2000);
            stopwatchElapse.Stop();

        }
        TimeSpan totalTime = stopwatchElapse.GetTotalTime();
        Console.WriteLine("total time: " + totalTime);
    }
}
