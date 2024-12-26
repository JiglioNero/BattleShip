using System;
namespace BattleShip
{
	public class Player
	{

		private Ship?[,] Battleground = new Ship?[Game.BattlegroundSize, Game.BattlegroundSize];
		private List<Ship> ships = new();
		public String name { get; }

		public Player(String name)
		{
			this.name = name;
		}

		public void SetUpBattleground(BattlegroundConfig config)
		{
			foreach (KeyValuePair<Ship, List<(int, int)>> shipPoint in config)
			{
				Ship ship = shipPoint.Key;
				foreach ((int, int) point in shipPoint.Value)
				{
					Battleground[point.Item1, point.Item2] = ship;
				}
				ships.Add(ship);
			}

		}

		public (int, int) GetPointToShot()
		{
			return ConsoleHelper.ReadCoordinates(Game.BattlegroundSize);

        }

		public ActionResult ShotToPoint((int, int) point)
		{
			Ship? ship = Battleground[point.Item1, point.Item2];
			if (ship != null)
			{
				ship.Hit();
				if (ship.IsKilled())
				{
                    foreach (Ship sh in ships)
                    {
						if (!sh.IsKilled())
						{
							return ActionResult.KILL;
                        }
                    }
					return ActionResult.WIN;
                }
				else
				{
                    return ActionResult.HIT;
				}
			}
			else
			{
				return ActionResult.MISS;
			}
		}
	}
}

