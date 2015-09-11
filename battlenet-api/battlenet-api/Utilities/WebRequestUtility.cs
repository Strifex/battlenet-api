using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace battlenet_api.Utilities
{
    public class WebRequestUtility
    {
        public async Task<T> GetDataAsync<T>(string url)
        {
            string json = await GetRequestAsync(url);

            return DeserializeJson<T>(json);
        }

        private T DeserializeJson<T>(string json)
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;

                return JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch
            {
                return default(T);
            }
        }

        private async Task<string> GetRequestAsync(string url)
        {
            try
            {
                using (HttpClientHandler handler = new HttpClientHandler())
                {
                    if (handler.SupportsAutomaticDecompression)
                    {
                        handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
                    }

                    using (HttpClient client = new HttpClient(handler))
                    {
                        using (HttpResponseMessage response = await client.GetAsync(url))
                        {
                            string json = await response.Content.ReadAsStringAsync();

                            return json;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
