using System;
namespace BattleShip
{
	public class Ship
	{
		private int CurrentHelth;
		public Ship(ShipType ShipType)
		{
			CurrentHelth = ((int)ShipType);
		}

		public void Hit()
		{
			if (CurrentHelth > 0)
			{
                CurrentHelth--;
            }
        }

		public bool IsKilled()
		{
			return CurrentHelth == 0;
		}
	}
}

