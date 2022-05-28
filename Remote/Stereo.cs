namespace Remote
{
        public class Stereo 
    {
        String location;
        public Stereo(String location) 
        {
            this.location = location;
        }
        public void on() 
        {
            System.Console.WriteLine(location + " stereo is on");
        }
        public void off() 
        {
            System.Console.WriteLine(location + " stereo is off");
        }
        public void setCD() 
        {
            System.Console.WriteLine(location + " stereo is set for CD input");
        }
        public void setDVD() 
        {
            System.Console.WriteLine(location + " stereo is set for DVD input");
        }
        public void setRadio() 
        {
            System.Console.WriteLine(location + " stereo is set for Radio");
        }
        public void setVolume(int volume) 
        {
            // code to set the volume
            // valid range: 1-11 (after all 11 is better than 10, right?)
            System.Console.WriteLine(location + " stereo volume set to " + volume);
        }
    }
}