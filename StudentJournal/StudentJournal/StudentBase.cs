namespace StudentJournal
{
    public class StudentBase
    {
        private List<float> gradesMath = new List<float>();
        private List<float> gradesPolish = new List<float>();
        private List<float> gradesEnglish = new List<float>();
        private List<float> gradesIT = new List<float>();
        private List<float> gradesPhysics = new List<float>();
        public StudentBase(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;


        }
        public StudentBase()
        { }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public void AddGradeMath(float gradeMath)
        {
            if (gradeMath > 0 && gradeMath <= 6)
            {
                this.gradesMath.Add(gradeMath);
            }
            else
            {
                Console.WriteLine("This grade doesn't exist");
            }
        }
        public void AddGradeMath(string gradeMath)
        {
            if (float.TryParse(gradeMath, out float result))
            {
                this.gradesMath.Add(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }
        public void AddGradeMath(char gradeMath)
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
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGradePolish(float gradePolish)
        {
            if (gradePolish > 0 && gradePolish <= 6)
            {
                this.gradesMath.Add(gradePolish);
            }
            else
            {
                Console.WriteLine("This grade doesn't exist");
            }
        }
        public void AddGradePolish(string gradePolish)
        {
            if (float.TryParse(gradePolish, out float result))
            {
                this.gradesPolish.Add(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }
        public void AddGradePolish(char gradePolish)
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
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGradeEnglish(float gradeEnglish)
        {
            if (gradeEnglish > 0 && gradeEnglish <= 6)
            {
                this.gradesMath.Add(gradeEnglish);
            }
            else
            {
                Console.WriteLine("This grade doesn't exist");
            }
        }
        public void AddGradeEnglish(string gradeEnglish)
        {
            if (float.TryParse(gradeEnglish, out float result))
            {
                this.gradesEnglish.Add(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }
        public void AddGradeEnglish(char gradeEnglish)
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
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGradeIT(float gradeIT)
        {
            if (gradeIT > 0 && gradeIT <= 6)
            {
                this.gradesMath.Add(gradeIT);
            }
            else
            {
                Console.WriteLine("This grade doesn't exist");
            }
        }
        public void AddGradeIT(string gradeIT)
        {
            if (float.TryParse(gradeIT, out float result))
            {
                this.gradesIT.Add(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }
        public void AddGradeIT(char gradeIT)
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
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGradePhysics(float gradePhysics)
        {
            if (gradePhysics > 0 && gradePhysics <= 6)
            {
                this.gradesPhysics.Add(gradePhysics);
            }
            else
            {
                Console.WriteLine("This grade doesn't exist");
            }
        }
        public void AddGradePhysics(string gradePhysics)
        {
            if (float.TryParse(gradePhysics, out float result))
            {
                this.gradesPhysics.Add(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }
        public void AddGradePhysics(char gradePhysics)
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
                    throw new Exception("Wrong Letter");
            }
        }
        public Statistics GetStatisticsMath()
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
        public Statistics GetStatisticsPolish()
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
        public Statistics GetStatisticsEnglish()
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
        public Statistics GetStatisticsIT()
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
        public Statistics GetStatisticsPhysics()
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
