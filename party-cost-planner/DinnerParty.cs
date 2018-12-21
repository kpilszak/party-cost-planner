namespace party_cost_planner
{
    class DinnerParty : Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool OnlySoftDrinksOption { get; set; }
        public bool FancifulDecorations { get; set; }
                
        public DinnerParty(int numberOfPeople, bool onlySoftDrinksOption, bool fancifulDecorations)
        {
            NumberOfPeople = numberOfPeople;
            OnlySoftDrinksOption = onlySoftDrinksOption;
            FancifulDecorations = fancifulDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancifulDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
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
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (OnlySoftDrinksOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}