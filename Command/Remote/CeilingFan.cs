namespace Remote
{
    public class CeilingFan 
    {
        String location = "";
        Level level = Level.off;
        public enum Level
        {
            off, low, medium, high
        }
    
        public CeilingFan(String location) 
        {
            this.location = location;
        }
        public void high() 
        {
            level = Level.high;
            System.Console.WriteLine(location + " ceiling fan is on high");
    
        } 
        public void medium() 
        {
            level = Level.medium;
            System.Console.WriteLine(location + " ceiling fan is on medium");
        }
        public void low() 
        {
            level = Level.low;
            System.Console.WriteLine(location + " ceiling fan is on low");
        }
        public void off() 
        {
            level = Level.off;
            System.Console.WriteLine(location + " ceiling fan is off");
        }
        public Level getSpeed() 
        {
            return level;
        }
    }
}