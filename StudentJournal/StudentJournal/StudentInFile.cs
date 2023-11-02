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
                Statistics stats = new Statistics();
                stats.Min = int.MaxValue;
                stats.Max = int.MinValue;
                stats.Average = 0;
                if (File.Exists(gradesPolish))
                {
                    using (var reader = File.OpenText(gradesPolish))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            int point = int.Parse(line);
                            stats.Min = Math.Min(stats.Min, point);
                            stats.Max = Math.Max(stats.Max, point);
                            stats.Average += point;

                            line = reader.ReadLine();
                        }
                        if (i > 0)
                        {
                            stats.Average /= i;
                        }
                        else
                        {
                            stats.Min = 0;
                            stats.Max = 0;
                            stats.Average = 0;
                        }

                    }

                }
                return stats;
            }
        }
        public override Statistics GetStatisticsEnglish()
        {
            {
                Statistics stats = new Statistics();
                stats.Min = int.MaxValue;
                stats.Max = int.MinValue;
                stats.Average = 0;
                if (File.Exists(gradesEnglish))
                {
                    using (var reader = File.OpenText(gradesEnglish))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            int point = int.Parse(line);
                            stats.Min = Math.Min(stats.Min, point);
                            stats.Max = Math.Max(stats.Max, point);
                            stats.Average += point;

                            line = reader.ReadLine();
                        }
                        if (i > 0)
                        {
                            stats.Average /= i;
                        }
                        else
                        {
                            stats.Min = 0;
                            stats.Max = 0;
                            stats.Average = 0;
                        }

                    }

                }
                return stats;
            }
        }

        public override Statistics GetStatisticsIT()
        {
            {
                Statistics stats = new Statistics();
                stats.Min = int.MaxValue;
                stats.Max = int.MinValue;
                stats.Average = 0;
                if (File.Exists(gradesIT))
                {
                    using (var reader = File.OpenText(gradesIT))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            int point = int.Parse(line);
                            stats.Min = Math.Min(stats.Min, point);
                            stats.Max = Math.Max(stats.Max, point);
                            stats.Average += point;

                            line = reader.ReadLine();
                        }
                        if (i > 0)
                        {
                            stats.Average /= i;
                        }
                        else
                        {
                            stats.Min = 0;
                            stats.Max = 0;
                            stats.Average = 0;
                        }

                    }

                }
                return stats;
            }
        }



        public override Statistics GetStatisticsPhysics()
        {
            {
                Statistics stats = new Statistics();
                stats.Min = int.MaxValue;
                stats.Max = int.MinValue;
                stats.Average = 0;
                if (File.Exists(gradesPhysics))
                {
                    using (var reader = File.OpenText(gradesPhysics))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            int point = int.Parse(line);
                            stats.Min = Math.Min(stats.Min, point);
                            stats.Max = Math.Max(stats.Max, point);
                            stats.Average += point;

                            line = reader.ReadLine();
                        }
                        if (i > 0)
                        {
                            stats.Average /= i;
                        }
                        else
                        {
                            stats.Min = 0;
                            stats.Max = 0;
                            stats.Average = 0;
                        }

                    }

                }
                return stats;
            }
        }


    }
}
