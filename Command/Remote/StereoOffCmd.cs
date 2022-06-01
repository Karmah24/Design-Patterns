namespace Remote
{
    public class StereoOffCmd : Command
    {
        Stereo stereo;
        public StereoOffCmd(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.off();
        }
        public void undo()
        {
            stereo.on();
        }
    }
}