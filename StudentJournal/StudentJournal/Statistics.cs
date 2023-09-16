namespace StudentJournal
{
    public class Statistics 
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AvargeLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var a when a >= 6:
                        return 'A';
                    case var a when a >= 5:
                        return 'B';
                    case var a when a >= 4:
                        return 'C';
                    case var a when a >= 3:
                        return 'D';
                    case var a when a >= 2:
                        return 'E';
                    case var a when a >= 1:
                        return 'F';
                    default:
                        return 'Z';
                        
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(grade, this.Max);
            this.Min = Math.Min(grade, this.Min);
        }
    }
}
