namespace StudentJournal
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public Statistics()
        {
            Max = float.MinValue;
            Min = float.MaxValue;
            Count = 0;
            Sum = 0.0f;
        }
        public void Add(float grade)
        {
            Min = Math.Min(grade, Min);
            Max = Math.Max(grade, Max);
            Sum += grade;
            Count++;
        }
    }
}

