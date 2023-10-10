Student student1 = new Student("kasia", "Nwak", "15lat");


student1.AddScore(4);
student1.AddScore(4);
var result = student1.Result;
Console.WriteLine(result);
var result2 = student1.Result2;
Console.WriteLine(result2);

class Student
{
    private List<int> score = new List<int>();
    private List<int> score2 = new List<int>();
    public Student(string login, string surname, string age)
    {
        this.Login = login;
        this.Surname = surname;
        this.Age = age;
     

    }
    public string Login { get; private set; }
    public string Surname { get; private set; }
    public string Age { get; private set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public int Result2
    {
        get
        {
            return this.score2.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
        this.score2.Add(number);
        
    }
}