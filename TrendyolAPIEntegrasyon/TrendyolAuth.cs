using System.Net.Http.Headers;
using System.Text;

namespace TrendyolAPIEntegrasyon
{
    public class TrendyolAuth
    {
        private string _supplierid;
        private string _apiKey;
        private string _apiKeySecret;
        private string userAgent;
        private HttpClient? _httpClient;

        public TrendyolAuth(string APIKEY, string APISECRET, string supplierid)
        {
            _apiKey = APIKEY;
            _apiKeySecret = APISECRET;
            _supplierid = supplierid;
            userAgent = $"{_supplierid} - SelfIntegration";
            Create();
        }
        /// <summary>
        /// Creates instance of authorized HttpClient
        /// </summary>
        private void Create()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_apiKey}:{_apiKeySecret}")));
            httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
            _httpClient = httpClient;
        }
        /// <summary>
        /// Get Authorized HttpClient
        /// </summary>
        public HttpClient Result()
        {
            if (_httpClient != null)
                return _httpClient;
            else
                return new HttpClient();
        }
    }
}