using Demo.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.IServices
{
    public interface IUserInfoServices:IBaseServices<UserInfo>
    {
        Task<IEnumerable<UserInfo>> QueryUserInfo(string userName,Guid Password);
    }
}
