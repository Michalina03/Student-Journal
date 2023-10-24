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
        void AddGradeMath(string grade);
        void AddGradePolish(string grade);
        void AddGradeEnglish(string grade);
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
