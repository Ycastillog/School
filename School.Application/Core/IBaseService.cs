using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Application.Dtos;

namespace School.Application.Core
{
    public interface IBaseService<TDto> where TDto : DtoBase
    {
        Task<List<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(Guid id);
        Task<TDto> AddAsync(TDto dto);
        Task<TDto> UpdateAsync(TDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}

