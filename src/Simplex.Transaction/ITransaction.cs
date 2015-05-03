using System;

namespace Simplex.Transaction
{
    public interface ITransaction
    {
        bool IsActive { get; }

        bool WasCommitted { get; }

        bool WasRolledBack { get; }

        void Commit();

        void RollBack();

        void AddCompletionHandler(ITransactionCompletionHandler transactionCompletionHandler);
    }
}
