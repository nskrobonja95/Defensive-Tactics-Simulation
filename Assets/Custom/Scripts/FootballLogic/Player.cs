using UnityEngine;

namespace Assets.Custom.Scripts.FootballLogic
{
    public class Player
    {
        #region Fields

        private Vector3 homePosition;

        #endregion

        #region Properties

        public Vector3 HomePosition
        {
            get { return homePosition; }
            set { homePosition = value; }
        }

        #endregion

        #region Constructors

        public Player() { }

        public Player(Vector3 position)
        {
            this.HomePosition = position;
        }

        #endregion
    }
}