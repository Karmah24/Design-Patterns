namespace Remote
{
    public class LightOnCmd : Command
    {
        Light light;
        public LightOnCmd(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
        }
        public void undo()
        {
            light.off();
        }
    }
}