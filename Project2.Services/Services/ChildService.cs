using AutoMapper;
using project2.Entities;
using project2.Interface;
using Project2.Common.DTOS;
using Project2.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Services.Services
{
    public class ChildService : IDataService<DTOSChild>
    {
        private readonly IDataRepository<Child> _childRepository;
        private readonly IMapper _mapper;

        public ChildService(IDataRepository<Child> childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }

        public async Task<DTOSChild> AddAsync(DTOSChild child)
        {
            return _mapper.Map<DTOSChild>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));

        }

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeleteAsync(id);
        }

        public async Task<List<DTOSChild>> GetAllAsync()
        {
            return _mapper.Map<List<DTOSChild>>(await _childRepository.GetAllAsync());
        }

        public async Task<DTOSChild> GetByIdAsync(int id)
        {
            var q = await _childRepository.GetByIdAsync(id);
            var a = _mapper.Map<DTOSChild>(q);
            return a;
        }

        public async Task<DTOSChild> UpdateAsync(int id, DTOSChild entity)
        {
            Child child = _mapper.Map<Child>(entity);
            child = await _childRepository.UpdateAsync(id, child);
            return _mapper.Map<DTOSChild>(child);
        }
    }
}



