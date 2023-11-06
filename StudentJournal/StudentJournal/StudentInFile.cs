namespace StudentJournal
{
    public class StudentInFile : StudentBase
    {
        private const string gradesMath = "gradesMath.txt";
        private const string gradesPolish = "gradesPolish.txt";
        private const string gradesEnglish = "gradesEnglish.txt";
        private const string gradesIT = "gradesIT.txt";
        private const string gradesPhysics = "gradesPhysics.txt";

        public StudentInFile(string name, string surename, string age)
            : base(name, surename, age)
        {

        }

        public override void AddGradeMath(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(gradesMath))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        public override void AddGradePolish(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(gradesPolish))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        public override void AddGradeEnglish(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(gradesEnglish))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override void AddGradeIT(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(gradesIT))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }

        public override void AddGradePhysics(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(gradesPhysics))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }


        public override Statistics GetStatisticsMath()
        {
            {
                var result = new Statistics();
                if (File.Exists($"{gradesMath}"))
                {
                    using (var reader = File.OpenText($"{gradesMath}"))
                    {
                        var line = reader.ReadLine();
                        
                            while (line != null)
                            {
                                var grade = float.Parse(line);
                                result.Add(grade);
                                line = reader.ReadLine();
                            }
                    }
                }
                return result;
            }
        }
        public override Statistics GetStatisticsPolish()
        {
            {
                var result = new Statistics();
                if (File.Exists($"{gradesPolish}"))
                {
                    using (var reader = File.OpenText($"{gradesPolish}"))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            var grade = float.Parse(line);
                            result.Add(grade);
                            line = reader.ReadLine();
                        }
                    }
                }
                return result;
            }
        }
        public override Statistics GetStatisticsEnglish()
        {
            {
                var result = new Statistics();
                if (File.Exists($"{gradesEnglish}"))
                {
                    using (var reader = File.OpenText($"{gradesEnglish}"))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            var grade = float.Parse(line);
                            result.Add(grade);
                            line = reader.ReadLine();
                        }
                    }
                }
                return result;
            }
        }
        public override Statistics GetStatisticsIT()
        {
            {
                var result = new Statistics();
                if (File.Exists($"{gradesIT}"))
                {
                    using (var reader = File.OpenText($"{gradesIT}"))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            var grade = float.Parse(line);
                            result.Add(grade);
                            line = reader.ReadLine();
                        }
                    }
                }
                return result;
            }
        }
        public override Statistics GetStatisticsPhysics()
        {
            {
                var result = new Statistics();
                if (File.Exists($"{gradesPhysics}"))
                {
                    using (var reader = File.OpenText($"{gradesPhysics}"))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            var grade = float.Parse(line);
                            result.Add(grade);
                            line = reader.ReadLine();
                        }
                    }
                }
                return result;
            }
        }
    }
}
