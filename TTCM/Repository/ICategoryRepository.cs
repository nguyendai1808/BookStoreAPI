using TTCM.Models;

namespace TTCM.Repository
{
    public interface ICategoryRepository
    {
        List<TTheLoai> GetAllCategory(int page);

        List<TTheLoai> GetAllByName(string tenLoai, int page);
    }
}
