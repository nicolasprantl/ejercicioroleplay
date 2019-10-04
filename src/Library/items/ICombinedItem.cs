using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public interface ICombinedItem: IItem
    {
        List<IItem> items{ get;}
        void AddItem
        {
        }
    }
}