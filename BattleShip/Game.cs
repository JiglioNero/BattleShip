using System;
namespace BattleShip
{

	public class Game
	{
		public const uint BattlegroundSize = 10;
		private const String WinMessage = "{0} is win!";
		private const String HitMessage = "{0} hit the ship of {1}";
		private const String KillMessage = "{0} kill the ship of {1}";
		private const String MissMessage = "{0} miss";
		private const String TurnMessage = "Now is {0} turn!";

		private Player player1;
		private Player player2;

		private int[,] player1Battleground;
		private int[,] player2Battleground;

		public Game()
		{
			player1 = new Player("Player 1");
			player2 = new Player("Player 2");

			Random random = new Random();
			player1.SetUpBattleground(BattlegroundConfig.mockSet1[random.Next(0, 2)]);
			player2.SetUpBattleground(BattlegroundConfig.mockSet2[random.Next(0, 2)]);

			player1Battleground = new int[BattlegroundSize, BattlegroundSize];
			player2Battleground = new int[BattlegroundSize, BattlegroundSize];
			for (int i = 0; i < BattlegroundSize; i++)
			{
				for (int j = 0; j < BattlegroundSize; j++)
				{
					player1Battleground[i, j] = -1;
					player2Battleground[i, j] = -1;
				}

			}
		}

		public void GameLoop()
		{
			ActionResult actionResult;
			while (true)
			{
				actionResult = Turn(player1, player2, player2Battleground);
				if (actionResult == ActionResult.WIN)
				{
					return;
				}
				actionResult = Turn(player2, player1, player1Battleground);
				if (actionResult == ActionResult.WIN)
				{
					return;
				}
			}
		}

		private void LogAction(Player activePlayer, Player recipientPlayer, ActionResult actionResult)
		{
			if (actionResult == ActionResult.MISS)
			{
				Console.WriteLine(MissMessage, activePlayer.name);
				return;
			}
			if (actionResult >= ActionResult.HIT)
			{
				Console.WriteLine(HitMessage, activePlayer.name, recipientPlayer.name);
			}
			if (actionResult >= ActionResult.KILL)
			{
				Console.WriteLine(KillMessage, activePlayer.name, recipientPlayer.name);
			}
			if (actionResult == ActionResult.WIN)
			{
				Console.WriteLine(WinMessage, activePlayer.name);
			}
		}

		private ActionResult Turn(Player activePlayer, Player recipientPlayer, int [,] attackedBattleground)
		{
			ActionResult actionResult;

			Console.WriteLine(TurnMessage, activePlayer.name);
			do
			{
				ConsoleHelper.DrawBattlegrounds(player1Battleground, player2Battleground);
				(int, int) point = activePlayer.GetPointToShot();
				if (attackedBattleground[point.Item1, point.Item2] != -1)
				{
					Console.WriteLine("This point already attacked. Choose another one!");
					actionResult = ActionResult.HIT;
					continue;
				}
				actionResult = recipientPlayer.ShotToPoint(point);
				LogAction(activePlayer, recipientPlayer, actionResult);
				UpdateBattleground(attackedBattleground, point, actionResult);
            } while (actionResult != ActionResult.MISS && actionResult != ActionResult.WIN);

			return actionResult;
		}

		private void UpdateBattleground(int[,] battleground, (int, int) point, ActionResult actionResult)
		{
			if (actionResult == ActionResult.MISS)
			{
				battleground[point.Item1, point.Item2] = 0;
			}
			else
			{
				battleground[point.Item1, point.Item2] = 1;
			}
		}
	}
}

