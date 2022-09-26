namespace WeatherForecast
{
    public class WeatherForecastGenerator
    {

        DateTime date = DateTime.Now.Date;
        readonly Random random = new();

        double temperature = 20.0;
        double windForce = 40.0;
        double rainfall = 20.0;

        private void GenerateNewValue(ref double value, double range, double min, double max)
        {
            double newValue = value + (random.NextDouble() - 0.5) * range;
            newValue = Math.Max(min, newValue);
            newValue = Math.Min(max, newValue);
            value = newValue;
        }

        public Forecast GenerateForecast()
        {
            date = date.AddDays(1);


            GenerateNewValue(value: ref temperature, range: 10.0, min: -20.0, max: 45.0);


            GenerateNewValue(value: ref windForce, range: 10.0, min: 0.0, max: 150.0);


            GenerateNewValue(value: ref rainfall, range: 10.0, min: 0.0, max: 100.0);


            return new Forecast(date, temperature, windForce, rainfall);
        }

    }
}
