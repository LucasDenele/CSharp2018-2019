using JeuDeRole.Weapons.Weapons.elem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole.Player.PNJ
{
    class Monster : Player
    {

        #region Variables
  
        public Cudgel Cudgel { get; private set; }

        #endregion


        #region Constructeur

        public Monster(string NewName, int NewLifePoints, Cudgel NewCudgel) : base(NewName, NewLifePoints)
        {
            Cudgel = NewCudgel;
        }

        #endregion


        #region Methodes

        public override void Attack(Player Target)
        {
            Console.WriteLine(Name + " attack " + Target.Name);
        }


        public override void TakeDamages(Player source)
        {
            Console.WriteLine(Name + " is attacked by" + source.Name);
        }


        public void Eat()
        {
            Console.WriteLine(Name + "eat. His life points are increase!");
        }

        #endregion

    }
}
