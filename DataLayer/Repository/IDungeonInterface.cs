using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface IDungeonInterface
    {
        List<Dungeon> GetAllDungeon();
        List<Dungeon> Search(string parameter);
        Dungeon GetDungeonById(int dungeonID);
        bool InsertDungeon(Dungeon dungeon);
        bool UpdateDungeon(Dungeon dungeon);
        bool SoftDeleteDungeon(int dungeonID);
        bool SoftDeleteDungeon(Dungeon dungeon);
        int GetDungeonIdByName(string dungeon);
        string GetDungeonNameById(int DungeonID);
        List<ViewModel.Dungeon.DungeonViewModel> GetNameDungeons(string filter = "");
        int GetCount(string Name);
        List<Dungeon> GetAllSoftDelete();
        bool HardDeleteDungeon(int dungeonid);
        List<Dungeon> SearchDeleted(string parameter);
        bool RecoveryDeleteDungeon(int dungeonid);
    }
}
