using RoleplayGame.Characters;
using System;

namespace RoleplayGame.Encounters
{
    /// <summary>
    /// Encuentro de Ataque entre dos personajes
    /// </summary>
    public class AttackEncounter : Encounter
    {
        public AttackEncounter(Character one, Character two)
            : base(one, two)
        {
        }

        /// <summary>
        /// Ejecución del encuentro.
        /// 
        /// El personaje 1 atacará al personaje 2. Si el personaje 2
        /// continúa vivo luego de recibir el ataque, éste atacará al
        /// personaje 1. 
        /// Seguirán atacandose hasta que uno de los dos no tenga más vida.
        /// </summary>
        public override void DoEncounter()
        {
            while (this.BothAlive)
            {
                this.Character2.ReceiveAttack(this.Character1.AttackPower);
                this.Reporter.ReportAttack(Character1, Character2);

                if (!this.Character2.IsDead)
                {
                    this.Character1.ReceiveAttack(this.Character2.AttackPower);
                    this.Reporter.ReportAttack(Character2, Character1);
                }
                else
                {
                    this.Reporter.ReportDead(this.Character2);
                }
            }
            if (this.Character1.IsDead)
            {
                this.Reporter.ReportDead(this.Character1);
            }
        }

        /// <summary>
        /// Retorna verdadero si ambos personajes están vivos.
        /// </summary>
        /// <value></value>
        protected bool BothAlive
        {
            get
            {
                return !this.Character1.IsDead && !this.Character2.IsDead;
            }
        }

        public override string ToString()
        {
            return $"{Character1.Name}: {Character1.Health} / {Character2.Name}: {Character2.Health}";
        }
    }
}