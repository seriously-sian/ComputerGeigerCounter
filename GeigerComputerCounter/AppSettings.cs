using Newtonsoft.Json;

namespace ComputerGeigerCounter
{
    public class AppSettings
    {
        public static string GreenToRed => "green-red";
        public static string BlueToRed => "blue-red";
        public static string DarkTheme => "dark";
        public static string LightTheme => "light";

        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("colour-fade")]
        public string ColourFade { get; set; }

        public static AppSettings DefaultSettings()
        {
            return new AppSettings
            {
                ColourFade = GreenToRed,
                Theme = LightTheme
            };
        }
    }
}