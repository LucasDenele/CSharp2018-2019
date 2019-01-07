using JeuDeRole.Weapons.Weapons.elem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole.Player.PJ
{
    class Hero : Player

    {

        #region Proprietes

        public Sword Sword { get; private set; }

        #endregion


        #region Constructeur

        public Hero(string NewName, int NewLifePoints, Sword NewSword) : base(NewName, NewLifePoints)
        {
            Sword = NewSword;
        }

        #endregion


        #region Methodes

        public override void Attack(Player Target)
        {
            base.Attack(Target);
            Console.WriteLine("The hero " + Name + " attack " + Target.Name);
        }


        public override void TakeDamages(Player source)
        {
            Console.WriteLine(Name + " is attacked by " + source.Name);
        }


        public void MakeGoodAction()
        {
            Console.WriteLine(Name + " make a good action. His life points are increase! ");
        }

        #endregion

    }
}
