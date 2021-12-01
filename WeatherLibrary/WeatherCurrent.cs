namespace WeatherLibrary
{
    internal class WeatherCurrent
    {
        public string? Name { get; set; }

        public WeatherInfo? Main { get; set; }

        public Wind? Wind { get; set; }
    }
}