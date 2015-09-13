using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace battlenet_api.Utilities
{
    public class WebRequestUtility : IDisposable
    {
        private HttpClientHandler httpHandler;
        private HttpClient httpClient;
        private JsonSerializerSettings jsonSettings;

        public WebRequestUtility()
        {
            httpHandler = new HttpClientHandler();

            if (httpHandler.SupportsAutomaticDecompression)
            {
                httpHandler.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
            }

            httpClient = new HttpClient(httpHandler);

            jsonSettings = new JsonSerializerSettings();
            jsonSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public async Task<T> GetDataAsync<T>(string url)
        {
            string json = await GetRequestAsync(url);

            return DeserializeJson<T>(json);
        }

        private T DeserializeJson<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json, jsonSettings);
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
                using (HttpResponseMessage response = await httpClient.GetAsync(url))
                {
                    string json = await response.Content.ReadAsStringAsync();

                    return json;
                }
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            if (httpClient != null)
            {
                httpClient.Dispose();
            }

            if (httpHandler != null)
            {
                httpClient.Dispose();
            }
        }
    }
}
