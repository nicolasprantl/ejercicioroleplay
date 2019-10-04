namespace RoleplayGame.Items
{
    /// <summary>
    /// Coraza. Permite defender.
    /// </summary>
    public class Coraza : IDefenseItem
    {

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}