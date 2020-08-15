using MemeRoyale.Models.Giphy;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MemeRoyale.Services
{

    public interface IGiphyService
    {
        public Task<string> GetRandomGif(int limit);
    }

    public class GiphyService : IGiphyService
    {
        private readonly IOptions<AppSettings> _appSettings;

        public GiphyService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<string> GetRandomGif(int limit)
        {
            var apiKey = _appSettings.Value.GiphyApiKey;
            var randomOffset = new Random().Next(100);
            var rating = "g";

            string url = $"https://api.giphy.com/v1/gifs/trending?api_key={apiKey}&limit={limit}&offset={randomOffset}&rating={rating}";
            var response = await new HttpClient().GetAsync(url);

            string content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var gifResponse =  JsonConvert.DeserializeObject<GifResponse>(content);
                return gifResponse.Data.ToList()[0].Embed_Url;
            }

            return null;
        }
    }
}
