using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface ICharacterInterface
    {
        bool InsertCharachter(Character character);
        bool DeleteCharachter(int characterId);
        bool UpdateCharachter(Character character);
        List<Character> GetCharachterByPlayerID(int playerID);
        int GetCount(string name,string realm,string region);
        Character GetCharacterByCharacterID(int characterId);
    }
}
