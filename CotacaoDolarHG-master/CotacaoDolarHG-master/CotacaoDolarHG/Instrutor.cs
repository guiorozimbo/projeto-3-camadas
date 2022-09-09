using Newtonsoft.Json;

namespace ApiInstrutorSenai
{
    public class Instrutor
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "employeeregistration")]
        public string Employeeregistration { get; set; }

        [JsonProperty(PropertyName = "cpf")]
        public string Cpf { get; set; }

        [JsonProperty(PropertyName = "birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty(PropertyName = "courses")]
        public string Courses { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string Created_at { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}