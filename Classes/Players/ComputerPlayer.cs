namespace TheUncodedOne
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(Party party) : base(party) { }
        static System.Random rng = new System.Random();

        protected override IAction PickAction(Battle battle, Character character)
        {
            // Check if we want to attack

            // If have health potions, health<50% use potion 25% of time
            float healthPercentage = (float)character.CurHealth / character.MaxHealth;
            if ( (battle.GetParty(character).Items.Count>0)&& (healthPercentage < .5) && rng.Next(4)==0)
            {
                return new ItemAction(battle.GetParty(character).Items[0]);
            }
            // If no gear equipped and gear is available, equip gear 50% of time
            else if (character.EquippedGear == null && battle.GetParty(character).Gear.Count>0 && rng.Next(1)==0 )
            {
                return new GearAction(battle.GetParty(character).Gear[0]);
            }
            // If gear is equipped use the Gear based attacks
            else if (character.EquippedGear != null)
            {
                return new AttackAction(character.EquippedGear.Attack, battle.GetEnemyParty(character).Members[0]);
            }
            else
            {
                return new AttackAction(character.StandardAttack, battle.GetEnemyParty(character).Members[0]);
            }
            //Default action is Do Nothing
            //return new DoNothing();
        }
    }
}
