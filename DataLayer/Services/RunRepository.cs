using DataLayer.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Services
{
    public class RunRepository : IRunInterface
    {
        private LichKingDBEntities db;
        public RunRepository(LichKingDBEntities contex)
        {
            db = contex;
        }
        public bool DeleteRun(int RunID)
        {
            try
            {
                Run run = db.Run.Where(r => r.RunID == RunID).FirstOrDefault();
                db.Run.Remove(run);

                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteRuns(int BoostID)
        {
            try
            {
                List<Run> runs = db.Run.Where(r => r.BoostID == BoostID).ToList();

                foreach (var item in runs)
                {
                    db.Run.Remove(item);
                }

                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Run> GetMyRunByPlayerID(int PlayerID)
        {
            return db.Run.Where(r => r.PlayerID == 0 && r.Boost.PlayerID == PlayerID).ToList();
        }

        public List<Run> GetRunByPlayerID(int PlayerID)
        {
            return db.Run.Where(r => r.PlayerID == PlayerID).ToList();
        }

        public bool InsertRun(Run run)
        {
            try
            {
                db.Run.Add(run);

                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool UpdateRun(Run run)
        {
            try
            {
                var local = db.Set<Run>()
                    .Local
                    .FirstOrDefault(r => r.RunID == run.RunID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(run).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
