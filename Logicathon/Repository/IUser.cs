
using Logicathon.Models.Domain;

using System.Threading.Tasks;

namespace Logicathon.Repository
{
    public interface IUser
    {
        Task<Login> AddLoginDetailsAsync(Login loginTable);
        Task<Login> AuthenticateUserAsync(string email, string password,string department);
       
    }
}
