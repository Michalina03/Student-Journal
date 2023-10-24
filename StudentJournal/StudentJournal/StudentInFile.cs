namespace StudentJournal
{
    public class StudentInFile : StudentBase
    {
        private const string fileName = "grades.txt";
        private const string fileName2 = "grades2.txt";
        private const string fileName3 = "grades3.txt";
        private const string fileName4 = "grades4.txt";
        private const string fileName5 = "grades5.txt";

        public StudentInFile(string name, string surename, string age)
            : base(name, surename, age)
        {

        }

        public override void AddGradeMath(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }

        }

        public override void AddGradeMath(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradeMath(result);
            }

            else
            {
                throw new Exception("Invalid string value");

            }
        }

        public override void AddGradeMath(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.AddGradeMath(6);
                    break;
                case 'b':
                case 'B':
                    this.AddGradeMath(5);
                    break;
                case 'c':
                case 'C':
                    this.AddGradeMath(4);
                    break;
                case 'd':
                case 'D':
                    this.AddGradeMath(3);
                    break;
                case 'e':
                case 'E':
                    this.AddGradeMath(2);
                    break;
                case 'f':
                case 'F':
                    this.AddGradeMath(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public override void AddGradePolish(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(fileName2))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGradePolish(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradePolish(result);
            }

            else
            {
                throw new Exception("Invalid string value");

            }
        }

        public override void AddGradePolish(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.AddGradePolish(6);
                    break;
                case 'b':
                case 'B':
                    this.AddGradePolish(5);
                    break;
                case 'c':
                case 'C':
                    this.AddGradePolish(4);
                    break;
                case 'd':
                case 'D':
                    this.AddGradePolish(3);
                    break;
                case 'e':
                case 'E':
                    this.AddGradePolish(2);
                    break;
                case 'f':
                case 'F':
                    this.AddGradePolish(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public override void AddGradeEnglish(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(fileName3))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGradeEnglish(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradeEnglish(result);
            }

            else
            {
                throw new Exception("Invalid string value");

            }
        }

        public override void AddGradeEnglish(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.AddGradeEnglish(6);
                    break;
                case 'b':
                case 'B':
                    this.AddGradeEnglish(5);
                    break;
                case 'c':
                case 'C':
                    this.AddGradeEnglish(4);
                    break;
                case 'd':
                case 'D':
                    this.AddGradeEnglish(3);
                    break;
                case 'e':
                case 'E':
                    this.AddGradeEnglish(2);
                    break;
                case 'f':
                case 'F':
                    this.AddGradeEnglish(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGradeIT(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGradeIT(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradeIT(result);
            }

            else
            {
                throw new Exception("Invalid string value");

            }
        }

        public override void AddGradeIT(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.AddGradeIT(6);
                    break;
                case 'b':
                case 'B':
                    this.AddGradeIT(5);
                    break;
                case 'c':
                case 'C':
                    this.AddGradeIT(4);
                    break;
                case 'd':
                case 'D':
                    this.AddGradeIT(3);
                    break;
                case 'e':
                case 'E':
                    this.AddGradeIT(2);
                    break;
                case 'f':
                case 'F':
                    this.AddGradeIT(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGradePhysics(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGradePhysics(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradePhysics(result);
            }

            else
            {
                throw new Exception("Invalid string value");

            }
        }

        public override void AddGradePhysics(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.AddGradePhysics(6);
                    break;
                case 'b':
                case 'B':
                    this.AddGradePhysics(5);
                    break;
                case 'c':
                case 'C':
                    this.AddGradePhysics(4);
                    break;
                case 'd':
                case 'D':
                    this.AddGradePhysics(3);
                    break;
                case 'e':
                case 'E':
                    this.AddGradePhysics(2);
                    break;
                case 'f':
                case 'F':
                    this.AddGradePhysics(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override Statistics GetStatisticsMath()
        {
            Statistics stats = new Statistics();
            stats.Min = float.MaxValue;
            stats.Max = float.MinValue;
            stats.Average = 0;
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    int i = 0;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        i++;
                        float point = float.Parse(line);
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

        public override Statistics GetStatisticsPolish()
        {
            {
                Statistics stats = new Statistics();
                stats.Min = float.MaxValue;
                stats.Max = float.MinValue;
                stats.Average = 0;
                if (File.Exists(fileName2))
                {
                    using (var reader = File.OpenText(fileName2))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            float point = float.Parse(line);
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
                stats.Min = float.MaxValue;
                stats.Max = float.MinValue;
                stats.Average = 0;
                if (File.Exists(fileName3))
                {
                    using (var reader = File.OpenText(fileName3))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            float point = float.Parse(line);
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
                stats.Min = float.MaxValue;
                stats.Max = float.MinValue;
                stats.Average = 0;
                if (File.Exists(fileName4))
                {
                    using (var reader = File.OpenText(fileName4))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            float point = float.Parse(line);
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
                stats.Min = float.MaxValue;
                stats.Max = float.MinValue;
                stats.Average = 0;
                if (File.Exists(fileName5))
                {
                    using (var reader = File.OpenText(fileName5))
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            i++;
                            float point = float.Parse(line);
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
