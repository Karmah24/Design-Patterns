namespace Remote
{
    public class StereoOnWithCdCmd : Command
    {
        Stereo stereo;
        public StereoOnWithCdCmd(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
        public void undo()
        {
            stereo.off();
        }
    }
}