using dijital_asistan.Entities;
using dijital_asistan.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dijital_asistan.Repositories
{
    public class RandevuTakipRepository
    {
        private readonly AppDbContext _context;

        public RandevuTakipRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all appointments (Only RandevuTakip data)
        public async Task<List<RandevuTakip>> GetAllAsync()
        {
            return await _context.RandevuTakipler.ToListAsync(); // Only RandevuTakip data
        }

        // Get appointment by ID (Only RandevuTakip data)
        public async Task<RandevuTakip> GetByIdAsync(int id)
        {
            var randevu = await _context.RandevuTakipler
                                       .FirstOrDefaultAsync(r => r.RandevuId == id); // Only RandevuTakip data

            if (randevu == null)
            {
                throw new KeyNotFoundException("Randevu bulunamadı.");
            }

            return randevu;
        }

        // Add a new appointment
        public async Task AddAsync(RandevuTakip randevu)
        {
            if (randevu == null)
                throw new ArgumentNullException(nameof(randevu), "Randevu verisi null olamaz.");

            await _context.RandevuTakipler.AddAsync(randevu);
            await _context.SaveChangesAsync();
        }

        // Update an existing appointment
        public async Task UpdateAsync(RandevuTakip randevu)
        {
            if (randevu == null)
                throw new ArgumentNullException(nameof(randevu), "Randevu verisi null olamaz.");

            _context.RandevuTakipler.Update(randevu);
            await _context.SaveChangesAsync();
        }

        // Delete an appointment
        public async Task DeleteAsync(int id)
        {
            var randevu = await _context.RandevuTakipler.FindAsync(id);
            if (randevu == null)
            {
                throw new KeyNotFoundException("Randevu bulunamadı.");
            }

            _context.RandevuTakipler.Remove(randevu);
            await _context.SaveChangesAsync();
        }
    }
}
