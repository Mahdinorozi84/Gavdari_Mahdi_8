﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public DateOnly BirthDate { get; init; }
    static readonly int Maxlife = 25;
    static int GetMaxlife() => Maxlife;
    public float Weight;
    public string Gender;
    public string Name;
    public int Age;

    public int Life()
    {
        int Life = 0;
        return Life;
    }
    public double StressFactor()
    {
        double StressFactor = 0;
        return StressFactor;
    }

    public double KillPriority()
    {
        double KillPriority = 0;
        return KillPriority;
    }
    public int ValuPerday()
    {
        int ValuPerday = 0;
        return ValuPerday;
    }
    public int CostPerday()
    {
        int CostPerday = 0;
        return CostPerday;
    }
    public int TimeToDie()
    {
        int TimeToDie = 0;
        return TimeToDie;
    }

}
