using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.DTOs;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaURL; 
        public VillaService(IHttpClientFactory _clientFactory, IConfiguration configuration) : base(_clientFactory)
        {
           this._clientFactory = _clientFactory;
            villaURL = configuration.GetValue<string>("ServiceUrls:VillaAPI");
               
        }
        public Task<T> CreateAsync<T>(VillaCreateDTO dto)
        {
            return SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.APIType.POST,
                Data = dto ,
                ApiUrl = villaURL+ "/api/VillaAPI"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.APIType.GET,
                ApiUrl = villaURL + "/api/VillaAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.APIType.GET,
                Data = id,
                ApiUrl = villaURL + "/api/VillaAPI/"+id
            });
        }

        public Task<T> RemoveAsync<T>(int id)
        {
            return SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.APIType.Delete,
                Data = id,
                ApiUrl = villaURL + "/api/VillaAPI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto)
        {
            return SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.APIType.PUT,
                Data = dto,
                ApiUrl = villaURL + "/api/VillaAPI/"+dto.Id
            });
        }
    }
}
