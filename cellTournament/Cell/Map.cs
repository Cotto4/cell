﻿using System.Collections.Generic;
using System.Linq;
namespace CellTournament.Cell
{
	public class Map
	{
		public List<Fort> Forts = new List<Fort>();
		public List<Player> Players => Forts.Where(f => f.FortOwner != null).Select(f => f.FortOwner).Distinct().ToList();
		public int NumPlayers => Players.Count; //TODO: This should be being used??

		public Map Clone()
		{
			var map = new Map();

			foreach (var fort in Forts)
			{
				map.Forts.Add(fort.Clone());
			}

			foreach (var player in Players)
			{
				map.Players.Add(player.Clone());
			}

			return map;
		}
	}
}
