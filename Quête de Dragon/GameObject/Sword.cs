namespace Quête_de_Dragon
{
    public class Sword : GameObject
    {
        //ItemData _itemData;

        //public override ItemData Data { get /*=> _itemData*/; set /*=> _itemData = value*/; }
        //public new virtual ItemData Data => _itemData;

        public Sword()
        {
            /*Data = new ItemData
            {
                _gameId = 1,
                _type = "sword",
                _name = "Beginner sword",
                _stat =
                {
                    _atk = 5,
                },
            };*/
            IntData.Add("id", 1);
            StringData.Add("name", "Sword");
            StringData.Add("type", "sword");
            IntData.Add("itemCount", 1);
            IntData.Add("isStackable", 0);
            IntData.Add("lvl", 0);
            IntData.Add("atk", 20);
        }
    }
}