namespace Remote
{
    public class LightOffCmd : Command
    {
        Light light;
        public LightOffCmd(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
        }
        public void undo()
        {
            light.on();
        }
    }
}