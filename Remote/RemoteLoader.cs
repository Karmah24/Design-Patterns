namespace Remote
{
    public class RemoteLoader
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light bedroomLight = new Light("Bedroom");
            Stereo stereo = new Stereo("Living Room");
            CeilingFan fan = new CeilingFan("Bedroom");


            LightOnCmd bedroomLightOn = new LightOnCmd(bedroomLight);
            LightOffCmd bedroomLightOff = new LightOffCmd(bedroomLight);

            StereoOnWithCdCmd stereoOnwithCd = new StereoOnWithCdCmd(stereo);
            // Command stereoOnwithCd = () => {
            //     stereo.on(); stereo.setCD(); stereo.setVolume(11);
            // }
            StereoOffCmd stereoOff = new StereoOffCmd(stereo);

            CeilingFanHighCmd fanHigh = new CeilingFanHighCmd(fan);
            CeilingFanMediumCmd fanMedium = new CeilingFanMediumCmd(fan);
            CeilingFanLowCmd fanLow = new CeilingFanLowCmd(fan);
            CeilingFanOffCmd fanOff = new CeilingFanOffCmd(fan);

            Command[] macroOnCmd = {fanHigh, stereoOnwithCd, bedroomLightOff};
            Command[] macroOffCmd = {fanLow, stereoOff, bedroomLightOn};

            MacroOnCmd macroOn = new MacroOnCmd(macroOnCmd);
            MacroOffCmd macroOff = new MacroOffCmd(macroOffCmd);

            remote.setCommand(0, bedroomLightOn, bedroomLightOff);
            remote.setCommand(1, stereoOnwithCd, stereoOff);
            remote.setCommand(2, fanHigh, fanOff);
            remote.setCommand(3, fanMedium, fanOff);
            remote.setCommand(4, fanLow, fanOff);
            remote.setCommand(5, macroOn, macroOff);

            System.Console.WriteLine(remote);

            // remote.onButtonPush(0);
            // System.Console.WriteLine(remote);
            // remote.onButtonPush(1);
            // remote.offButtonPush(1);
            // remote.offButtonPush(0);
            // remote.onButtonPush(3);
            // System.Console.WriteLine(remote);
            // remote.onButtonPush(4);
            // remote.undoButtonPush();
            remote.onButtonPush(5);
            // remote.offButtonPush(5);
            remote.undoButtonPush();
        }
    }
}