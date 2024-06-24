using Google.Protobuf.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    public class Item : GameObject
    {
        public ItemInfo itemInfo { get; private set; } = new ItemInfo();

        public Item()
        {
            ObjectType = GameObjectType.Item;
        }

        public void ItemEffect()
        {

        }
    }
}
