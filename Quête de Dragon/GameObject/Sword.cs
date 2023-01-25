using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Sword : GameObject
    {
        ItemData _itemData;
        public override ItemData Data => _itemData;

        public Sword()
        {
            _itemData = new ItemData()
            {
                gameId = 1,
                name = "Sword",
                stat =
                {
                    atk = 5,
                    def = 5,
                },
            };
        }


    }
}