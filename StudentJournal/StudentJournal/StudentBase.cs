namespace StudentJournal
{
    public abstract class StudentBase : IStudent
    {
        
        public StudentBase(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public abstract void AddGradeMath(float grade);
        public abstract void AddGradePolish(float grade);
        public abstract void AddGradeEnglish(float grade);
        public abstract void AddGradeIT(float grade);
        public abstract void AddGradePhysics(float grade);
        public abstract void AddGradeMath(string grade);
        public abstract void AddGradePolish(string grade);
        public abstract void AddGradeEnglish(string grade);
        public abstract void AddGradeIT(string grade);
        public abstract void AddGradePhysics(string grade);
        public abstract void AddGradeMath(char grade);
        public abstract void AddGradePolish(char grade);
        public abstract void AddGradeEnglish(char grade);
        public abstract void AddGradeIT(char grade);
        public abstract void AddGradePhysics(char grade);

        public abstract Statistics GetStatisticsMath();
        public abstract Statistics GetStatisticsPolish();
        public abstract Statistics GetStatisticsEnglish();
        public abstract Statistics GetStatisticsIT();
        public abstract Statistics GetStatisticsPhysics();

    }
    
}
