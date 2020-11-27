using Demo.IRepository;
using Demo.Model;
using Microsoft.Extensions.Configuration;
using Repository;

namespace Demo.Repository
{
    public class UserInfoRepository:BaseRepository<UserInfo>,IUserInfoRepository
    {
        public UserInfoRepository(IConfiguration configuration) : base(configuration) 
        {
        }
    }
}
