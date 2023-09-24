namespace StudentJournal
{
    public class StudentInMemory : StudentBase
    {
        private List<float> gradesMath = new List<float>();
        private List<float> gradesPolish = new List<float>();
        private List<float> gradesEnglish = new List<float>();
        private List<float> gradesIT = new List<float>();
        private List<float> gradesPhysics = new List<float>();
        public StudentInMemory(string name, string surename, string age)
            : base(name, surename,age)
        {

        }
        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 6)
            {
                this.gradesMath.Add(grade);
                this.gradesPolish.Add(grade);
                this.gradesEnglish.Add(grade);
                this.gradesIT.Add(grade);
                this.gradesPhysics.Add(grade);
            }

            else
            {
                throw new Exception("Invalid grade value");

            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.gradesMath.Add(6);
                    this.gradesPolish.Add(6);
                    this.gradesEnglish.Add(6);
                    this.gradesIT.Add(6);
                    this.gradesPhysics.Add(6);
                    break;
                case 'b':
                case 'B':
                    this.gradesMath.Add(5);
                    this.gradesPolish.Add(5);
                    this.gradesEnglish.Add(5);
                    this.gradesIT.Add(5);
                    this.gradesPhysics.Add(5);
                   break;
                case 'c':
                case 'C':
                    this.gradesMath.Add(4);
                    this.gradesPolish.Add(4);
                    this.gradesEnglish.Add(4);
                    this.gradesIT.Add(4);
                    this.gradesPhysics.Add(4);
                    break;
                case 'd':
                case 'D':
                    this.gradesMath.Add(3);
                    this.gradesPolish.Add(3);
                    this.gradesEnglish.Add(3);
                    this.gradesIT.Add(3);
                    this.gradesPhysics.Add(3);
                    break;
                case 'e':
                case 'E':
                    this.gradesMath.Add(2);
                    this.gradesPolish.Add(2);
                    this.gradesEnglish.Add(2);
                    this.gradesIT.Add(2);
                    this.gradesPhysics.Add(2);
                    break;
                case 'f':
                case 'F':
                    this.gradesMath.Add(1);
                    this.gradesPolish.Add(1);
                    this.gradesEnglish.Add(1);
                    this.gradesIT.Add(1);
                    this.gradesPhysics.Add(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else
            {
                throw new Exception("Invalid string value");

            }
        }

        public override Statistics GetStatistic1()
        {
            var statistic = new Statistics();

            foreach (var grade in this.gradesMath)
            {
                statistic.AddGrade(grade);
            }
             return statistic;
        }
        public override Statistics GetStatistic2()
        {
            var statistic = new Statistics();

            foreach (var grade in this.gradesPolish)
            {
                statistic.AddGrade(grade);
            }
           

            return statistic;
        }
        public override Statistics GetStatistic3()
        {
            var statistic = new Statistics();

            foreach (var grade in this.gradesEnglish)
            {
                statistic.AddGrade(grade);
            }
            

            return statistic;
        }
        public override Statistics GetStatistic4()
        {
            var statistic = new Statistics();
            foreach (var grade in this.gradesIT)
            {
                statistic.AddGrade(grade);
            }
           

            return statistic;
        }
        public override Statistics GetStatistic5()
        {
            var statistic = new Statistics();
            foreach (var grade in this.gradesPhysics)
            {
                statistic.AddGrade(grade);
            }

            return statistic;
        }
    }
}
