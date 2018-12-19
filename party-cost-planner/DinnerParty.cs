namespace party_cost_planner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public void SetPartyOptions(int people, bool fanciful)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fanciful);
        }

        public void SetOnlySoftDrinksOption(bool softOption)
        {
            if (softOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            } else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fanciful)
        {
            if (fanciful)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            } else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }

        public decimal CalculateCost(bool softOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople);
            if (softOption)
            {
                return totalCost * .95M;
            } else
            {
                return totalCost;
            }
        }
    }
}