using JeuDeRole.Player.PJ;
using JeuDeRole.Player.PNJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeRole.Game
{
    public class Game
    {

        #region Variables

        public Hero Gandalf { get; private set; }


        public Monster Uruk { get; private set; }

        #endregion  


        #region Constructor

        public Game(Hero NewGandalf, Monster NewUruk)
        {
            this.Gandalf = NewGandalf;
            this.Uruk = NewUruk;
        }

        #endregion

    }
}
