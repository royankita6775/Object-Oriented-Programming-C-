using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WashingMachine
{
    public int temperature;
    public int timer;

    public WashingMachine(int aTemperature, int aTimer)
    {
        temperature = aTemperature;
        timer = aTimer;
    }
    public WashingMachine()
    {
        temperature = 0;
        timer = 0;
    }
}
