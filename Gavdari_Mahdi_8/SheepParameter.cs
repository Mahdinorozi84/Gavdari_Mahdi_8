using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SheepParameter
{


    public Healthparameterss<double> NumberOfMeal = new Healthparameterss<double>()
    {   //USE litr 
        Name = "NumberOfMeal",
        Current = 3,
        Standard = 4
    };
    public Healthparameterss<double> TimeToStand = new Healthparameterss<double>()
    {   //use minute
        Name = "TimeToStand",
        Current = 8,
        Standard = 11
    };

    public Healthparameterss<double> TimeToRelax = new Healthparameterss<double>()
    {   //use clock
        Name = "TimeToRelax",
        Current = 4,
        Standard = 5
    };
    public Healthparameterss<double> TimeToDeal = new Healthparameterss<double>()
    {   //use clock
        Name = "TimeToDeal",
        Current = 8,
        Standard = 10
    };
    public Healthparameterss<double> NumberOfMilkProduction = new Healthparameterss<double>()
    {   //use litr
        Name = "NumberOfMilkProduction",
        Current = 72,
        Standard = 86
    };
    public DateOnly date = new DateOnly();
    public override string ToString()
    {
        var Cowp = $"Stand Time:{TimeToStand} TimeToDeal{TimeToDeal} TimeToRelax{TimeToRelax} NumberOfMilkProduction{NumberOfMilkProduction} NumberOfMeal{NumberOfMeal} {date}  ";
        return Cowp.ToString();

    }
}