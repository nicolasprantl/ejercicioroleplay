using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Orco
    /// </summary>
    public class Orco : Character
    {
        public Orco(string name)
            : base(name)
        {
            this.Health = 200;
            this.AddItem(new Coraza());
            this.AddItem(new Palo());
        }
    }
}