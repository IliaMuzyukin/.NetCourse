using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.DAL.DataLayer
{
    static public class DataContextFactory
    {
        static public IData Create(string key)
        {
            if (key.Equals("SqlData"))
            {
                return new SqlData();
            }
            else
            {
                return new InMemoryData();
            }
        }
    }
}
