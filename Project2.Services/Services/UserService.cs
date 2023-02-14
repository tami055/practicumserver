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
    public class UserService: IDataService<DTOSUser>
    {
        private readonly IDataRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IDataRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<DTOSUser> AddAsync(DTOSUser user)
        {
            return _mapper.Map<DTOSUser>(await _userRepository.AddAsync(_mapper.Map<User>(user)));
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<List<DTOSUser>> GetAllAsync()
        {
            return _mapper.Map<List<DTOSUser>>(await _userRepository.GetAllAsync());
        }

        public async Task<DTOSUser> GetByIdAsync(int id)
        {
            var q = await _userRepository.GetByIdAsync(id);
            var a = _mapper.Map<DTOSUser>(q);
            return a;
        }

        public async Task<DTOSUser> UpdateAsync(int id, DTOSUser entity)
        {
            User user = _mapper.Map<User>(entity);
            user = await _userRepository.UpdateAsync(id, user);
            return _mapper.Map<DTOSUser>(user);
        }
    }
}
