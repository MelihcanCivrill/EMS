using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
    }
}
