using System.Threading.Tasks;

namespace WebApplication1.Models.Db
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
