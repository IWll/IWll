using IWll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWll.IBLL
{
    public interface InterfaceManagerService : InterfaceBaseService<Manager>
    {
        /// <summary>
        /// 管理员登陆
        /// </summary>
        /// <returns>布尔值</returns>
        bool Login(string managerName, string password);
    }
}
