using Assets.Custom.Scripts.FootballLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    
    public class GameManager : MonoBehaviour
    {
        #region Fields
        private Vector3 ballPosition;

        private float fieldWidth = 65;

        private float fieldLength = 138;

        private Formation _formation;

        private List<Player> players;

        private List<OffensivePlayer> _offensivePlayers;

        private bool coachMode;

        private static GameManager _instance;
        #endregion

        #region Properties
        public Vector3 BallPosition
        {
            get { return ballPosition; }
            set { ballPosition = value; }
        }

        public float FieldWidth
        {
            get { return fieldWidth; }
            set
            {
                fieldWidth = value;
            }
        }

        public float FieldLength
        {
            get { return fieldLength; }
            set
            {
                fieldLength = value;
            }
        }

        public Formation _Formation
        {
            get { return _formation; }
            set { _formation = value; }
        }

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public List<OffensivePlayer> _OffensivePlayers
        {
            get { return _offensivePlayers; }
            set { _offensivePlayers = value; }
        }

        public bool CoachMode
        {
            get { return coachMode; }
            set { coachMode = value; }
        }

        public static GameManager Instance 
        {
            get 
            {
                return _instance;
            }
                
            private set
            {
                _instance = value;
            }
        }
        #endregion

        #region Methods

        private void Awake()
        {
            if(Instance != null && Instance != this)
            {
                Destroy(this.gameObject);
            } else
            {
                DontDestroyOnLoad(gameObject);
                this._Formation = new Formation_442(); // izvuci podatak pomocu serijalizacije ili uz pomoc PlayerPrefs                
                Instance = this;
                this._Formation.UpdatePlayers();
                CreateOffensivePlayers();
            }
        }

        private void CreateOffensivePlayers()
        {
            this._OffensivePlayers = new List<OffensivePlayer>();

            for (int i = 0; i < 7; ++i)
            {
                this._OffensivePlayers.Add(new OffensivePlayer());
            }
        }

        #endregion
    }
}
