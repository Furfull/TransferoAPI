using Newtonsoft.Json;

namespace TransferoAPI.Models
{
    public class Clientes
    {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }

    }
}
