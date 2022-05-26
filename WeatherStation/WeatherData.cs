namespace WeatherStation
{
    public class WeatherData : Subject
    {
        private float temperature, humidity, pressure;
        private HashSet<Observer> observers;
        public WeatherData()
        {
            observers = new HashSet<Observer>();
        }
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }
        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }
        public float getHumidity()
        {
            return humidity;
        }
        public float getPressure()
        {
            return pressure;
        }
        public float getTemperature()
        {
            return temperature;
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
        
    }
}