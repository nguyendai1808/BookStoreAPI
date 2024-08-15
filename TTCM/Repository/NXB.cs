using TTCM.Models;
using TTCM.Models.BookModel;

namespace TTCM.Repository
{
    public class NXB : INXBRepository
    {

        private readonly QuanLyBanSachContext _context;

        private static int PAGE_SIZE { get; set; } = 5;
        public NXB(QuanLyBanSachContext context)
        {
            _context = context;
        }


        public List<TNhaXuatBan> GetAllNXB(int page = 1)
        {
            var nxbs = _context.TNhaXuatBans.OrderBy(x => x.TenNxb).AsQueryable();

            if (page == 0)
            {
                return nxbs.ToList();
            }
            var result = PaginatedList<TNhaXuatBan>.Create(nxbs, page, PAGE_SIZE);

            return result.ToList();
        }


        public List<TNhaXuatBan> GetAllByName(string tenNXB, int page = 1)
        {
            var nxbs = _context.TNhaXuatBans.OrderBy(x => x.TenNxb).AsQueryable();

            if (!string.IsNullOrEmpty(tenNXB))
            {
                nxbs = nxbs.Where(x => x.TenNxb.Contains(tenNXB));
            }

            if (page == 0)
            {
                return nxbs.ToList();
            }

            var result = PaginatedList<TNhaXuatBan>.Create(nxbs, page, PAGE_SIZE);

            return result.ToList();
        }

        
    }
}
