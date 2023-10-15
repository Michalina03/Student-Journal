using StudentJournal;

Console.WriteLine("Witamy w dziennieku ucznia !");
Console.WriteLine("============================");
Console.WriteLine();
Console.WriteLine("Podaj swoje oceny z Matematyki:");

var inputMath = Console.ReadLine();
var student = new StudentBase();
student.AddGradeMath(inputMath);
var statisticsMath = student.GetStatisticsMath();
Console.WriteLine(statisticsMath.Average);
Console.WriteLine(statisticsMath.Min);

Console.WriteLine("Witamy w dziennieku ucznia !");
Console.WriteLine("============================");
Console.WriteLine();
Console.WriteLine("Podaj swoje oceny z Matematyki:");


var inputIT = Console.ReadLine();
var student2 = new StudentBase();
student2.AddGradeMath(inputIT);
var statisticsIT = student2.GetStatisticsMath();
Console.WriteLine(statisticsIT.Average);
Console.WriteLine(statisticsIT.Min);