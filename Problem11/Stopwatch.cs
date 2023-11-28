public class Stopwatch
{
    private  DateTime _start;
    private DateTime _end;
    private bool _isRunning;

    public void Start()
    {
        if(_isRunning)
            throw new InvalidOperationException("Stopwatch is already running");

        _isRunning = true;
        _start = DateTime.Now;
    }
    public void Stop()
    {
        if(!_isRunning)
            throw new InvalidOperationException("Stopwatch is already running");
        
        _isRunning = false;
        _end = DateTime.Now.AddSeconds(2);
    }

    public TimeSpan Duration()
    {
        return _end - _start;
    }

}
