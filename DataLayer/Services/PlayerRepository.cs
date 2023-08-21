using DataLayer.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ViewModel.Player;

namespace DataLayer.Services
{
    public class PlayerRepository : IPlayerInterface
    {
        private LichKingDBEntities db;

        public PlayerRepository(LichKingDBEntities contex)
        {
            db = contex;
        }
        /// <summary>
        /// این متود همه پلیرها رو به صورت لیست میاورد
        /// </summary>
        /// <returns></returns>
        public List<Player> GetAllPlayer()
        {
            return db.Player.Where(p => p.IsDelete == false).ToList();
        }

        public List<Player> GetAllPlayersExceptOwner()
        {
            return db.Player.Where(player => player.PlayerID > 0 && player.IsDelete == false).ToList();
        }

        public List<Player> GetAllSoftDelete()
        {
            return db.Player.Where(p => p.IsDelete == true).ToList();
        }

        public int GetCount(string fullName)
        {
            return db.Player.Count(p => p.FullName.ToLower() == fullName.ToLower());

        }



        /// <summary>
        /// این متود به نصبت ای دی پلیر میارش
        /// </summary>
        /// <param name="PlayerID"></param>
        /// <returns></returns>
        public Player GetPlayerById(int PlayerID)
        {
            return db.Player.Find(PlayerID);
        }
        /// <summary>
        /// این متد باعث میشه با دادن اسم پلیر ای دی را بگیریم
        /// </summary>
        /// <param name="Player"></param>
        /// <returns></returns>
        public int GetPlayerIdByName(string Player)
        {
            return db.Player.First(p => p.FullName == Player).PlayerID;
        }

        /// <summary>
        /// با دادن نام پلیر ای دی رو به ما میده
        /// </summary>
        /// <param name="PlayerID"></param>
        /// <returns></returns>
        public string GetPlayerNameById(int PlayerID)
        {
            return db.Player.Find(PlayerID).FullName;
        }

        public List<PlayerViewModel> GetPlayersName(string filter = "")
        {
            if (filter == null)
            {
                return db.Player
                    .Where(p => p.IsDelete == false) // شرط IsDelete = false
                    .Select(p => new PlayerViewModel()
                    {
                        PlayerID = p.PlayerID,
                        FullName = p.FullName
                    }).ToList();
            }
            return db.Player
                .Where(p => p.FullName.Contains(filter) && p.IsDelete == false) // شرط IsDelete = false
                .Select(p => new PlayerViewModel()
                {
                    PlayerID = p.PlayerID,
                    FullName = p.FullName
                }).ToList();
        }

        public bool HardDeletePlayer(int PlayerID)
        {
            try
            {
                if (PlayerID == 0)
                {
                    return false; // شناسه 0 قابل قبول نیست
                }

                Player player = db.Player.FirstOrDefault(p => p.PlayerID == PlayerID);
                if (player != null)
                {
                    db.Player.Remove(player);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false; // بازیکن با شناسه مورد نظر یافت نشد
                }
            }
            catch
            {
                return false; // خطایی در حذف رخ داد
                ;
            }
        }

        /// <summary>
        /// متد ادد کردن پلیر به دی تابیس
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool InsertPlayer(Player player)
        {
            try
            {
                db.Player.Add(player);

                return true;
            }
            catch
            
            {

                return false;
            }

        }

        public bool RecoveryDeletePlayer(int playerID)
        {
            try
            {
                var player = db.Player.FirstOrDefault(p => p.PlayerID == playerID);
                if (player != null)
                {
                    player.IsDelete = false;
                    db.Entry(player).State = EntityState.Modified;
                }
                return true;
            }
            catch
            
            {
                return false;
            }
        }

        /// <summary>
        /// متدی برای سرچ کردن پلیر
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public List<Player> Search(string parameter)
        {
            return db.Player.Where(p => p.FullName.Contains(parameter) && p.IsDelete == false).ToList();
        }

        public List<Player> SearchDeleted(string parameter)
        {
            return db.Player.Where(p => p.FullName.Contains(parameter) && p.IsDelete == true).ToList();
        }

        /// <summary>
        /// سافت دلیت با ایدی ای دی رو میگیریم  اسم طرفو در میاریم بعد از اون یکی سافت دلیت استفاده میکنیم
        /// </summary>
        /// <param name="PlayerID"></param>
        /// <returns></returns>
        public bool SoftDeletePlayer(int PlayerID)
        {
            try
            {
                var player = GetPlayerById(PlayerID);
                SoftDeletePlayer(player);
                return true;
            }
            catch
            
            {
                return false;

            }
        }

        /// <summary>
        /// این فکنم مثل ادیت باشه
        /// متد دلیت پلیر
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool SoftDeletePlayer(Player player)
        {
            try
            {
                player.IsDelete = true; // تنظیم فیلد isDeleted به true برای نشان دادن حذف نرم
                db.Entry(player).State = EntityState.Modified;
                return true;
            }
            catch
            
            {
                return false;
            }
        }

        /// <summary>
        /// متد آپدیت پلیر
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool UpdatePlayer(Player player)
        {
            try
            {
                var local = db.Set<Player>()
                    .Local
                    .FirstOrDefault(p => p.PlayerID == player.PlayerID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(player).State = EntityState.Modified;
                return true;
            }
            catch
            
            {
                return false;
            }
        }
    }
}
