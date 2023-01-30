using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Player : GameObject
    {
        Inventory _playerInventory;
        public override ItemData Data { get /*=> _itemData*/; set /*=> _itemData = value*/; }

        public Inventory INVENTORY { get => _playerInventory; }

        public Player()
        {
            _playerInventory = new Inventory();

            Data = new ItemData
            {
                _gameId = 0,
                _itemCount = 0,
                _stat =
                {
                    _pv = 100,
                    _pvMax = 100,
                    _pm = 120,
                    _pmMax = 120,
                    _atk =5,
                    _atkMag = 3,
                    _def = 5,
                    _defMag = 0,
                    _vit = 7,
                },
            };
        }

        public Player(string name)
        {
            _playerInventory = new Inventory();

            Data = new ItemData
            {
                _gameId = 0,
                _itemCount = 0,
                _name = name,
                _stat =
                {
                    _pv = 100,
                    _pvMax = 100,
                    _pm = 120,
                    _pmMax = 120,
                    _atk =5,
                    _atkMag = 3,
                    _def = 5,
                    _defMag = 0,
                    _vit = 7,
                },
            };
        }
    }
}