using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TheBettingSite
{
    public class Service
    {
        private static BettingSiteEntities DB = Dao.Dao.getDB();
        private static String HashPass(String pass)
        {
            SHA1 sha = SHA1.Create();
            var input = Encoding.ASCII.GetBytes(pass);
            var hashData = sha.ComputeHash(input);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < hashData.Length; i++)
            {
                sb.Append(hashData[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public static Bruger valiDateLogin(String name,String pass)
        {
            String hashedpass = HashPass(pass);
            Bruger b = Dao.Dao.findUser(hashedpass, name);

            if (b == null)
            {
                throw new Exception("Password incorrect");
            }
            return b;
        }

        public static Bruger CreateBruger(String name, String pass)
        {
            Bruger b = new Bruger();
            b.navn = name;
            b.password = HashPass(pass);
            b.saldo = 300;
            DB.Brugers.Add(b);
            DB.SaveChanges();
            return b;
        }
        public static List<wager> getWagers()
        {
            return Dao.Dao.getWagers();
        }
        public static wager findWager(int id)
        {
            return Dao.Dao.findWager(id);
        }
        public static Bruger findBruger(int id)
        {
            return Dao.Dao.findUserOnid(id);
        }
    }
}