using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class sheep : IComparable
{
    public DateOnly BirthDate { get; init; }
    static readonly int Maxlife = 25;
    static int GetMaxlife() => Maxlife;
    public List<EnviromentA> enviroments;
    public static string Name;
    public List<CowParameter> cowparameters;
    int IComparable.CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}
