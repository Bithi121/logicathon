using Logicathon.Repository;

namespace Logicathon.Services
{
    public class UserService
    {
        //private IUser _userRepo;
        IUser _userRepo;
        #region UserService
        public UserService(IUser userRepo)
        {
            _userRepo = userRepo;
        }
        #endregion
    }
}