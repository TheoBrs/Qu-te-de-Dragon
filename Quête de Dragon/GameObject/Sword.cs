namespace Quête_de_Dragon
{
    public class Sword : GameObject
    {
        //ItemData _itemData;

        public override ItemData Data { get /*=> _itemData*/; set /*=> _itemData = value*/; }
        //public new virtual ItemData Data => _itemData;

        public Sword()
        {
            Data = new ItemData()
            {
                _gameId = 1,
                _type = "sword",
                _name = "Beginner sword",
                _stat =
                {
                    _atk = 5,
                },
            };
        }
    }
}