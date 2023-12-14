using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CowParameter
{
    public Healthparameterss<double> TimeToStand = new Healthparameterss<double>()
    {
        Name = "TimeToStand",
        Current = 6,
        Standard = 10
    };
    public Healthparameterss<double> NumberOfMilkProduction = new Healthparameterss<double>()
    {   //bar hasb litr
        Name = "NumberOfMilkProduction",
        Current = 200,
        Standard = 670
    };
    public Healthparameterss<double> NumberOfMeal = new Healthparameterss<double>()
    {   //bar hasb tedad vade
        Name = "NumberOfMeal",
        Current = 8,
        Standard = 10
    };

    public Healthparameterss<double> TimeToRelax = new Healthparameterss<double>()
    {   //bar hasb clock
        Name = "TimeToRelax",
        Current = 2,
        Standard = 4
    };
    public Healthparameterss<double> TimeToDeal = new Healthparameterss<double>()
    {   //bar hasb clock
        Name = "TimeToDeal",
        Current = 6,
        Standard = 9
    };
    public DateOnly date = new DateOnly();
    public override string ToString()
    {
        var tcowparameter = $"Stand Time:{TimeToStand} TimeToDeal{TimeToDeal} TimeToRelax{TimeToRelax} NumberOfMilkProduction{NumberOfMilkProduction} NumberOfMeal{NumberOfMeal} {date}  ";
        return tcowparameter.ToString();

    }
}