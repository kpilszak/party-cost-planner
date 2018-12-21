namespace party_cost_planner
{
    class DinnerParty : Party
    {
        public bool OnlySoftDrinksOption { get; set; }
                
        public DinnerParty(int numberOfPeople, bool onlySoftDrinksOption, bool fancifulDecorations)
        {
            NumberOfPeople = numberOfPeople;
            OnlySoftDrinksOption = onlySoftDrinksOption;
            FancifulDecorations = fancifulDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (OnlySoftDrinksOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost; 
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                if (OnlySoftDrinksOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}