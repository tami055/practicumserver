using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using project2.Entities;
using project2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2;

namespace project.Repositories
    {
        public class ChildRepositories : IDataRepository<Child>
        {
            private readonly Icontext _context;

            public ChildRepositories(Icontext context)
            {
                _context = context;
            }

            public async Task<Child> AddAsync(Child entity)
            {
                EntityEntry<Child> newChild = await _context.child.AddAsync(entity);
                await _context.SaveChangesAsync();
                return newChild.Entity;
            }



            public async Task DeleteAsync(int id)
            {
                _context.child.Remove(_context.child.FirstOrDefault(p => p.Id == id));
                await _context.SaveChangesAsync();
            }

            public async Task<List<Child>> GetAllAsync()
            {
                return await _context.child.ToListAsync();
            }

            public async Task<Child> GetByIdAsync(int id)
            {
                return await _context.child.FindAsync(id);
            }

            public async Task<Child> UpdateAsync(int id, Child entity)
            {
                entity.Id = id;
                var savePickUpBin = _context.child.Update(entity);
                await _context.SaveChangesAsync();
                return savePickUpBin.Entity;
            }




        }
    }



