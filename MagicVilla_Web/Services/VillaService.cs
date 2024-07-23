﻿using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.DTOs;
using MagicVilla_Web.Services.IServices;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly string _villaURL;

        public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _villaURL = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.POST,
                Data = dto,
                ApiUrl = $"{_villaURL}/api/VillaAPI"
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.GET,
                ApiUrl = $"{_villaURL}/api/VillaAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.GET,
                ApiUrl = $"{_villaURL}/api/VillaAPI/{id}"
            });
        }

        public Task<T> RemoveAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.DELETE,
                ApiUrl = $"{_villaURL}/api/VillaAPI/{id}"
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest
            {
                ApiType = SD.APIType.PUT,
                Data = dto,
                ApiUrl = $"{_villaURL}/api/VillaAPI/{dto.Id}"
            });
        }
    }
}
