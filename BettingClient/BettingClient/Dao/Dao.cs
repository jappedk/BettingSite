using BettingClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BettingSite.Dao
{
    public static class Dao
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

    }
}
