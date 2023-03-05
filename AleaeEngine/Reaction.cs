namespace AleaeEngine;

public class Reaction
{
    public Dictionary<ulong, ulong> reactants;
    public Dictionary<ulong, long> delta;
    public List<ulong> dependants;
    public double rate;
}