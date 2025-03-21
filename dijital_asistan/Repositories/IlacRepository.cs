using dijital_asistan.Data;
using dijital_asistan.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dijital_asistan.Repositories
{
    public class IlacRepository
    {
        private readonly AppDbContext _context;

        public IlacRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ilac>> GetAllAsync() => await _context.Ilaclar.ToListAsync();

        public async Task<Ilac> GetByIdAsync(int id) => await _context.Ilaclar.FindAsync(id);

        public async Task AddAsync(Ilac ilac)
        {
            await _context.Ilaclar.AddAsync(ilac);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Ilac ilac)
        {
            _context.Ilaclar.Update(ilac);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var ilac = await _context.Ilaclar.FindAsync(id);
            if (ilac != null)
            {
                _context.Ilaclar.Remove(ilac);
                await _context.SaveChangesAsync();
            }
        }
    }
}

