namespace RoleplayGame.Items
{
    /// <summary>
    /// Pelota. Permite atacar.
    /// </summary>
    public class Pelota : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 52;
            }
        }
        
        public override string ToString()
        {
            return "Pelota";
        }
    }
}