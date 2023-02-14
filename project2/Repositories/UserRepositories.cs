using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2.Interface;
using project2;

namespace project.Repositories
    {
        public class UserRepositories: IDataRepository<User>
    {
            private readonly Icontext _context;

            public UserRepositories(Icontext context)
            {
                _context = context;
            }

            public async Task<User> AddAsync(User entity)
            {
                EntityEntry<User> newUser = await _context.user.AddAsync(entity);
                await _context.SaveChangesAsync();
                return newUser.Entity;
            }

   

        public async Task DeleteAsync(int id)
            {
                _context.user.Remove(_context.user.FirstOrDefault(p => p.Id == id));
                await _context.SaveChangesAsync();
            }

            public async Task<List<User>> GetAllAsync()
            {
                return await _context.user.ToListAsync();
            }

            public async Task<User> GetByIdAsync(int id)
            {
                return await _context.user.FindAsync(id);
            }

            public async Task<User> UpdateAsync(int id, User entity)
            {
                entity.Id = id;
                var saveUser = _context.user.Update(entity);
                await _context.SaveChangesAsync();
                return saveUser.Entity;
            }




        }


    }


