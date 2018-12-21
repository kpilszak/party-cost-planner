namespace party_cost_planner
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancifulDecorations { get; set; }
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancifulDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancifulDecorations = fancifulDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            else
                return 40;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
    }
}