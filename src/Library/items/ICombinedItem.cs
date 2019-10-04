using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public interface ICombinedItem: IItem
    {
        private string = "caca";
        protected List<IItem> items = new List<IItem>();
    }
}