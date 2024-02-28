using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Television
{
    public int channel { get; set; }
    public int volume {get; set; }
    
    public Television (int aChannel, int aVolume)
    {
        channel = aChannel;
        volume = aVolume;
    }
    public Television()
    {
        channel = 0;
        volume = 0;
    }
}
