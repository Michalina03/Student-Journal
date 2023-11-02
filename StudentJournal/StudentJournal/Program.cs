using StudentJournal;

Console.WriteLine("Welcome to the student's journal !");
Console.WriteLine("============================");
Console.WriteLine("Save your grades on a list:");
Console.WriteLine();
Console.WriteLine("Submit your math grades:");
var studentInMemory = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        studentInMemory.AddGradeMath(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsMath = studentInMemory.GetStatisticsMath();
Console.WriteLine($"Average:{statisticsMath.Average}");
Console.WriteLine($"Min:{statisticsMath.Min}");
Console.WriteLine($"Max:{statisticsMath.Max}");
Console.WriteLine();
Console.WriteLine("Submit your polish grades:");
while (true)
{
    var inputPolish = Console.ReadLine();
    if (inputPolish == "q")
    {
        break;
    }
    try
    {
        studentInMemory.AddGradePolish(inputPolish);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPolish = studentInMemory.GetStatisticsPolish();
Console.WriteLine($"Average:{statisticsPolish.Average}");
Console.WriteLine($"Min:{statisticsPolish.Min}");
Console.WriteLine($"Max:{statisticsPolish.Max}");
Console.WriteLine();
Console.WriteLine("Submit your english grades:");
while (true)
{
    var inputEnglish = Console.ReadLine();
    if (inputEnglish == "q")
    {
        break;
    }
    try
    {
        studentInMemory.AddGradeEnglish(inputEnglish);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsEnglish = studentInMemory.GetStatisticsEnglish();
Console.WriteLine($"Average:{statisticsEnglish.Average}");
Console.WriteLine($"Min:{statisticsEnglish.Min}");
Console.WriteLine($"Max:{statisticsEnglish.Max}");
Console.WriteLine();
Console.WriteLine("Submit your grades in IT:");
while (true)
{
    var inputIT = Console.ReadLine();
    if (inputIT == "q")
    {
        break;
    }
    try
    {
        studentInMemory.AddGradeIT(inputIT);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsIT = studentInMemory.GetStatisticsIT();
Console.WriteLine($"Average:{statisticsIT.Average}");
Console.WriteLine($"Min:{statisticsIT.Min}");
Console.WriteLine($"Max:{statisticsIT.Max}");
Console.WriteLine();
Console.WriteLine("Submit your physics grades:");
while (true)
{
    var inputPhysics = Console.ReadLine();
    if (inputPhysics == "q")
    {
        break;
    }
    try
    {
        studentInMemory.AddGradePhysics(inputPhysics);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPhysics = studentInMemory.GetStatisticsPhysics();
Console.WriteLine($"Average:{statisticsPhysics.Average}");
Console.WriteLine($"Min:{statisticsPhysics.Min}");
Console.WriteLine($"Max:{statisticsPhysics.Max}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Welcome to the student's journal !");
Console.WriteLine(" ============================");
Console.WriteLine("Save your grades on a list:");
Console.WriteLine();
Console.WriteLine("Submit your math grades:");
var studentInFile = new StudentInFile("Kasia", "Nowak", "15");
while (true)
{
    var inputMath2 = Console.ReadLine();
    if (inputMath2 == "q")
    {
        break;
    }

    try
    {
        studentInFile.AddGradeMath(inputMath2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsMath2 = studentInFile.GetStatisticsMath();
Console.WriteLine($"Average:{statisticsMath2.Average}");
Console.WriteLine($"Min:{statisticsMath2.Min}");
Console.WriteLine($"Max:{statisticsMath2.Max}");
Console.WriteLine();
Console.WriteLine("Submit your polish grades:");
while (true)
{
    var inputPolish2 = Console.ReadLine();
    if (inputPolish2 == "q")
    {
        break;
    }
    try
    {
        studentInFile.AddGradePolish(inputPolish2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPolish2 = studentInFile.GetStatisticsPolish();
Console.WriteLine($"Average:{statisticsPolish2.Average}");
Console.WriteLine($"Min:{statisticsPolish2.Min}");
Console.WriteLine($"Min:{statisticsPolish2.Max}");
Console.WriteLine();
Console.WriteLine("Submit your english grades:");
while (true)
{
    var inputEnglish2 = Console.ReadLine();
    if (inputEnglish2 == "q")
    {
        break;
    }
    try
    {
        studentInFile.AddGradeEnglish(inputEnglish2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsEnglish2 = studentInFile.GetStatisticsEnglish();
Console.WriteLine($"Average:{statisticsEnglish2.Average}");
Console.WriteLine($"Min:{statisticsEnglish2.Min}");
Console.WriteLine($"Min:{statisticsEnglish2.Max}");
Console.WriteLine();
Console.WriteLine("Submit your grades in IT:");
while (true)
{
    var inputIT2 = Console.ReadLine();
    if (inputIT2 == "q")
    {
        break;
    }
    try
    {
        studentInFile.AddGradeIT(inputIT2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsIT2 = studentInFile.GetStatisticsIT();
Console.WriteLine($"Average:{statisticsIT2.Average}");
Console.WriteLine($"Min:{statisticsIT2.Min}");
Console.WriteLine($"Max:{statisticsIT2.Max}");
Console.WriteLine();
Console.WriteLine("Submit your physics grades:");
while (true)
{
    var inputPhysics2 = Console.ReadLine();
    if (inputPhysics2 == "q")
    {
        break;
    }
    try
    {
        studentInFile.AddGradePhysics(inputPhysics2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPhysics2 = studentInFile.GetStatisticsPhysics();
Console.WriteLine($"Average:{statisticsPhysics2.Average}");
Console.WriteLine($"Min:{statisticsPhysics2.Min}");
Console.WriteLine($"Max:{statisticsPhysics2.Max}");