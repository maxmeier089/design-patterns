using WeatherForecast;


WeatherForecastGenerator generator = new();


while (true)
{
    Forecast forecast = generator.GenerateForecast();

    Console.WriteLine(forecast + "\n");

    Thread.Sleep(500);
}

