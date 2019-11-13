﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Bots
{
    abstract class BaseBot : IBot
    {
        protected string m_player;

        public void SetPlayer(string player)
        {
            m_player = player;
        }

        public abstract List<Move> Do(string boardString);
      
        public static List<Fort> GetFriendlyForts(string player, BoardState board)
        {
            return board.Forts.Where(f => f.FortOwner == player).ToList();
        }
        public static List<Fort> GetEnemyForts(string player, BoardState board)
        {
            return board.Forts.Where(f => f.FortOwner != null && f.FortOwner != player).ToList();
        }
    }
}