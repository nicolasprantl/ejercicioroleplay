namespace RoleplayGame.Items
{
    /// <summary>
    /// Termo. Permite atacar.
    /// </summary>
    public class Termo : IAttackItem
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
            return "Termo";
        }
    }
}