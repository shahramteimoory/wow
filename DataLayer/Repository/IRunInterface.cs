using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface IRunInterface
    {
        bool InsertRun(Run run);
        bool UpdateRun(Run run);
        bool DeleteRun(int RunID);
        bool DeleteRuns(int BoostID);
        List<Run> GetRunByPlayerID(int PlayerID);
    }
}
