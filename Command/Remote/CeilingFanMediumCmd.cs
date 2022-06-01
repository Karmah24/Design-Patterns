namespace Remote
{
    public class CeilingFanMediumCmd : Command
    {
        CeilingFan fan;
        CeilingFan.Level prev_level;
        public CeilingFanMediumCmd(CeilingFan fan) 
        {
            this.fan = fan;
        }
        public void execute()
        {
            prev_level = fan.getSpeed();
            fan.medium();
        }
        public void undo()
        {
            if (prev_level == CeilingFan.Level.off) fan.off();
            if (prev_level == CeilingFan.Level.low) fan.low();
            if (prev_level == CeilingFan.Level.medium) fan.medium();
            if (prev_level == CeilingFan.Level.high) fan.high();
        }
    }
}