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

        private List<GameObject> defensivePlayersAsGameObjects;

        private List<OffensivePlayer> _offensivePlayers;

        private bool coachMode;

        private PlayerKit selectedHomeKit;

        private PlayerKit selectedAwayKit;

        private int selectedHomeKitIndex;

        private int selectedAwayKitIndex;

        private int numOfKits;

        private Color[,] availableHomeKits;

        private Color[,] availableAwayKits;

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

        public List<GameObject> DefensivePlayersAsGameObjects
        {
            get { return defensivePlayersAsGameObjects; }
            set { defensivePlayersAsGameObjects = value; }
        }
        public List<OffensivePlayer> _OffensivePlayers
        {
            get { return _offensivePlayers; }
            set { _offensivePlayers = value; }
        }

        public Color[,] AvailableHomeKits
        {
            get { return availableHomeKits; }
            set { availableHomeKits = value; }
        }

        public Color[,] AvailableAwayKits
        {
            get { return availableAwayKits; }
            set { availableAwayKits = value; }
        }

        public int SelectedHomeKitIndex
        {
            get { return selectedHomeKitIndex; }
            set { selectedHomeKitIndex = value; }
        }

        public int SelectedAwayKitIndex
        {
            get { return selectedAwayKitIndex; }
            set { selectedAwayKitIndex = value; }
        }

        public int NumOfKits
        {
            get { return numOfKits; }
            set { numOfKits = value; }
        }

        public bool CoachMode
        {
            get { return coachMode; }
            set { coachMode = value; }
        }

        public PlayerKit SelectedHomeKit
        {
            get { return selectedHomeKit; }
            set { selectedHomeKit = value; }
        }

        public PlayerKit SelectedAwayKit
        {
            get { return selectedAwayKit; }
            set { selectedAwayKit = value; }
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
                this.AvailableHomeKits = new Color[3, 2];
                this.AvailableHomeKits[0, 0] = new Color(1.0f, 0.0f, 0.0f);
                this.AvailableHomeKits[0, 1] = new Color(1.0f, 1.0f, 1.0f);
                this.AvailableHomeKits[1, 0] = new Color(0.003f, 0.799f, 0.799f);
                this.AvailableHomeKits[1, 1] = new Color(0f, 0f, 0f);
                this.AvailableHomeKits[2, 0] = new Color(0f, 0f, 1f);
                this.AvailableHomeKits[2, 1] = new Color(1f, 1f, 0f);
                this.AvailableAwayKits = new Color[3, 2];
                this.AvailableAwayKits[0, 0] = new Color(0.0f, 1.0f, 0.0f);
                this.AvailableAwayKits[0, 1] = new Color(1.0f, 1.0f, 1.0f);
                this.AvailableAwayKits[1, 0] = new Color(1f, 1f, 1f);
                this.AvailableAwayKits[1, 1] = new Color(0f, 0f, 0f);
                this.AvailableAwayKits[2, 0] = new Color(1f, 0.2f, 0.012f);
                this.AvailableAwayKits[2, 1] = new Color(0f, 0f, 0f);
                this.NumOfKits = 3;
                this.SelectedHomeKitIndex = 0;
                this.SelectedAwayKitIndex = 0;
                this.SelectedAwayKit = new PlayerKit(AvailableAwayKits[selectedAwayKitIndex,0], AvailableAwayKits[selectedAwayKitIndex,1]);
                this.SelectedHomeKit = new PlayerKit(AvailableHomeKits[selectedHomeKitIndex, 0], AvailableHomeKits[selectedHomeKitIndex, 1]);
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
