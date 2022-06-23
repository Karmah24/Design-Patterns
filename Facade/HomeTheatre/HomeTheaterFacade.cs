using System;

namespace HomeTheater
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier amplifier;
        private readonly Tuner tuner;
        private readonly DvdPlayer dvdPlayer;
        private readonly CdPlayer cdPlayer;
        private readonly Projector projector;
        private readonly Screen screen;
        private readonly TheaterLights theaterLights;
        private readonly PopcornPopper popcornPopper;

        public HomeTheaterFacade(Amplifier amplifier,
                                 Tuner tuner,
                                 DvdPlayer dvdPlayer,
                                 CdPlayer cdPlayer,
                                 Projector projector,
                                 Screen screen,
                                 TheaterLights theaterLights,
                                 PopcornPopper popcornPopper)
        {
            this.amplifier = amplifier;
            this.tuner = tuner;
            this.dvdPlayer = dvdPlayer;
            this.cdPlayer = cdPlayer;
            this.projector = projector;
            this.screen = screen;
            this.theaterLights = theaterLights;
            this.popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popcornPopper.On();
            popcornPopper.Pop();
            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amplifier.On();
            amplifier.SetDvd(dvdPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);
            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popcornPopper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
        }

        public void ListenToCd(string cdTitle)
        {
            Console.WriteLine("Get ready for an audiopile experience...");
            theaterLights.On();
            amplifier.On();
            amplifier.SetVolume(5);
            amplifier.SetCd(cdPlayer);
            amplifier.SetStereoSound();
            cdPlayer.On();
            cdPlayer.Play(cdTitle);
        }

        public void EndCd()
        {
            Console.WriteLine("Shutting down CD...");
            amplifier.Off();
            amplifier.SetCd(cdPlayer);
            cdPlayer.Eject();
            cdPlayer.Off();
        }

        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            tuner.On();
            tuner.SetFrequency(frequency);
            amplifier.On();
            amplifier.SetVolume(5);
            amplifier.SetTuner(tuner);
        }

        public void EndRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            tuner.Off();
            amplifier.Off();
        }
    }
}