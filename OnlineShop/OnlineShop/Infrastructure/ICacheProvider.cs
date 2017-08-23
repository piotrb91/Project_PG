using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure
{
    public interface ICacheProvider
    {
        object Get(string key);
        void Set(string key, object Data, int CacheTime);
        bool IsSet(string key);
        void Invalidate(string key);
    }
}
