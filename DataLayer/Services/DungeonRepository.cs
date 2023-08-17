using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ViewModel.Dungeon;

namespace DataLayer.Services
{
    public class DungeonRepository : IDungeonInterface
    {
        private LichKingDBEntities db;

        public DungeonRepository(LichKingDBEntities contex)
        {
            db = contex;
        }

        /// <summary>
        /// گرفتن لیست همه ی دانجن ها
        /// </summary>
        /// <returns></returns>
        public List<Dungeon> GetAllDungeon()
        {
            return db.Dungeon.Where(p => p.IsDelete == false).ToList();
        }

        /// <summary>
        /// شمردن اسم دانجن ها برای پیدا کردن تکراری
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetCount(string Name)
        {
            return db.Dungeon.Count(d => d.Name.ToLower() == Name.ToLower());
        }

        /// <summary>
        /// دانجن را بر اساس آی دی پیدا میکنه
        /// </summary>
        /// <param name="dungeonID"></param>
        /// <returns></returns>
        public Dungeon GetDungeonById(int dungeonID)
        {
            return db.Dungeon.Find(dungeonID);
        }

        /// <summary>
        /// اسم دانجن را میگیرد آی دی را پیدا میکند
        /// </summary>
        /// <param name="dungeon"></param>
        /// <returns></returns>
        public int GetDungeonIdByName(string dungeon)
        {
            return db.Dungeon.First(d => d.Name == dungeon).DungeonID;
        }
        /// <summary>
        /// اسم دانجن را بر اساس آی دی میده
        /// </summary>
        /// <param name="DungeonID"></param>
        /// <returns></returns>
        public string GetDungeonNameById(int DungeonID)
        {
            return db.Dungeon.Find(DungeonID).Name;
        }

        public List<DungeonViewModel> GetNameDungeons(string filter = "")
        {
            if (filter == null)
            {
                return db.Dungeon
                    .Where(d => d.IsDelete == false) // شرط IsDelete = false
                    .Select(d => new DungeonViewModel()
                    {
                        DungeonID = d.DungeonID,
                        Name = d.Name
                    }).ToList();
            }
            return db.Dungeon
                .Where(d => d.Name.Contains(filter) && d.IsDelete == false) // شرط IsDelete = false
                .Select(d => new DungeonViewModel()
                {
                    DungeonID = d.DungeonID,
                    Name = d.Name
                }).ToList();
        }


        /// <summary>
        /// متد اضافه کردن دانجن 
        /// </summary>
        /// <param name="dungeon"></param>
        /// <returns></returns>
        public bool InsertDungeon(Dungeon dungeon)
        {
            try
            {
                dungeon.IsDelete = false;
                dungeon.Name = dungeon.Name;
                db.Dungeon.Add(dungeon);

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// متد سرچ کردن دانجن ها
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public List<Dungeon> Search(string parameter)
        {
            return db.Dungeon.Where(d => d.Name.Contains(parameter) && d.IsDelete == false).ToList();
        }

        /// <summary>
        /// ساغت دلیت دانجن از طریق آی دی باکمک گت دانجن بای آی دی و سافت دلیت
        /// </summary>
        /// <param name="dungeonID"></param>
        /// <returns></returns>
        public bool SoftDeleteDungeon(int dungeonID)
        {
            try
            {
                var dungeon = GetDungeonById(dungeonID);
                SoftDeleteDungeon(dungeon);
                return true;
            }
            catch
            {
                return false;

            }
        }

        /// <summary>
        /// سافت دلیت دانجن
        /// </summary>
        /// <param name="dungeon"></param>
        /// <returns></returns>
        public bool SoftDeleteDungeon(Dungeon dungeon)
        {
            try
            {
                dungeon.IsDelete = true; // تنظیم فیلد isDeleted به true برای نشان دادن حذف نرم
                db.Entry(dungeon).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// متد آپدیت دانجن
        /// </summary>
        /// <param name="dungeon"></param>
        /// <returns></returns>
        public bool UpdateDungeon(Dungeon dungeon)
        {
            try
            {
                var local = db.Set<Dungeon>()
                    .Local
                    .FirstOrDefault(d => d.DungeonID == dungeon.DungeonID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(dungeon).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
