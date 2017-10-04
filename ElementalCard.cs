using System;
using System.Collections.Generic;

namespace Pokemon 
{
    public class ElementalCard : BaseCard
    {
        private List<string> ElementTypes;
        public string Element1 {get;set;}
        public string Element2 {get;set;}
        // bool validateElement(string e)
        // {
        //     //Generation1 
        //     return  ElementTypes.Contains(e);
        // }
        // public string Element1 { 
        //     get {return Element1;} 
        //     set {  
        //         if (validateElement(value) ) {
        //             Element1 = value;
        //         } else {
        //             throw new Exception("Please set the correct element type for this object.");
        //         }
        //     }
        // }
        // public string Element2 {             
        //     get {return Element2;} 
        //     set {  
        //         if (validateElement(value) ) {
        //             Element2 = value;
        //         } else {
        //             throw new Exception("Please set the correct element type for this object.");
        //         }
        //     }
        // }

        public ElementalCard(string Name, string Element1, string Element2, int HP, int Attack, int Defense, int SpAtk, int SpDef, int Speed) 
        : base(Name, HP, Attack, Defense, SpAtk, SpDef, Speed)
        {
            ElementTypes = new List<string>() {"Fire", "Water", "Grass", "Electric", "Psychic", "Ice", "Dragon", "Normal", "Fighting", "Flying", "Posion", "Ground", "Rock", "Bug", "Ghost", ""};

            this.Element1 = Element1;
            this.Element2 = Element2;
        }
    }
}