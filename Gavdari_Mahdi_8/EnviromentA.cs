using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EnviromentA
{


    public Healthparameterss<int> Oxygen = new Healthparameterss<int>()
    {
        Name = "Oxygen",
        Current = 35,
        Standard = 32
    };
    public Healthparameterss<int> TDS = new Healthparameterss<int>()
    {
        Name = "TDS",
        Current = 1380,
        Standard = 1402
    };

    public Healthparameterss<int> Db = new Healthparameterss<int>()
    {
        Name = "Db",
        Current = 60,
        Standard = 65
    };
    public Healthparameterss<int> Density = new Healthparameterss<int>()
    {
        Name = "Density",
        Current = 14,
        Standard = 15
    };
    public Healthparameterss<int> Temp = new Healthparameterss<int>()
    {
        //bar hasb c0
        Name = "Temp",
        Current = 28,
        Standard = 25
    };
    public Healthparameterss<int> AQI = new Healthparameterss<int>()
    {
        Name = "Air Quality Index",
        Current = 80,
        Standard = 60
    };
    public DateOnly date = new DateOnly();
}