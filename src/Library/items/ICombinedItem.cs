using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public interface ICombinedItem: IItem
    {
        List<IItem> Items{ get;}
        void AddItem(IItem item);
    }
}