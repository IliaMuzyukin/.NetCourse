using System.Collections.Generic;
using Entities;

namespace UsersAndRewards.DAL.DataLayer
{
    public interface IData
    {
        #region User Actions

        List<User> GetUsers();

        User GetUserById(int userId);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int userId);

        #endregion

        #region Reward Actions

        List<Reward> GetRewards();

        Reward GetRewardById(int rewardId);

        void AddReward(Reward reward);

        void UpdateReward(Reward reward);

        void DeleteReward(int rewardId);

        #endregion
    }
}
