namespace StudentJournal
{
    public abstract class StudentBase : IStudent
    {
        public StudentBase(string name, string surename,string age)
        {
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surename { get; private set; }
        public string Age { get; private set; }

        public abstract void AddGrade(double grade);


        public abstract void AddGrade(int grade);


        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);


        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistic();
    }
}
