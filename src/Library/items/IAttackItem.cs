namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear elementos de ataque.
    /// </summary>
    public interface IAttackItem: IItem
    {
        int AttackPower{ get; }
    }
}