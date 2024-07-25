﻿using MagicVilla_Web.Models.DTOs;
using System.Linq.Expressions;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(VillaCreateDTO dto, string token);
        Task<T> RemoveAsync<T>(int id , string token);
        Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token);

    }
}
