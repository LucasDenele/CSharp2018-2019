using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole.Weapons.Weapons.elem
{
    public class Cudgel : Weapon
    {
        #region Variables
        public double Weight { get; private set; }
        #endregion

        #region Constructor
        public Cudgel(string NewName, int NewDamages, double NewWeight) : base(NewName, NewDamages)
        {
            this.Weight = NewWeight;
        }
        #endregion
    }
}
