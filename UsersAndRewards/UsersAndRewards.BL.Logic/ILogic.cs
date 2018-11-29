using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.DAL.DataLayer;
using Entities;

namespace UsersAndRewards.BL.Logic
{
    public interface ILogic : IData
    {
        List<UserViewModel> GetUsersViewModel();
    }
}
