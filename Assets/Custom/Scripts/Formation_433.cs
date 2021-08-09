using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    class Formation_433 : Formation
    {

        public Formation_433()
        {
            this.FormationCode = "4-3-3";
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

            //defensive midfielder
            player = new Player(new Vector3(35.3f, 2.8f, 52.8f));
            manager.Players.Add(player);

            //left midfielder
            player = new Player(new Vector3(22f, 2.8f, 61f));
            manager.Players.Add(player);

            //right midfielder
            player = new Player(new Vector3(48.1f, 2.8f, 61f));
            manager.Players.Add(player);

            //left offensive player
            player = new Player(new Vector3(23.5f, 2.8f, 80.1f));
            manager.Players.Add(player);

            //right offensive player
            player = new Player(new Vector3(45.8f, 2.8f, 80.1f));
            manager.Players.Add(player);

            //striker
            player = new Player(new Vector3(34.9f, 2.8f, 87.2f));
            manager.Players.Add(player);
        }
    }
}
