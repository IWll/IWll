using IWll.Models;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace IWll.DAL
{
    /// <summary>
    /// 上下文简单工厂
    /// <remarks>
    /// 创建：2014.02.05
    /// </remarks>
    /// </summary>
    public class ContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static IWDAEntities GetCurrentContext()
        {
            IWDAEntities _nContext = CallContext.GetData("IWllContext") as IWDAEntities;
            if (_nContext == null)
            {
                _nContext = new IWDAEntities();
                CallContext.SetData("IWllContext", _nContext);
            }
            return _nContext;
        }
    }
}
