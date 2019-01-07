using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole.Weapons.Weapons.elem
{
    public class Sword : Weapon
    {
        #region Variables
        public double Length { get; private set; }
        #endregion

        #region Constructor
        public Sword(String Name, int Damages, double Length) : base(Name, Damages)
        {
            this.Length = Length;
        }
        #endregion
    }
}
