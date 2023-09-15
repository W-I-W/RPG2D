

using System;

public class Range
{

    public Range(int start = 1, int min = 0, int max = 100)
    {
        this.start = start;
        current = start;
        this.min = min;
        this.max = max;
    }

    private int m_Current;

    public int current
    {
        get => m_Current;
        set
        {
            m_Current = (value > min) ?
                (value < max) ? value : max
                : min;
        }
    }

    public int max { get; private set; }

    public int min { get; private set; }

    public int start { get; private set; }
}
