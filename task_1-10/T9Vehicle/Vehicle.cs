using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehicle
{
    public string brand;
    public string model;
    public int speed;
    public int tyres;

    public string ShowInfo()
    {
        return "Manufacturer: " + brand + " Model: " + model;
    }
    public override string ToString()
    {
        return ShowInfo() + " Speed: " + speed + " Tyres: " + tyres;
    }
}
