using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class GameEngine
    {
        private Map gameMap;
        public Map GameMap
        {
            get { return gameMap; }
        }

        public GaneEngine(Map map) // 3.3 ?????
        {
            gameMap = map;

            public bool MovePlayer(MovementEnum direction);
        }
    }
}
