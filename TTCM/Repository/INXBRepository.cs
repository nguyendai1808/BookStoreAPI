using TTCM.Models;

namespace TTCM.Repository
{
    public interface INXBRepository
    {
        List<TNhaXuatBan> GetAllNXB(int page);

        List<TNhaXuatBan> GetAllByName(string tenNXB, int page);
    }
}
