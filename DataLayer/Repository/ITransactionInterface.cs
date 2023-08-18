using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface ITransactionInterface
    {
        //List<Transaction> GetAllPlayer();
        List<Transaction> Search(string parameter);
        List<Transaction> GetTransactionByPlayerID(int PlayerID);
        bool InsertTransaction(Transaction transaction);
        List<Transaction> InsertTransactions(List<Transaction> transactions);
        bool UpdateTransaction(Transaction transaction);
        bool DeleteTransaction(int transactionID);

        Transaction GetTransactionByTransactionID(int transactionID);
        List<Transaction> GetTransactionsByType(int type);
        int GetCount(string PlayerfullName);
        // List<ViewModel.Player.PlayerViewModel> GetPlayersName(string filter = "");
    }
}
