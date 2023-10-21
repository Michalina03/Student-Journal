namespace StudentJournal
{
    public class StudentInFile : StudentBase
    {
        private const string fileName = "grades.txt";
        public StudentInFile(string name, string surename, string age)
            : base(name, surename, age)
        {

        }

        public override void AddGradeMath(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGradeMath(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradeMath(char grade)
        {
            throw new NotImplementedException();
        }
        public override void AddGradePolish(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradePolish(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradePolish(char grade)
        {
            throw new NotImplementedException();
        }
        public override void AddGradeEnglish(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradeEnglish(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradeEnglish(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradeIT(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradeIT(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradeIT(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradePhysics(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradePhysics(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGradePhysics(char grade)
        {
            throw new NotImplementedException();
        }


        public override Statistics GetStatisticsMath()
        {
            var gradesFromFlie = this.ReadGradesFromFile();
            var statistics = new Statistics();

            foreach (var gradeMath in gradesFromFlie)
            {
                statistics.AddGradeMath(gradeMath);
            }
            return statistics;
        } 
        public override Statistics GetStatisticsPolish()
        {
            throw new NotImplementedException();
        }
        public override Statistics GetStatisticsEnglish()
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatisticsIT()
        {
            throw new NotImplementedException();
        }

        

        public override Statistics GetStatisticsPhysics()
        {
            throw new NotImplementedException();
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }

            }
            return grades;
        }
    }
}
