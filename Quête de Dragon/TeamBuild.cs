using System.IO;

namespace Quête_de_Dragon
{
    public class TeamBuild
    {
        Player _player1;

        Map map;

        Player _player2;

        Player _player3;

        Inventory _inventory;

        Inventory _inventoryBuffer;

        public Inventory Inventory { get => _inventory; set => _inventory = value; }

        public Inventory InventoryBuffer { get => _inventoryBuffer; }

        public Player Player1 { get => _player1; }

        public Player Player2 { get => _player2; }

        public Player Player3 { get => _player3; }

        public TeamBuild()
        {
            _player1 = new Player("name1");
            _player2 = new Player("name2");
            _player3 = new Player("name3");
            _inventory = new Inventory();
            _inventoryBuffer = new Inventory();
        }

        public void DrawMenu()
        {
            
        }

        public void GetPersoStats()
        {
            throw new System.NotImplementedException();
        }

        public void SetPersoObject()
        {
            throw new System.NotImplementedException();
        }

        public void UseObject()
        {
            throw new System.NotImplementedException();
        }

        public void SetPersoAttack()
        {
            throw new System.NotImplementedException();
        }

        public void PlayerEarnsExp(int monsterExp)
        {
            _player1.Exp += monsterExp;
            _player2.Exp += monsterExp;
            _player3.Exp += monsterExp;
        }

        public void LevelUp()
        {
            if(_player1.Exp >= 10 & _player1.Lvl == 1 || _player1.Exp >= 30 & _player1.Lvl == 2 || _player1.Exp >= 55 & _player1.Lvl == 3 || _player1.Exp >= 85 & _player1.Lvl == 4
                || _player1.Exp >= 120 & _player1.Lvl == 5 || _player1.Exp >= 160 & _player1.Lvl == 6 || _player1.Exp >= 210 & _player1.Lvl == 7 || _player1.Exp >= 265 & _player1.Lvl == 8
                || _player1.Exp >= 325 & _player1.Lvl == 9)
            {
                map.writeText(_player1.Name + " est monté de niveau !");
                _player1.Lvl += 1;
                _player1.HpMax += 4;
                _player1.MpMax += 1;
                _player1.Atk += 3;
                _player1.Def += 3;
                _player1.Vit += 1;
            }
            if (_player2.Exp >= 10 & _player2.Lvl == 1 || _player2.Exp >= 30 & _player2.Lvl == 2 || _player2.Exp >= 55 & _player2.Lvl == 3 || _player2.Exp >= 85 & _player2.Lvl == 4
                || _player2.Exp >= 120 & _player2.Lvl == 5 || _player2.Exp >= 160 & _player2.Lvl == 6 || _player2.Exp >= 210 & _player2.Lvl == 7 || _player2.Exp >= 265 & _player2.Lvl == 8
                || _player2.Exp >= 325 & _player2.Lvl == 9)
            {
                map.writeText(_player2.Name + " est monté de niveau !");
                _player2.Lvl += 1;
                _player2.HpMax += 2;
                _player2.MpMax += 3;
                _player2.Atk += 1;
                _player2.AtkMag += 3;
                _player2.Def += 1;
                _player2.Vit += 3;
            }
            if (_player3.Exp >= 10 & _player3.Lvl == 1 || _player3.Exp >= 30 & _player3.Lvl == 2 || _player3.Exp >= 55 & _player3.Lvl == 3 || _player3.Exp >= 85 & _player3.Lvl == 4
                || _player3.Exp >= 120 & _player3.Lvl == 5 || _player3.Exp >= 160 & _player3.Lvl == 6 || _player3.Exp >= 210 & _player3.Lvl == 7 || _player3.Exp >= 265 & _player3.Lvl == 8
                || _player3.Exp >= 325 & _player3.Lvl == 9)
            {
                map.writeText(_player3.Name + " est monté de niveau !");
                _player3.Lvl += 1;
                _player3.HpMax += 3;
                _player3.MpMax += 4;
                _player3.Atk += 2;
                _player3.Def += 2;
                _player3.Vit += 2;
            }
        }
    }
}