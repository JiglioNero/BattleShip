using System;
namespace BattleShip
{
    public class BattlegroundConfig: Dictionary<Ship, List<(int, int)>>
    {
        public static BattlegroundConfig[] mockSet1 = new BattlegroundConfig[3];
        public static BattlegroundConfig[] mockSet2 = new BattlegroundConfig[3];

        static BattlegroundConfig()
        {
            BattlegroundConfig mock1 = new BattlegroundConfig
            {
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (0, 0) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (1, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (3, 6) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (7, 0) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (0, 3), (0, 4) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (2, 2), (2, 3) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (9, 1), (9, 2) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (4, 4), (5, 4), (6, 4) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (5, 9), (6, 9), (7, 9) }
                },

                { new Ship(ShipType.BATTLESHIP), new List<(int, int)> { (8, 4), (8, 5), (8, 6), (8, 7) } }
            };

            BattlegroundConfig mock2 = new BattlegroundConfig
            {
                {
                    new Ship(ShipType.BATTLESHIP),
                    new List<(int, int)> { (0, 0), (0, 1), (0, 2), (0, 3) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (2, 1), (2, 2), (2, 3) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (5, 6), (5, 7), (5, 8) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (4, 0), (4, 1) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (7, 0), (7, 1) }
                },

                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (9, 7), (9, 8) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (1, 7) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (3, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (8, 4) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (9, 0) }
                }
            };

            BattlegroundConfig mock3 = new BattlegroundConfig
            {
                {
                    new Ship(ShipType.BATTLESHIP),
                    new List<(int, int)> { (1, 9), (2, 9), (3, 9), (4, 9) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (0, 0), (0, 1), (0, 2) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (7, 5), (7, 6), (7, 7) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (2, 0), (2, 1) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (5, 0), (6, 0) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (9, 0), (9, 1) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (0, 5) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (3, 6) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (6, 3) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (9, 4) }
                }
            };

            BattlegroundConfig mock4 = new BattlegroundConfig
            {
                {
                    new Ship(ShipType.BATTLESHIP),
                    new List<(int, int)> { (9, 2), (9, 3), (9, 4), (9, 5) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (0, 0), (1, 0), (2, 0) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (0, 7), (1, 7), (2, 7) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (4, 2), (4, 3) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (6, 0), (7, 0) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (7, 9), (8, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (3, 5) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (5, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (8, 2) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (9, 8) }
                }
            };

            BattlegroundConfig mock5 = new BattlegroundConfig
            {

                {
                    new Ship(ShipType.BATTLESHIP),
                    new List<(int, int)> { (0, 0), (1, 0), (2, 0), (3, 0) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (0, 5), (0, 6), (0, 7) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (5, 4), (5, 5), (5, 6) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (2, 9), (3, 9) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (6, 7), (7, 7) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (8, 2), (8, 3) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (4, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (3, 5) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (7, 0) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (9, 9) }
                }
            };

            BattlegroundConfig mock6 = new BattlegroundConfig
            {
                {
                    new Ship(ShipType.BATTLESHIP),
                    new List<(int, int)> { (4, 3), (4, 4), (4, 5), (4, 6) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (0, 0), (1, 0), (2, 0) }
                },
                {
                    new Ship(ShipType.CRUISER),
                    new List<(int, int)> { (0, 9), (1, 9), (2, 9) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (7, 0), (7, 1) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (8, 7), (8, 8) }
                },
                {
                    new Ship(ShipType.DESTROYER),
                    new List<(int, int)> { (9, 3), (9, 4) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (3, 6) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (6, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (9, 9) }
                },
                {
                    new Ship(ShipType.BOAT),
                    new List<(int, int)> { (2, 4) }
                }
            };

            mockSet1[0] = mock1;
            mockSet1[1] = mock2;
            mockSet1[2] = mock3;

            mockSet2[0] = mock4;
            mockSet2[1] = mock5;
            mockSet2[2] = mock6;
        }
    }
}

