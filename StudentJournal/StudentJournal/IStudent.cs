namespace StudentJournal
{
    public interface IStudent
    {
        string Name { get; }
        string Surname { get; }
        string Age { get; }


        void AddGradeMath(int grade);
        void AddGradePolish(int grade);
        void AddGradeEnglish(int grade);
        void AddGradeIT(int grade);
        void AddGradePhysics(int grade);
        void AddGradeMath(float grade);
        void AddGradePolish(float grade);
        void AddGradeEnglish(float grade);
        void AddGradeIT(float grade);
        void AddGradePhysics(float grade);
        void AddGradeMath(double grade);
        void AddGradePolish(double grade);
        void AddGradeEnglish(double grade);
        void AddGradeIT(double grade);
        void AddGradePhysics(double grade);
        void AddGradeMath(string grade);
        void AddGradePolish(string grade);
        void AddGradeEnglish(string gradeEnglish);
        void AddGradeIT(string grade);
        void AddGradePhysics(string grade);
        void AddGradeMath(char grade);
        void AddGradePolish(char grade);
        void AddGradeEnglish(char grade);
        void AddGradeIT(char grade);
        void AddGradePhysics(char grade);


        Statistics GetStatisticsMath();
        Statistics GetStatisticsPolish();
        Statistics GetStatisticsEnglish();
        Statistics GetStatisticsIT();
        Statistics GetStatisticsPhysics();
        
    }
}
