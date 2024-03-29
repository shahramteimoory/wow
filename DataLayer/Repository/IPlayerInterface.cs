﻿using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface IPlayerInterface
    {
        List<Player> GetAllPlayer();
        List<Player> Search(string parameter);
        Player GetPlayerById(int PlayerID);
        bool InsertPlayer(Player player);
        bool UpdatePlayer(Player player);
        bool SoftDeletePlayer(int PlayerID);
        bool SoftDeletePlayer(Player player);
        int GetPlayerIdByName(string Player);
        string GetPlayerNameById(int PlayerID);
        int GetCount(string fullName);
        List<Player> GetAllPlayersExceptOwner();
        List<ViewModel.Player.PlayerViewModel> GetPlayersName(string filter = "");
        List<Player> GetAllSoftDelete();
        bool HardDeletePlayer(int PlayerID);
        List<Player> SearchDeleted(string parameter);
        bool RecoveryDeletePlayer(int playerID);
    }
}
