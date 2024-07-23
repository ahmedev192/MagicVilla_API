using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public APIResponse ResponseModel { get; set; }

        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            ResponseModel = new APIResponse();
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = _httpClientFactory.CreateClient("MagicAPI");
                var requestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri(apiRequest.ApiUrl),
                    Method = GetHttpMethod(apiRequest.ApiType),
                    Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json")
                };
                requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.SendAsync(requestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(responseContent);
                }
                else
                {
                    var errorResponse = JsonConvert.DeserializeObject<APIResponse>(responseContent);
                    if (errorResponse != null)
                    {
                        errorResponse.StatusCode = response.StatusCode;
                        return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(errorResponse));
                    }
                    else
                    {
                        return CreateErrorResponse<T>(responseContent);
                    }
                }
            }
            catch (Exception ex)
            {
                return CreateErrorResponse<T>(ex.ToString());
            }
        }

        private HttpMethod GetHttpMethod(SD.APIType apiType)
        {
            return apiType switch
            {
                SD.APIType.POST => HttpMethod.Post,
                SD.APIType.PUT => HttpMethod.Put,
                SD.APIType.DELETE => HttpMethod.Delete,
                _ => HttpMethod.Get
            };
        }

        private T CreateErrorResponse<T>(string errorMessage)
        {
            var errorResponse = new APIResponse
            {
                IsSuccess = false,
                ErrorMessages = new List<string> { errorMessage }
            };
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(errorResponse));
        }
    }
}
