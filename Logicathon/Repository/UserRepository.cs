using Microsoft.EntityFrameworkCore;
using Logicathon.Data;
using Logicathon.Models.Domain;
using System;
using System.Threading.Tasks;
using Logicathon.Repository;

namespace Logicathon.Repository
{
    public class UserRepository : IUser
    {

        private RolloffDbContext _context;

        public UserRepository(RolloffDbContext context)
        {
            _context = context;
        }

        #region AddLoginDetailsAsync
        public async Task<Login> AddLoginDetailsAsync(Login loginTable)
        {
            try
            {
                await _context.login.AddAsync(loginTable);
                await _context.SaveChangesAsync();
                return loginTable;
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion

        #region AuthenticateUserAsync
        public async Task<Login> AuthenticateUserAsync(string username, string password,string department)
        {
            try
            {
                var user = await _context.login.FirstOrDefaultAsync(x => x.Username == username && x.Password == password && x.Department == department);
                return user;
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion
      

       
    }
}
