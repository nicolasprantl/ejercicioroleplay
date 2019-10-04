using RoleplayGame.Characters;
using RoleplayGame.Encounters;
using RoleplayGame.Items;

namespace RoleplayGame.Scenarios
{
    public class Scenario : IScenario 
    {
        public void Run()
        {

        }

        public void Setup()
        {
            Elf p1 = new Elf("Nico");
            Orco p2 = new Orco("Facundo");
            Wizard p3 = new Wizard("Maria");
            Orco p4 = new Orco("Rod");

            Gema gema = new Gema();
            Guante_de_poder guante = new Guante_de_poder();
            p1.AddItem(gema);
            p1.AddItem(guante);

            Paleta paleta = new Paleta();
            Pelota pelota = new Pelota();
            p2.AddItem(paleta);
            p2.AddItem(pelota);

            VaritaDeSauco varita = new VaritaDeSauco();
            p3.AddItem(varita);
            p3.AddItem(gema);

            chancleta chan = new chancleta();
            p4.AddItem(chan);
            p4.AddItem(chan);
        }
    }
}