namespace StudentJournal
{
    public class StudentInMemory : StudentBase
    {
        private List<int> gradesMath = new List<int>();
        private List<int> gradesPolish = new List<int>();
        private List<int> gradesEnglish = new List<int>();
        private List<int> gradesIT = new List<int>();
        private List<int> gradesPhysics = new List<int>();
        public StudentInMemory(string name, string surename, string age)
            : base(name, surename, age)
        {

        }
        public override void AddGradeMath(double grade)
        {
            int result = (int)grade;
            this.AddGradeMath(result);
        }

        public override void AddGradeMath(float grade)
        {
            int result = (int)grade;
            this.AddGradeMath(result);
        }
        public override void AddGradeMath(int gradeMath)
        {
            if (gradeMath >= 1 && gradeMath <= 6)
            {
                this.gradesMath.Add(gradeMath);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override void AddGradePolish(double grade)
        {
            int result = (int)grade;
            this.AddGradePolish(result);
        }

        public override void AddGradePolish(float grade)
        {
            int result = (int)grade;
            this.AddGradePolish(result);
        }
        public override void AddGradePolish(int gradePolish)
        {
            if (gradePolish >= 1 && gradePolish <= 6)
            {
                this.gradesPolish.Add(gradePolish);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override void AddGradeEnglish(double grade)
        {
            int result = (int)grade;
            this.gradesEnglish.Add(result);
        }

        public override void AddGradeEnglish(float grade)
        {
            int result = (int)grade;
            this.gradesEnglish.Add(result);
        }
        public override void AddGradeEnglish(int gradeEnglish)
        {
            if (gradeEnglish >= 1 && gradeEnglish <= 6)
            {
                this.gradesEnglish.Add(gradeEnglish);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override void AddGradeIT(double grade)
        {
            int result = (int)grade;
            this.AddGradeIT(result);
        }

        public override void AddGradeIT(float grade)
        {
            int result = (int)grade;
            this.AddGradeIT(result);
        }
        public override void AddGradeIT(int gradeIT)
        {
            if (gradeIT >= 1 && gradeIT <= 6)
            {
                this.gradesIT.Add(gradeIT);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override void AddGradePhysics(double grade)
        {
            int result = (int)grade;
            this.AddGradePhysics(result);
        }

        public override void AddGradePhysics(float grade)
        {
            int result = (int)grade;
            this.AddGradePhysics(result);
        }
        public override void AddGradePhysics(int gradePhysics)
        {
            if (gradePhysics >= 1 && gradePhysics <= 6)
            {
                this.gradesPhysics.Add(gradePhysics);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override Statistics GetStatisticsMath()
        {
            var statisticsMath = new Statistics();

            foreach (var grade in this.gradesMath)
            {
                statisticsMath.Average += grade;
                statisticsMath.Add(grade);
            }
           
                statisticsMath.Average = statisticsMath.Average / this.gradesMath.Count;
           

            return statisticsMath;
        }
        public override Statistics GetStatisticsPolish()
        {
            var statisticsPolish = new Statistics();
            
            foreach (var grade in this.gradesPolish)
            {
                statisticsPolish.Add(grade);
                statisticsPolish.Average += grade;
            }

            statisticsPolish.Average = statisticsPolish.Average / this.gradesPolish.Count;



            return statisticsPolish;

        }
        public override Statistics GetStatisticsEnglish()
        {
            var statisticsEnglish = new Statistics();

            foreach (var grade in this.gradesEnglish)
            {
                statisticsEnglish.Add(grade);
                statisticsEnglish.Average += grade;

            }

            statisticsEnglish.Average = statisticsEnglish.Average / this.gradesEnglish.Count;

            return statisticsEnglish;

        }
        public override Statistics GetStatisticsIT()
        {
            var statisticsIT = new Statistics();

            foreach (var grade in this.gradesIT)
            {
                statisticsIT.Add(grade);
                statisticsIT.Average += grade;

            }

            statisticsIT.Average = statisticsIT.Average / this.gradesIT.Count;

            return statisticsIT;

        }
        public override Statistics GetStatisticsPhysics()
        {
            var statisticsPhysics = new Statistics();

            foreach (var grade in this.gradesPhysics)
            {
                statisticsPhysics.Add(grade);
                statisticsPhysics.Average += grade;

            }

            statisticsPhysics.Average = statisticsPhysics.Average / this.gradesPhysics.Count;

            return statisticsPhysics;

        }
    }
}