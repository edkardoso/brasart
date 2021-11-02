using System;
using System.Threading.Tasks;

namespace Brasart.Domain.Common.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Commit(bool dispose);
        Task CommitAsync();
        Task CommitAsync(bool dispose);
        bool Success { get; }


    }

}
