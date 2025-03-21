using dijital_asistan.Data;

namespace dijital_asistan.Services  // Bu doğru ad alanı
{
    public class VeritabaniTestService
    {
        private readonly AppDbContext _context;

        public VeritabaniTestService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> TestBaglantiAsync()
        {
            try
            {
                await _context.Database.CanConnectAsync();
                return "Bağlantı başarılı!";
            }
            catch (Exception ex)
            {
                return $"Bağlantı hatası: {ex.Message}";
            }
        }
    }
}
