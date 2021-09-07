using Assets.Custom.Scripts.FootballLogic;
using Assets.Custom.Scripts.Movements;
using Assets.Custom.Scripts.Movements.Formation_4321;
using Assets.Custom.Scripts.Movements.Formation_433;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    class Formation_4231 : Formation
    {
        public Formation_4231()
        {
            this.FormationCode = "4-2-3-1";
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
            manager.DefensivePlayersAsGameObjects[8].AddComponent<HalfStriker_4231>();
            manager.DefensivePlayersAsGameObjects[9].AddComponent<HalfStriker_4231>();
        }

        public override void UpdatePlayerPositions()
        {
            throw new NotImplementedException();
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
            player = new Player(new Vector3(40f, 2.8f, 57.8f));
            player.PositionName = "RDMF";
            manager.Players.Add(player);

            //left defensive midfielder
            player = new Player(new Vector3(25f, 2.8f, 57.8f));
            player.PositionName = "LDMF";
            manager.Players.Add(player);

            //right offensive midfielder
            player = new Player(new Vector3(58.1f, 2.8f, 75f));
            player.PositionName = "RW";
            manager.Players.Add(player);

            //left offensive midfielder
            player = new Player(new Vector3(5.5f, 2.8f, 75f));
            player.PositionName = "LW";
            manager.Players.Add(player);

            //half striker
            player = new Player(new Vector3(34.8f, 2.8f, 82.1f));
            player.PositionName = "HS";
            manager.Players.Add(player);

            //striker
            player = new Player(new Vector3(34.9f, 2.8f, 95.2f));
            player.PositionName = "CF";
            manager.Players.Add(player);
        }
    }
}
