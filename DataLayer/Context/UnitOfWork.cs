using DataLayer.Repository;
using DataLayer.Services;
using System;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        LichKingDBEntities db = new LichKingDBEntities();

        private IPlayerInterface _PlayerRepository;
        private IDungeonInterface _DungeonRepository;
        private IBoostInterface _BoostRepository;
        private IRunInterface _RunRepository;
        private ITransactionInterface _TransactionRepository;
        public IPlayerInterface PlayerRepository
        {
            get
            {
                if (_PlayerRepository == null)
                {
                    _PlayerRepository = new PlayerRepository(db);
                }
                return _PlayerRepository;
            }
        }

        public IDungeonInterface DungeonRepository
        {
            get
            {
                if (_DungeonRepository == null)
                {
                    _DungeonRepository = new DungeonRepository(db);
                }
                return _DungeonRepository;
            }
        }
        public IBoostInterface BoostRepository
        {
            get
            {
                if (_BoostRepository == null)
                {
                    _BoostRepository = new BoostRepository(db);
                }
                return _BoostRepository;
            }
        }
        public IRunInterface RunRepository
        {
            get
            {
                if (_RunRepository == null)
                {
                    _RunRepository = new RunRepository(db);
                }
                return _RunRepository;
            }
        }
        public ITransactionInterface TransactionRepository
        {
            get
            {
                if (_TransactionRepository == null)
                {
                    _TransactionRepository = new TransactionRepository(db);
                }
                return _TransactionRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
