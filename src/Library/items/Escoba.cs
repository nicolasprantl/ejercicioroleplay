namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo de escoba. Permite atacar.
    /// </summary>
    public class Escoba : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }
        public override string ToString()
        {
            return "Escoba";
        }
    }
}