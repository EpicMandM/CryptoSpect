using CryptoSpect.Core.Interfaces;
using CryptoSpect.Service.Interfaces;

namespace CryptoSpect.Service.Implementations;
public class TransactionHistoryService : ITransactionHistoryService
{
    private readonly ITransactionHistoryRepository _transactionHistoryRepository;

    public TransactionHistoryService(ITransactionHistoryRepository transactionHistoryRepository)
    {
        _transactionHistoryRepository = transactionHistoryRepository;
    }
}
