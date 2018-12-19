namespace party_cost_planner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

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