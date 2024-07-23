using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.DTOs;
using MagicVilla_Web.Services.IServices;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace MagicVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly string _villaURL; 

        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _villaURL = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.POST,
                Data = dto,
                ApiUrl = $"{_villaURL}/api/VillaNumberAPI"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.GET,
                ApiUrl = $"{_villaURL}/api/VillaNumberAPI"
            });
        }

        public Task<T> GetAsync<T>(int villaNumber)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.GET,
                ApiUrl = $"{_villaURL}/api/VillaNumberAPI/{villaNumber}"
            });
        }

        public Task<T> RemoveAsync<T>(int villaNumber)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.DELETE,
                ApiUrl = $"{_villaURL}/api/VillaNumberAPI/{villaNumber}"
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.PUT,
                Data = dto,
                ApiUrl = $"{_villaURL}/api/VillaNumberAPI/{dto.VillaNumber}"
            });
        }
    }
}
