namespace StudentJournal
{
    public interface IStudent
    {
        string Name { get; }
        string Surname { get; }
        string Age { get; }


        void AddGradeMath(float grade);
        void AddGradePolish(float grade);
        void AddGradeEnglish(float grade);
        void AddGradeIT(float grade);
        void AddGradePhysics(float grade);
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
