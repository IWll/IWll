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
        public static IWllDbContext GetCurrentContext()
        {
            IWllDbContext _nContext = CallContext.GetData("IWllContext") as IWllDbContext;
            if (_nContext == null)
            {
                _nContext = new IWllDbContext();
                CallContext.SetData("IWllContext", _nContext);
            }
            return _nContext;
        }
    }
}
