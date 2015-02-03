using Newtonsoft.Json;

namespace Caminois.Class
{
    public class Question
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("anwserA")]
        public string AnwserA { get; set; }

        [JsonProperty("anwserB")]
        public string AnwserB { get; set; }

        [JsonProperty("anwserC")]
        public string AnwserC { get; set; }

        [JsonProperty("anwserD")]
        public string AnwserD { get; set; }

        [JsonProperty("anwser")]
        public string Anwser { get; set; }
    }
}