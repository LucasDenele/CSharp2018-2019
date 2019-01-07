using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole.Player
{
    abstract class Player
    {
        #region Variables
        public int PositionY { get; private set; }
        public int PositionX { get; private set; }

        public string Name { get; private set; }

        public int LifePoints { get; private set; }
        #endregion


        #region Constructor
        public Player(string NewName, int NewLifePoints)
        {
            this.Name = NewName;
            this.LifePoints = NewLifePoints;
        }
        #endregion


        #region Methodes
        public void setPosition(int NewPositionX, int NewPositionY)
        {
            this.PositionX = NewPositionX;
            this.PositionY = NewPositionY;
        }
        
        public virtual void Attack(Player Target)
        {
            Target.TakeDamages(this);
        }
        
        public abstract void TakeDamages(Player source);
        #endregion

    }
}
