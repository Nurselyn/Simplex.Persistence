using System;

namespace Simplex.Transaction
{
    public interface ITransactionCompletionHandler
    {
        void BeforeCompletion();
        void AfterCompletion(bool success);
    }
}
