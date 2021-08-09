using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Custom.Scripts
{
    public abstract class Formation
    {
        private string formationCode;

        private bool diamond;

        public string FormationCode
        {
            get
            {
                return formationCode;
            }
            set
            {
                formationCode = value;
            }
        }

        public bool Diamond
        {
            get { return diamond; }
            set { diamond = value; }
        }

        public abstract void UpdatePlayers();
    }
}
