namespace party_cost_planner
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancifulDecorations { get; set; }
        
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancifulDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }
    }
}