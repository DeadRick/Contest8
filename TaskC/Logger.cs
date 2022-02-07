using System;
public delegate void Print(string line);


internal class Logger
{

    public void OutputLogs()
    {
    }

    public void MakeLog(Print method, string line)
    {
        method(line);
    }
}