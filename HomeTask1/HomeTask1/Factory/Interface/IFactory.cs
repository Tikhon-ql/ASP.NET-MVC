using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1.Factory.Interface
{
    public interface IFactory<T>
    {
        T CreatObject(params object[] _params);
    }
}
