using TTCM.Models;
using TTCM.Models.BookModel;

namespace TTCM.Repository
{
    public class Category : ICategoryRepository
    {
        private readonly QuanLyBanSachContext _context;

        private static int PAGE_SIZE { get; set; } = 5;
        public Category(QuanLyBanSachContext context)
        {
            _context = context;
        }
        public List<TTheLoai> GetAllCategory(int page = 1)
        {
            var tloais = _context.TTheLoais.OrderBy(x => x.TenTheLoai).AsQueryable();

            if (page == 0)
            {
                return tloais.ToList();
            }
            var result = PaginatedList<TTheLoai>.Create(tloais, page, PAGE_SIZE);

            return result.ToList();
        }

        public List<TTheLoai> GetAllByName(string tenLoai, int page = 1)
        {
            var tloais = _context.TTheLoais.OrderBy(x => x.TenTheLoai).AsQueryable();

            if (!string.IsNullOrEmpty(tenLoai))
            {
                tloais = tloais.Where(x => x.TenTheLoai.Contains(tenLoai));
            }

            if (page == 0)
            {
                return tloais.ToList();
            }

            var result = PaginatedList<TTheLoai>.Create(tloais, page, PAGE_SIZE);

            return result.ToList();
        }
    }
}
