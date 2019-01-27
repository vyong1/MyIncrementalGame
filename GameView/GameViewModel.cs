using GameLib;
using GameLib.IncrementingResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameView
{
    public class GameViewModel
    {
        private Player _player;
        public Player Player
        {
            get
            {
                return _player;
            }
            set
            {
                _player = value;
            }
        }

        public GameViewModel()
        {
            _player = new Player();
        }
    }
}
