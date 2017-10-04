using System;
namespace Pokemon 
{
	public class BaseCard 
	{
			public string Name {get; set;}
			public int HP {get; set;}
			public int Attack {get; set;}
			public int Defense {get; set;}
			public int SpAtk {get; set;}
			public int SpDef {get; set;}
			public int Speed {get; set;}
		public BaseCard(string Name, int HP, int Attack, int Defense, int SpAtk, int SpDef, int Speed)
		{
			this.Name = Name;
			this.HP = HP;
			this.Attack = Attack;
			this.Defense = Defense;
			this.SpAtk = SpAtk;
			this.SpDef = SpDef;
			this.Speed = Speed;
		}
	}
}
