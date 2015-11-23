using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBettingSite.Dao
{
    public class Dao
    {
        private static BettingSiteEntities DB;

            public static BettingSiteEntities getDB()
        {
            if (DB == null)
            {
                DB = new BettingSiteEntities();
            }
            return DB;
        }
        public static Bruger findUser(string pass, string name)
        {
            Bruger temp = (from b in DB.Brugers where b.navn == name && b.password == pass select b).FirstOrDefault();
            return temp;
        }
        public static List<wager> getWagers()
        {
            return DB.wagers.ToList();
        }
        public static wager findWager(int id)
        {
            return DB.wagers.Find(id);
        }
    }
}