namespace Remote
{
    public class Light
    {
        String location = "";

        public Light(String location) 
        {
            this.location = location;
        }
        public void on() 
        {
            System.Console.WriteLine(location + " light is on");
        }
        public void off() 
        {
            System.Console.WriteLine(location + " light is off");
        }
    }
}