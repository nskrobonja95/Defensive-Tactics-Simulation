using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Custom.Scripts.Controllers
{
    public class OffensivePlayerController : MonoBehaviour
    {
        public GameObject ballObj;

        private GameManager _gameManager;

        private GameObject[] offensePlayers;

        private void Start()
        {
            _gameManager = GameManager.Instance;
            offensePlayers = GameObject.FindGameObjectsWithTag("OffensivePlayer");
            GameObject rb_offense = GameObject.Find("RightBack_Offense");
            GameObject rw_offense = GameObject.Find("RightWing_Offense");
            GameObject cmf_offense = GameObject.Find("CentralMidfielder_Offense");
            GameObject lcb_offense = GameObject.Find("LeftCB_Offense");
            GameObject rcb_offense = GameObject.Find("RightCB_Offense");
            GameObject lb_offense = GameObject.Find("LeftBack_Offense");
            GameObject lw_offense = GameObject.Find("LeftWing_Offense");
            _gameManager._OffensivePlayers[0].Position = rb_offense.transform.position;
            _gameManager._OffensivePlayers[1].Position = rcb_offense.transform.position;
            _gameManager._OffensivePlayers[2].Position = lcb_offense.transform.position;
            _gameManager._OffensivePlayers[3].Position = lb_offense.transform.position;
            _gameManager._OffensivePlayers[4].Position = rw_offense.transform.position;
            _gameManager._OffensivePlayers[5].Position = cmf_offense.transform.position;
            _gameManager._OffensivePlayers[6].Position = lw_offense.transform.position;
            InitialiseInBallPossesion();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                PassBall();
            }
        }

        private void InitialiseInBallPossesion()
        {
            for (int i=0; i<_gameManager._OffensivePlayers.Count; ++i)
            {
                //_gameManager._OffensivePlayers[i].Position= offensePlayers[i].transform.position;
                if (Vector3.Distance(ballObj.transform.position, _gameManager._OffensivePlayers[i].Position) < 5.0f)
                    _gameManager._OffensivePlayers[i].InBallPossesion = true;
                else
                    _gameManager._OffensivePlayers[i].InBallPossesion = false;
            }
        }

        public void PassBall() //ideja za dalje: dozvoliti korisniku da odabere igraca kojem ce dodati
        {
            System.Random random = new System.Random();
            int idxOfPlayerInBallPosession = -1;
            int idx = -1;

            for (int i = 0; i < _gameManager._OffensivePlayers.Count; ++i)
            {
                if (_gameManager._OffensivePlayers[i].InBallPossesion)
                    idxOfPlayerInBallPosession = i;
            }

            do {
                idx = random.Next(0, _gameManager._OffensivePlayers.Count);
            } while (idx == idxOfPlayerInBallPosession);

            _gameManager._OffensivePlayers[idxOfPlayerInBallPosession].InBallPossesion = false;
            _gameManager._OffensivePlayers[idx].InBallPossesion = true;

            _gameManager.BallPosition = new Vector3(
                _gameManager._OffensivePlayers[idx].Position.x,
                ballObj.transform.position.y,
                _gameManager._OffensivePlayers[idx].Position.z - 3.15f);

        }

    }
}
