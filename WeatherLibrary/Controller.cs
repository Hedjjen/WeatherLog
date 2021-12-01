using Newtonsoft.Json;
using System.Net;

namespace WeatherLibrary
{
    public class Controller
    {
        public static string ShowWeather(string city)
        {

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&lang=ru&appid=c4281ea7dcf9a3c0cd5cf9a247338761";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return "некорректное название города";
                throw;
            }

            string responseString;

            using (StreamReader stream = new StreamReader(response.GetResponseStream())) //TODO: исправить ошибки
            {
                responseString = stream.ReadToEnd();
            }

            WeatherCurrent weatherCurrent = JsonConvert.DeserializeObject<WeatherCurrent>(responseString);

            return $"В городе {weatherCurrent.Name}" +
                $"\nТемпература воздуха: {weatherCurrent.Main.Temp}" +
                $"\nМаксимальная температура воздуха: {weatherCurrent.Main.Temp_max}" +
                $"\nМинимальная температура воздуха: {weatherCurrent.Main.Temp_min}" +
                $"\nТемпература воздуха ощущается как: {weatherCurrent.Main.Feels_like}" +
                $"\nДавление: {weatherCurrent.Main.Pressure} мм. ртутного столба" +
                $"\nОтносительная влажность: {weatherCurrent.Main.Humidity}%" +
                $"\nСкорость ветра: {weatherCurrent.Wind.Speed} м/с";

        }
    }
}
