namespace Remote
{
    public class CeilingFanOffCmd : Command
    {
        CeilingFan fan;
        CeilingFan.Level prev_level;
        public CeilingFanOffCmd(CeilingFan fan) 
        {
            this.fan = fan;
        }
        public void execute()
        {
            prev_level = fan.getSpeed();
            fan.off();
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