using Microsoft.EntityFrameworkCore;
using project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public interface Icontext
    {

        DbSet<User> user { get; set; }
        DbSet<Child> child { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
