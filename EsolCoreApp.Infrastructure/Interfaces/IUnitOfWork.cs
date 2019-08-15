using System;
using System.Collections.Generic;
using System.Text;

namespace EsolCoreApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
