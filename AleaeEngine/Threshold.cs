namespace AleaeEngine;

public enum ThresholdTypes
{
    LT,
    LE,
    GE,
    GT
}

public class Threshold
{
    public ulong type;
    public ulong threshold;
    public ulong code;
}