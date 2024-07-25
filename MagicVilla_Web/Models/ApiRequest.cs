using static MagicVilla_Utility.SD;

namespace MagicVilla_Web.Models
{
    public class APIRequest
    {
        public APIType ApiType { get; set; } = APIType.GET; 
        public string ApiUrl { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }


        public APIRequest(APIType apiType, string apiUrl, object? data = null)
        {
            ApiType = apiType;
            ApiUrl = apiUrl;
            Data = data;

        }

        public APIRequest()
        {
                
        }
    }
}
