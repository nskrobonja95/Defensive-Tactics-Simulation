using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.Movements;
using Assets.Custom.Scripts.Movements.Formation_433;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    class Formation_442 : Formation
    {
        public Formation_442()
        {
            this.FormationCode = "4-4-2";
            this.Diamond = false;
        }

        public override void UpdatePlayerMovementScripts()
        {
            GameManager manager = GameManager.Instance;
            manager.DefensivePlayersAsGameObjects[0].AddComponent<LeftBackMovement>();
            manager.DefensivePlayersAsGameObjects[1].AddComponent<LeftCentralBackMovement>();
            manager.DefensivePlayersAsGameObjects[2].AddComponent<RightCentralBackMovement>();
            manager.DefensivePlayersAsGameObjects[3].AddComponent<RightBackMovement>();
            manager.DefensivePlayersAsGameObjects[4].AddComponent<RightDefensiveMidfielderMovement>();
            manager.DefensivePlayersAsGameObjects[5].AddComponent<LeftDefensiveMidfielderMovement>();
            manager.DefensivePlayersAsGameObjects[6].AddComponent<RightWingMovement>();
            manager.DefensivePlayersAsGameObjects[7].AddComponent<LeftWingMovement>();
            manager.DefensivePlayersAsGameObjects[8].AddComponent<LeftStrikerMovement>();
            manager.DefensivePlayersAsGameObjects[9].AddComponent<RightStrikerMovement>();            
        }

        public override void UpdatePlayerPositions()
        {
            GameManager manager = GameManager.Instance;
            OffensivePlayer playerWithBall;
            for (int i = 0; i < manager._OffensivePlayers.Count; ++i)
            {
                if (manager._OffensivePlayers[i].InBallPossesion)
                {
                    playerWithBall = manager._OffensivePlayers[i];
                    break;
                }
            }

        }

        public override void UpdatePlayers()
        {
            GameManager manager = GameManager.Instance;

            manager.Players = new List<Player>();
            //left back
            Player player = new Player(new Vector3(8.2f, 2.8f, 46.1f));
            player.PositionName = "LB";
            manager.Players.Add(player);

            //left cb
            player = new Player(new Vector3(25f, 2.8f, 31.3f));
            player.PositionName = "LCB";
            manager.Players.Add(player);

            //right cb
            player = new Player(new Vector3(40f, 2.8f, 31.3f));
            player.PositionName = "RCB";
            manager.Players.Add(player);

            //right back
            player = new Player(new Vector3(55f, 2.8f, 41.3f));
            player.PositionName = "RB";
            manager.Players.Add(player);

            //right defensive midfielder
            player = new Player(new Vector3(40.3f, 2.8f, 52.8f));
            player.PositionName = "RDMF";
            manager.Players.Add(player);

            //left defensive midfielder
            player = new Player(new Vector3(25f, 2.8f, 52f));
            player.PositionName = "LDMF";
            manager.Players.Add(player);

            //right wing
            player = new Player(new Vector3(55.1f, 2.8f, 63.9f));
            player.PositionName = "RW";
            manager.Players.Add(player);

            //left wing
            player = new Player(new Vector3(8.5f, 2.8f, 65.1f));
            player.PositionName = "LW";
            manager.Players.Add(player);

            //left striker
            player = new Player(new Vector3(27.8f, 2.8f, 71.6f));
            player.PositionName = "LF";
            manager.Players.Add(player);

            //right striker
            player = new Player(new Vector3(34.9f, 2.8f, 79.2f));
            player.PositionName = "RF";
            manager.Players.Add(player);
        }
    }
}
