using DataLayer.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Services
{
    public class BoostRepository : IBoostInterface
    {
        private LichKingDBEntities db;

        public BoostRepository(LichKingDBEntities contex)
        {
            db = contex;
        }

        public bool DeleteBoost(int boostID)
        {
            try
            {
                var local = db.Set<Boost>()
                    .Local
                    .FirstOrDefault(b => b.BoostID == boostID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }

                var boost = GetBoostById(boostID);

                //var runs = boost.Run;
                //using (UnitOfWork udb = new UnitOfWork())
                //{
                //    foreach (var item in runs)
                //    {
                //        udb.RunRepository.DeleteRun(item.RunID);
                //    }
                //    udb.Save();
                //    udb.Dispose();
                //}

                db.Boost.Remove(boost);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Boost> GetAllBoost()
        {
            return db.Boost.ToList();
        }

        public Boost GetBoostById(int boostID)
        {
            return db.Boost.Find(boostID);
        }

        /// <summary>
        /// با دادن آی دی پلیر لیست تمامی بوست هایی که توش بوده رو میده
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns></returns>
        public List<int> GetBoostIdsByPlayerID(int playerId)
        {
            var boosts = db.Boost.Where(b => b.PlayerID == playerId).Select(b => b.BoostID).ToList();
            return boosts;
        }

        public int GetCount(int playerID)
        {
            return db.Boost.Count(b => b.PlayerID == playerID);
        }

        //public string GetDetailById(int boostID)
        //{
        //    throw new NotImplementedException();
        //}

        public bool InsertBoost(Boost boost)
        {
            try
            {
                db.Boost.Add(boost);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Boost> Search(string parameter)
        {



            return db.Boost.Where(b => b.Dungeon.Name.Contains(parameter) ||
                                       b.Gold.ToString().Contains(parameter) ||
                                       (b.Lvl.HasValue && b.Lvl.Value.ToString().Contains(parameter)) ||
                                       b.Player.FullName.Contains(parameter))
                           .ToList();

        }


        //public bool SoftDeleteBoost(int boostID)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool SoftDeleteBoost(Boost boost)
        //{
        //    throw new NotImplementedException();
        //}

        public bool UpdateBoost(Boost boost)
        {
            try
            {
                var local = db.Set<Boost>()
                    .Local
                    .FirstOrDefault(b => b.BoostID == boost.BoostID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(boost).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
