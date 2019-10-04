namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo de escoba. Permite atacar.
    /// </summary>
    public class Paleta : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 100;
            }
        }
        public override string ToString()
        {
            return "Paleta";
        }
    }
}