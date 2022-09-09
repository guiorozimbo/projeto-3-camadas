using Newtonsoft.Json;

namespace ApiInstrutorSenai
{
    public class Instructors
    {
        public Instructors()
        {
            this.Instrutor = new Instrutor();
        }

        [JsonProperty(PropertyName = "instructors")]
        public Instrutor Instrutor { get; private set; }
    }
}