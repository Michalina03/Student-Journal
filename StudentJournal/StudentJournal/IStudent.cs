using static StudentJournal.StudentBase;
namespace StudentJournal
{
    public interface IStudent
    {
        string Name { get; }
        string Surename { get; }

        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistic();
    }
}
