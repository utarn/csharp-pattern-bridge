namespace pattern_bridge
{
    public class AdvanceRemoteControl : RemoteControl
    {
        public AdvanceRemoteControl(Device device) : base(device)
        {
        }

        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }
}