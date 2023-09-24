using StudentJournal;

Console.WriteLine("Witamy w programie XYZ do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();

var student = new StudentInMemory("Kasia", "Nowak","15");
while (true)
{
    Console.WriteLine("Podaj ocene ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        student.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}


var statistic1 = student.GetStatistic1();
Console.WriteLine($"avg: {statistic1.Average} ");
Console.WriteLine($"min: {statistic1.Min} ");
Console.WriteLine($"max: {statistic1.Max} ");
var statistic2 = student.GetStatistic2();
Console.WriteLine($"avg: {statistic2.Average} ");
Console.WriteLine($"min: {statistic2.Min} ");
Console.WriteLine($"max: {statistic2.Max} ");
var statistic3 = student.GetStatistic3();
Console.WriteLine($"avg: {statistic3.Average} ");
Console.WriteLine($"min: {statistic3.Min} ");
Console.WriteLine($"max: {statistic3.Max} ");
var statistic4 = student.GetStatistic4();
Console.WriteLine($"avg: {statistic4.Average} ");
Console.WriteLine($"min: {statistic4.Min} ");
Console.WriteLine($"max: {statistic4.Max} ");
var statistic5 = student.GetStatistic5();
Console.WriteLine($"avg: {statistic5.Average} ");
Console.WriteLine($"min: {statistic5.Min} ");
Console.WriteLine($"max: {statistic5.Max} ");
