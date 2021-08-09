﻿using Assets.Custom.Scripts.FootballLogic;
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
            player = new Player(new Vector3(40.3f, 2.8f, 52.8f));
            manager.Players.Add(player);

            //left defensive midfielder
            player = new Player(new Vector3(25f, 2.8f, 52f));
            manager.Players.Add(player);

            //right wing
            player = new Player(new Vector3(55.1f, 2.8f, 63.9f));
            manager.Players.Add(player);

            //left wing
            player = new Player(new Vector3(8.5f, 2.8f, 65.1f));
            manager.Players.Add(player);

            //left striker
            player = new Player(new Vector3(27.8f, 2.8f, 71.6f));
            manager.Players.Add(player);

            //right striker
            player = new Player(new Vector3(34.9f, 2.8f, 79.2f));
            manager.Players.Add(player);
        }
    }
}
