namespace WeatherStation
{
    public class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature, humidity;
        private WeatherData weatherData;
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update()
        {
            temperature = weatherData.getTemperature();
            humidity = weatherData.getHumidity();
            display();
        }
        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}