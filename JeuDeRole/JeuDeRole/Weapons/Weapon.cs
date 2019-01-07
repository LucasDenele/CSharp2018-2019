using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole
{
    public abstract class Weapon
    {
        #region Variables
        public string Name { get; private set;}

        public int Damages { get; private set; }
        #endregion

        #region Constructor
        public Weapon(String NewName, int NewDamages)
        {
            this.Name = NewName;
            this.Damages = NewDamages;
        }
        #endregion
    }
}
