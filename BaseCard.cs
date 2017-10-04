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
        public int CalculateAttack(BaseCard defender, BaseAttack attack)
        {
            return 0;
        }
       
	}
    public class BaseAttack{
            public string Name {get; set;}
            public string Type {get; set;}
            public string Category {get; set;}
            public string Contest {get; set;}
            public int PP {get; set;}
            public int Power {get; set;}
            public int Accuracy {get; set;}
            public string Gen {get; set;}

public BaseAttack(string Name, string Type, string Category, string Contest, string PP, string Power, string Accuracy, string Gen)
{
    int number;
    this.Name = Name;
    this.Type = Type;
    this.Category = Category;
    this.Contest = Contest;
    this.PP = 0;
    if (Int32.TryParse(PP, out number))
        this.PP = number; 
    this.Power = 0;
    if (Int32.TryParse(Power, out number))
        this.Power = number; 
    this.Accuracy = 0;
    if (Int32.TryParse(Accuracy, out number))
        this.Accuracy = number; 
    this.Gen = Gen;
}
    
        }
}
