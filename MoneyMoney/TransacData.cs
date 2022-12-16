using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Controls;

namespace MoneyMoney
{
    public static class TransacData
    {
        public static void AddTransaction(transac xd)
        {
            using( var db = new UserDataContext())
            {
                db.Add(xd);
                db.SaveChanges();
            }
        }

       

        public static List<transac> GetTransac()
        {
            using( var db = new UserDataContext() )
            {
                return db.Transactions.OrderBy(b => b.Id).ToList(); 
            }
        }
    }
}
