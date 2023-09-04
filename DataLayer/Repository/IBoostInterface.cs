using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface IBoostInterface
    {
        List<Boost> GetAllBoost();
        List<Boost> Search(string parameter);
        Boost GetBoostById(int boostID);
        bool InsertBoost(Boost boost);
        bool UpdateBoost(Boost boost);
        bool DeleteBoost(int boostID);
        
        List<int> GetBoostIdsByPlayerID(int playerId);
        List<Boost> NotAsignedBoosts();
        int GetCount(int playerID);
    }
}
