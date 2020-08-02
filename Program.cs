using System;

namespace pattern_bridge
{
    class Program
    {
        static void Main(string[] args)
        {
           var remoteControl = new AdvanceRemoteControl(new SonyBrand());
           remoteControl.TurnOn();
           remoteControl.SetChannel(5);
           
        }
    }
}
