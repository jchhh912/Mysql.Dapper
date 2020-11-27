using Demo.IRepository;
using Demo.IServices;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class UserInfoServices : BaseServices<UserInfo>, IUserInfoServices
    {
        IUserInfoRepository dal;
        public UserInfoServices(IUserInfoRepository _dal)
        {
            dal = _dal;
            base.BaseDal = _dal;
        }
        public async Task<IEnumerable<UserInfo>> QueryUserInfo(string userName, Guid password)
        {
            var Result = await dal.QueryList($"SELECT * FROM user_info where user_name='{userName}' and password='{password}' limit 1 OFFSET 0");
            return Result;
        }
    }
}
