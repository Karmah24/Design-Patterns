namespace WeatherStation
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float maxTemp = float.MinValue, minTemp = float.MaxValue, sumTemp = 0.0f, avgTemp = 0.0f;
        private int numReadings = 0;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update()
        {
            float currTemp = weatherData.getTemperature();
            sumTemp += currTemp;
            numReadings++;
            maxTemp = Math.Max(maxTemp, currTemp);
            minTemp = Math.Min(minTemp, currTemp);
            avgTemp = sumTemp / numReadings;
            display();
        }
        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + avgTemp + "/" + maxTemp + "/" + minTemp);
        }
    }
}