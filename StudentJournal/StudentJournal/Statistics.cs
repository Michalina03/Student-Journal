namespace StudentJournal
{
    public class Statistics
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Average { get; set; }

        public Statistics()
        {
            Max = int.MinValue;
            Min = int.MaxValue;
            Average = 0;
        }
        public void Add(int grade)
        {
            Min = Math.Min(grade, Min);
            Max = Math.Max(grade, Max);
        }
    }
}

