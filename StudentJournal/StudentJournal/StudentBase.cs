namespace StudentJournal
{
    public abstract class StudentBase : IStudent
    {

        public StudentBase(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public abstract void AddGradeMath(float grade);
        public abstract void AddGradePolish(float grade);
        public abstract void AddGradeEnglish(float grade);
        public abstract void AddGradeIT(float grade);
        public abstract void AddGradePhysics(float grade);
        public void AddGradeMath(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradeMath(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGradeMath(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");

            }
        }
        public void AddGradePolish(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradePolish(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGradePolish(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");

            }
        }
        public void AddGradeEnglish(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradeEnglish(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGradeEnglish(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }
        }

        public void AddGradeIT(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradeIT(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGradeIT(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");

            }
        }
        public void AddGradePhysics(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGradePhysics(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGradePhysics(charResult);
            }
            else
            {
                throw new Exception("This grade doesn't exist. String isn't int.");
            }
        }
        public void AddGradeMath(char grade)
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
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
            }
        }
        public void AddGradePolish(char grade)
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
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
            }
        }
        public void AddGradeEnglish(char grade)
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
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
            }
        }
        public void AddGradeIT(char grade)
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
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
            }
        }
        public void AddGradePhysics(char grade)
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
                    throw new Exception("This grade doesn't exist. Give a rating from A to F.");
            }
        }

        public abstract Statistics GetStatisticsMath();
        public abstract Statistics GetStatisticsPolish();
        public abstract Statistics GetStatisticsEnglish();
        public abstract Statistics GetStatisticsIT();
        public abstract Statistics GetStatisticsPhysics();

    }

}
