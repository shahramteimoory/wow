using DataLayer.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Services
{
    public class TransactionRepository : ITransactionInterface
    {
        private LichKingDBEntities db;
        public TransactionRepository(LichKingDBEntities contex)
        {
            db = contex;
        }
        public bool DeleteTransaction(int transactionID)
        {
            try
            {
                Transaction transaction = db.Transaction.Where(t => t.TransactionID == transactionID).FirstOrDefault();
                db.Transaction.Remove(transaction);

                return true;
            }
            catch
            {

                return false;
            }
        }

        public int GetCount(string PlayerfullName)
        {
            return db.Transaction.Count(T => T.Player.FullName.ToLower() == PlayerfullName.ToLower());
        }

        public List<Transaction> GetTransactionByPlayerID(int PlayerID)
        {

            return db.Transaction.Where(t => t.PlayerID == PlayerID).ToList();

        }

        public List<Transaction> GetTransactionsByType(int type)
        {
            return db.Transaction.Where(t => t.Type == type).ToList();
        }

        public bool InsertTransaction(Transaction transaction)
        {
            try
            {
                db.Transaction.Add(transaction);
                return true;
            }
            catch
            {

                return false;
            }

        }

        public List<Transaction> InsertTransactions(List<Transaction> transactions)
        {
            {
                List<Transaction> InsertTransactions = new List<Transaction>();

                foreach (Transaction transaction in transactions)
                {
                    // انجام عملیات یا منطق مورد نیاز برای هر تراکنش
                    // به عنوان مثال، می‌توانید تراکنش را به لیست اضافه کنید
                    InsertTransactions.Add(transaction);
                }

                return InsertTransactions;
            }
        }

        public List<Transaction> Search(string parameter)
        {
            return db.Transaction.Where(T => T.Player.FullName.Contains(parameter) || T.Type.ToString().Contains(parameter)
            || T.Amount.ToString().Contains(parameter)).ToList();
        }

        public bool UpdateTransaction(Transaction transaction)
        {
            try
            {
                var local = db.Set<Transaction>()
                    .Local
                    .FirstOrDefault(t => t.TransactionID == transaction.TransactionID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(transaction).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
