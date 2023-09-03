using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Services
{
    public class CharacterRepository : ICharacterInterface
    {
        private LichKingDBEntities db;
        public CharacterRepository(LichKingDBEntities contex)
        {
            db = contex;
        }
        public bool DeleteCharachter(int characterId)
        {
            try
            {
                Character character = db.Character.Where(c => c.CharacterID == characterId).FirstOrDefault();
                db.Character.Remove(character);

                return true;
            }
            catch
            {

                return false;
            }

        }

        public List<Character> GetCharachterByPlayerID(int playerID)
        {
            return db.Character.Where(c => c.PlayerID == playerID).ToList();
        }

        public Character GetCharacterByCharacterID(int characterId)
        {
            return db.Character.Find(characterId);
        }

        public int GetCount(string name, string realm, string region)
        {
            return db.Character.Count(c => c.Name.ToLower() == name.ToLower()&& c.Realm.ToLower()== realm.ToLower() && c.Region.ToLower()== region.ToLower());
        }

        public bool InsertCharachter(Character character)
        {
            try
            {
                db.Character.Add(character);

                return true;
            }
            catch

            {

                return false;
            }
        }

        public bool UpdateCharachter(Character character)
        {
            try
            {
                var local = db.Set<Character>()
                    .Local
                    .FirstOrDefault(c => c.CharacterID == character.CharacterID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(character).State = EntityState.Modified;
                return true;
            }
            catch

            {
                return false;
            }
        }
    }
}
