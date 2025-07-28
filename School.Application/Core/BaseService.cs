using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Application.Dtos;

namespace School.Application.Core
{
    public class BaseService<TDto> where TDto : DtoBase
    {
        private readonly List<TDto> _items = new List<TDto>();

        public virtual Task<List<TDto>> GetAllAsync()
        {
            return Task.FromResult(_items);
        }

        public virtual Task<TDto> GetByIdAsync(Guid id)
        {
            var item = _items.Find(i => i.Id == id);
            return Task.FromResult(item);
        }

        public virtual Task<TDto> AddAsync(TDto dto)
        {
            dto.Id = Guid.NewGuid();
            _items.Add(dto);
            return Task.FromResult(dto);
        }

        public virtual Task<bool> DeleteAsync(Guid id)
        {
            var item = _items.Find(i => i.Id == id);
            if (item != null)
            {
                _items.Remove(item);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public virtual Task<TDto> UpdateAsync(TDto dto)
        {
            var index = _items.FindIndex(i => i.Id == dto.Id);
            if (index >= 0)
            {
                _items[index] = dto;
                return Task.FromResult(dto);
            }
            return Task.FromResult<TDto>(null);
        }
    }
}


