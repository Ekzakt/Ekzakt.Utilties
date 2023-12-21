using System.Diagnostics;

// See here: https://stackoverflow.com/questions/29306575/encapsulate-a-task-to-record-duration-of-an-async-function

namespace Ekzakt.TaskAuditor;

public class TaskAuditor<T>
{
    private Func<Task<T>> _func;
    private TaskAuditorOptions _options = new();
    private Stopwatch _stopwatch = new();


    public TaskAuditor(Action<TaskAuditorOptions>? options = null)
    {
        if (options is not null)
        {
            options(_options!);
        }
    }

    public TaskAuditor(Func<Task<T>> func, Action<TaskAuditorOptions>? options = null)
    {
        if (options is not null)
        {
            options(_options!);
        }

        _func = func;
    }


    public async Task<T> ExecuteAsync(Func<Task<T>> func)
    {
        _stopwatch = new();
        _stopwatch.Start();

        try
        {
            return await func();
        }
        finally
        {
            _stopwatch.Stop();
        }
    }


    public async Task<T> ExecuteTaskAsync()
    {
        _stopwatch = new();
        _stopwatch.Start();

        try
        {

            return await _func();
        }
        finally
        {
            _stopwatch.Stop();
        }
    }


    public TimeSpan? Duration()
    {
        TimeSpan? result = null;

        if (!_stopwatch.IsRunning)
        {
            result = _stopwatch.Elapsed;
        }
        return result;
    }


    public string? ElapsedTime()
    {
        TimeSpan? timeSpan = Duration();

        if (timeSpan is not null)
        {
            var elapsedTime = string.Format(
                "{0:00}:" +
                "{1:00}:" +
                "{2:00}." +
                "{3:000}",
                timeSpan?.Hours,
                timeSpan?.Minutes,
                timeSpan?.Seconds,
                timeSpan?.Milliseconds);

            return elapsedTime.ToString();
        }

        return null;
    }
}
