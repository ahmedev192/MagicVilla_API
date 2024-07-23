using MagicVilla_Web.Models.DTOs;
using System.Linq.Expressions;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaNumberCreateDTO dto);
        Task<T> RemoveAsync<T>(int id );
        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto);

    }
}
