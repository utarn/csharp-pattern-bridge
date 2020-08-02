namespace pattern_bridge
{
    public class SamsungBrand : Device
    {
        public void SetChannel(int number)
        {
           System.Console.WriteLine("Samsung : Set channel to " + number);
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Samsung : Turn off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Samsung : Turn on");
        }
    }
}