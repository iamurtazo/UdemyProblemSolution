public class StopwatchElapsed
{
    private DateTime _startTime;
    private TimeSpan _totalTime;
    private bool _isRunning;

    public StopwatchElapsed()
    {
        _startTime = DateTime.MinValue;
        _totalTime = TimeSpan.Zero;
        _isRunning = false;
    }

    public void Start()
    {
        if (_isRunning)
        {
            throw new InvalidOperationException("Stopwatch is already running.");
        }

        _startTime = DateTime.Now;
        _isRunning = true;
        Console.WriteLine("Stopwatch started at: " + _startTime);
    }

    public void Stop()
    {
        if (!_isRunning)
        {
            throw new InvalidOperationException("Stopwatch is not running.");
        }

        TimeSpan elapsed = DateTime.Now - _startTime;
        _totalTime += elapsed;
        _isRunning = false;
        Console.WriteLine("Stopwatch stopped. Elapsed time: " + elapsed);
    }

    public TimeSpan GetTotalTime()
    {
        return _totalTime;
    }
}
