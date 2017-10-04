using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ninetales = new ElementalCard("Ninetales", "Fire", "", 73, 76, 75, 81, 100, 100);
            var Blastoise = new ElementalCard("Blastoise", "Water", "", 79, 83, 100, 85, 105, 78);
            var Venasaur = new ElementalCard("Venasaur", "Grass", "Poison", 80, 82, 83, 100, 100, 80);
            var Gengar = new ElementalCard("Gengar", "Ghost", "Poison", 60, 65, 60, 130, 75, 110);
            var Dragonite = new ElementalCard("Dragonite", "Flying", "Dragon", 61, 84, 65, 70, 70, 70);
            var Articuno = new ElementalCard("Articuno", "Ice", "Flying", 90, 85, 100, 95, 125, 85);
            var Raichu = new ElementalCard("Raichu", "Electric", "", 60, 90, 55, 90, 80, 100);
            var Snorlax = new ElementalCard("Snorlax", "Normal", "", 160, 110, 65, 65, 110, 30);
            var Machamp = new ElementalCard("Machamp", "Fighting", "", 90, 130, 80, 65, 85, 55);
            var Golem = new ElementalCard("Golem", "Ground", "Rock", 80, 110, 130, 55, 65, 45);
            var Mewtwo = new ElementalCard("Mewtwo", "Psychic", "", 106, 110, 90, 154, 90, 130);
        }
    }
}