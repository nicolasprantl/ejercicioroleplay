namespace RoleplayGame.Items
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
    /// </summary>
    public class Robes : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 2;
            }
        }

        public override string ToString()
        {
            return "Robes";
        }
    }
}