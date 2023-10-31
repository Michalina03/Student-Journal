using System.Diagnostics;

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
        public override void AddGradeMath(string gradeMath)
        {
            if (int.TryParse(gradeMath, out int result))
            {
              this.AddGradeMath(result);
            }
            else if (char.TryParse(gradeMath, out char charResult))
            {
                this.AddGradeMath(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }


        }
        public override void AddGradeMath(char gradeMath)
        {
            switch (gradeMath)
            {
                case 'a':
                case 'A':
                    this.gradesMath.Add(6);
                    break;
                case 'b':
                case 'B':
                    this.gradesMath.Add(5);
                    break;
                case 'c':
                case 'C':
                    this.gradesMath.Add(4);
                    break;
                case 'd':
                case 'D':
                    this.gradesMath.Add(3);
                    break;
                case 'e':
                case 'E':
                    this.gradesMath.Add(2);
                    break;
                case 'f':
                case 'F':
                    this.gradesMath.Add(1);
                    break;
                default:
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
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
                this.gradesMath.Add(gradePolish);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        public override void AddGradePolish(string gradePolish)
        {
            if (int.TryParse(gradePolish, out int result))
            {
                this.AddGradePolish(result);
            }
            else if (char.TryParse(gradePolish, out char charResult))
            {
                this.AddGradePolish(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }
        }
        public override void AddGradePolish(char gradePolish)
        {
            switch (gradePolish)
            {
                case 'a':
                case 'A':
                    this.gradesPolish.Add(6);
                    break;
                case 'b':
                case 'B':
                    this.gradesPolish.Add(5);
                    break;
                case 'c':
                case 'C':
                    this.gradesPolish.Add(4);
                    break;
                case 'd':
                case 'D':
                    this.gradesPolish.Add(3);
                    break;
                case 'e':
                case 'E':
                    this.gradesPolish.Add(2);
                    break;
                case 'f':
                case 'F':
                    this.gradesPolish.Add(1);
                    break;
                default:
                    throw new Exception("This grade doesn't exist. Give a rating from A to F."); ;
            }
        }
        public override void AddGradeEnglish(double grade)
        {
            int result = (int)grade;
            this.AddGradeEnglish(result);
        }

        public override void AddGradeEnglish(float grade)
        {
            int result = (int)grade;
            this.AddGradeEnglish(result);
        }
        public override void AddGradeEnglish(int gradeEnglish)
        {
            if (gradeEnglish >= 1 && gradeEnglish <= 6)
            {
                this.gradesMath.Add(gradeEnglish);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        public override void AddGradeEnglish(string gradeEnglish)
        {
            if (int.TryParse(gradeEnglish, out int result))
            {
                this.AddGradeEnglish(result);
            }
            else if (char.TryParse(gradeEnglish, out char charResult))
            {
                this.AddGradeEnglish(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }
        }
        public override void AddGradeEnglish(char gradeEnglish)
        {
            switch (gradeEnglish)
            {
                case 'a':
                case 'A':
                    this.gradesEnglish.Add(6);
                    break;
                case 'b':
                case 'B':
                    this.gradesEnglish.Add(5);
                    break;
                case 'c':
                case 'C':
                    this.gradesEnglish.Add(4);
                    break;
                case 'd':
                case 'D':
                    this.gradesEnglish.Add(3);
                    break;
                case 'e':
                case 'E':
                    this.gradesEnglish.Add(2);
                    break;
                case 'f':
                case 'F':
                    this.gradesEnglish.Add(1);
                    break;
                default:
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
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
                this.gradesMath.Add(gradeIT);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        public override void AddGradeIT(string gradeIT)
        {
            if (int.TryParse(gradeIT, out int result))
            {
                this.AddGradeIT(result);
            }
            else if (char.TryParse(gradeIT, out char charResult))
            {
                this.AddGradeIT(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }
        }
        public override void AddGradeIT(char gradeIT)
        {
            switch (gradeIT)
            {
                case 'a':
                case 'A':
                    this.gradesIT.Add(6);
                    break;
                case 'b':
                case 'B':
                    this.gradesIT.Add(5);
                    break;
                case 'c':
                case 'C':
                    this.gradesIT.Add(4);
                    break;
                case 'd':
                case 'D':
                    this.gradesIT.Add(3);
                    break;
                case 'e':
                case 'E':
                    this.gradesIT.Add(2);
                    break;
                case 'f':
                case 'F':
                    this.gradesIT.Add(1);
                    break;
                default:
                    throw new Exception("This grades doesnt't exist. Give a rating from A to F.");
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
        public override void AddGradePhysics(string gradePhysics)
        {
            if (int.TryParse(gradePhysics, out int result))
            {
                this.AddGradePhysics(result);
            }
            else if (char.TryParse(gradePhysics, out char charResult))
            {
                this.AddGradePhysics(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }
        }
        public override void AddGradePhysics(char gradePhysics)
        {
            switch (gradePhysics)
            {
                case 'a':
                case 'A':
                    this.gradesPhysics.Add(6);
                    break;
                case 'b':
                case 'B':
                    this.gradesPhysics.Add(5);
                    break;
                case 'c':
                case 'C':
                    this.gradesPhysics.Add(4);
                    break;
                case 'd':
                case 'D':
                    this.gradesPhysics.Add(3);
                    break;
                case 'e':
                case 'E':
                    this.gradesPhysics.Add(2);
                    break;
                case 'f':
                case 'F':
                    this.gradesPhysics.Add(1);
                    break;
                default:
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
            }
        }

        public override Statistics GetStatisticsMath()
        {
            var statisticsMath = new Statistics();
            statisticsMath.Average = 0;
            statisticsMath.Max = float.MinValue;
            statisticsMath.Min = float.MaxValue;

            foreach (var grade in this.gradesMath)
            {
                statisticsMath.Max = Math.Max(statisticsMath.Max, grade);
                statisticsMath.Min = Math.Min(statisticsMath.Min, grade);
                statisticsMath.Average += grade;
            }

            statisticsMath.Average /= this.gradesMath.Count;


            return statisticsMath;
        }
        public override Statistics GetStatisticsPolish()
        {
            var statisticsPolish = new Statistics();
            statisticsPolish.Average = 0;
            statisticsPolish.Max = float.MinValue;
            statisticsPolish.Min = float.MaxValue;

            foreach (var grade in this.gradesPolish)
            {

                statisticsPolish.Max = Math.Max(statisticsPolish.Max, grade);
                statisticsPolish.Min = Math.Min(statisticsPolish.Min, grade);
                statisticsPolish.Average += grade;
            }

            statisticsPolish.Average = statisticsPolish.Average / this.gradesPolish.Count;



            return statisticsPolish;

        }
        public override Statistics GetStatisticsEnglish()
        {
            var statisticsEnglish = new Statistics();
            statisticsEnglish.Average = 0;
            statisticsEnglish.Max = float.MinValue;
            statisticsEnglish.Min = float.MaxValue;

            foreach (var grade in this.gradesEnglish)
            {
                statisticsEnglish.Max = Math.Max(statisticsEnglish.Max, grade);
                statisticsEnglish.Min = Math.Min(statisticsEnglish.Min, grade);
                statisticsEnglish.Average += grade;

            }

            statisticsEnglish.Average = statisticsEnglish.Average / this.gradesEnglish.Count;

            return statisticsEnglish;

        }
        public override Statistics GetStatisticsIT()
        {
            var statisticsIT = new Statistics();
            statisticsIT.Average = 0;
            statisticsIT.Max = float.MinValue;
            statisticsIT.Min = float.MaxValue;

            foreach (var grade in this.gradesIT)
            {

                statisticsIT.Max = Math.Max(statisticsIT.Max, grade);
                statisticsIT.Min = Math.Min(statisticsIT.Min, grade);
                statisticsIT.Average += grade;

            }

            statisticsIT.Average = statisticsIT.Average / this.gradesIT.Count;

            return statisticsIT;

        }
        public override Statistics GetStatisticsPhysics()
        {
            var statisticsPhysics = new Statistics();
            statisticsPhysics.Average = 0;
            statisticsPhysics.Max = float.MinValue;
            statisticsPhysics.Min = float.MaxValue;

            foreach (var grade in this.gradesPhysics)
            {

                statisticsPhysics.Max = Math.Max(statisticsPhysics.Max, grade);
                statisticsPhysics.Min = Math.Min(statisticsPhysics.Min, grade);
                statisticsPhysics.Average += grade;

            }

            statisticsPhysics.Average = statisticsPhysics.Average / this.gradesPhysics.Count;

            return statisticsPhysics;

        }
    }
}
