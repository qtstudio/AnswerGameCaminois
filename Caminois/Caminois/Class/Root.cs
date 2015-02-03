using System.Collections.Generic;
using Newtonsoft.Json;

namespace Caminois.Class
{
    public class Root
    {
        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }
    }
}