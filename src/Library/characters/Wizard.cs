using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Mago
    /// </summary>
    public class Wizard: Character
    {
        public Wizard(string name)
            : base(name)
        {
            this.Health = 80;
            this.AddItem(new Magic());
        }
    }
}