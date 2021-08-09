using Assets.Custom.Scripts.FootballLogic;
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

        public override void UpdatePlayers()
        {
            GameManager manager = GameManager.Instance;

            manager.Players = new List<Player>();
            //left back
            Player player = new Player(new Vector3(8.2f, 2.8f, 46.1f));
            manager.Players.Add(player);

            //left cb
            player = new Player(new Vector3(25f, 2.8f, 31.3f));
            manager.Players.Add(player);

            //right cb
            player = new Player(new Vector3(40f, 2.8f, 31.3f));
            manager.Players.Add(player);

            //right back
            player = new Player(new Vector3(55f, 2.8f, 41.3f));
            manager.Players.Add(player);

            //right defensive midfielder
            player = new Player(new Vector3(40f, 2.8f, 57.8f));
            manager.Players.Add(player);

            //left defensive midfielder
            player = new Player(new Vector3(25f, 2.8f, 57.8f));
            manager.Players.Add(player);

            //right offensive midfielder
            player = new Player(new Vector3(58.1f, 2.8f, 75f));
            manager.Players.Add(player);

            //left offensive midfielder
            player = new Player(new Vector3(5.5f, 2.8f, 75f));
            manager.Players.Add(player);

            //half striker
            player = new Player(new Vector3(34.8f, 2.8f, 82.1f));
            manager.Players.Add(player);

            //striker
            player = new Player(new Vector3(34.9f, 2.8f, 95.2f));
            manager.Players.Add(player);
        }
    }
}
