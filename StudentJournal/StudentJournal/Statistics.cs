namespace StudentJournal
{
    public class Statistics
    {
        public float Min { get; set; }
        public float Max { get; set; }
        public float Average { get; set; }

        public Statistics()
        {
            Max = float.MinValue;
            Min = float.MaxValue;
            Average = 0;
        }
        public void Add(float grade)
        {
            Min = Math.Min(grade, Min);
            Max = Math.Max(grade, Max);
        }
    }
}

