namespace FastFramework.Core.JsonProvders
{
    public class NetJsonProvider : IJsonProvider
    {
        public string ToJson(object source)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(source);
        }

        public T ToObject<T>(string sourceStr)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(sourceStr);
        }
    }
}
