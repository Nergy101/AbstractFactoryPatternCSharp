using AbstractFactoryPattern.Models;
using Newtonsoft.Json;
using System.IO;

namespace AbstractFactoryPattern
{
    // somewhat resambles the startup of most applications
    public class Startup
    {
        public Configuration Configuration { get; set; }

        public Startup()
        {
            Configuration = LoadJson();
        }

        private Configuration LoadJson()
        {
            using var reader = new StreamReader("appsettings.json");
            string json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<Configuration>(json);
        }
    }
}
