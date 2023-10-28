using StudentJournal;

Console.WriteLine("Welcome to the student's journal !");
Console.WriteLine("============================");
Console.WriteLine("Save your grades on a list:");
Console.WriteLine();
Console.WriteLine("Submit your math grades:");
var math = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputMath = Console.ReadLine();
    if (inputMath == "q")
    {
        break;
    }

    try
    {
        math.AddGradeMath(inputMath);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsMath = math.GetStatisticsMath();
Console.WriteLine(statisticsMath.Average);
Console.WriteLine(statisticsMath.Min);
Console.WriteLine(statisticsMath.Max);
Console.WriteLine();
Console.WriteLine("Submit your polish grades:");
var polish = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputPolish = Console.ReadLine();
    if (inputPolish == "q")
    {
        break;
    }
    try
    {
        polish.AddGradePolish(inputPolish);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPolish = polish.GetStatisticsPolish();
Console.WriteLine(statisticsPolish.Average);
Console.WriteLine(statisticsPolish.Min);
Console.WriteLine(statisticsPolish.Max);
Console.WriteLine();
Console.WriteLine("Submit your english grades:");
var english = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputEnglish = Console.ReadLine();
    if (inputEnglish == "q")
    {
        break;
    }
    try
    {
        english.AddGradeEnglish(inputEnglish);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsEnglish = english.GetStatisticsEnglish();
Console.WriteLine(statisticsEnglish.Average);
Console.WriteLine(statisticsEnglish.Min);
Console.WriteLine(statisticsEnglish.Max);
Console.WriteLine();
Console.WriteLine("Submit your grades in IT:");
var IT = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputIT = Console.ReadLine();
    if (inputIT == "q")
    {
        break;
    }
    try
    {
        IT.AddGradeIT(inputIT);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsIT = IT.GetStatisticsIT();
Console.WriteLine(statisticsIT.Average);
Console.WriteLine(statisticsIT.Min);
Console.WriteLine(statisticsIT.Max);
Console.WriteLine();
Console.WriteLine("Submit your physics grades:");
var physics = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputPhysics = Console.ReadLine();
    if (inputPhysics == "q")
    {
        break;
    }
    try
    {
        physics.AddGradePhysics(inputPhysics);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPhysics = physics.GetStatisticsIT();
Console.WriteLine(statisticsPhysics.Average);
Console.WriteLine(statisticsPhysics.Min);
Console.WriteLine(statisticsPhysics.Max);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Welcome to the student's journal !");
Console.WriteLine("============================");
Console.WriteLine("Save your grades on a list:");
Console.WriteLine();
Console.WriteLine("Submit your math grades:");
var math2 = new StudentInFile("Kasia", "Nowak", "15");
while (true)
{
    var inputMath2 = Console.ReadLine();
    if (inputMath2 == "q")
    {
        break;
    }

    try
    {
        math2.AddGradeMath(inputMath2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsMath2 = math2.GetStatisticsMath();
Console.WriteLine(statisticsMath2.Average);
Console.WriteLine(statisticsMath2.Min);
Console.WriteLine(statisticsMath2.Max);
Console.WriteLine();
Console.WriteLine("Submit your polish grades:");
var polish2 = new StudentInFile("Kasia", "Nowak", "15");
while (true)
{
    var inputPolish2 = Console.ReadLine();
    if (inputPolish2 == "q")
    {
        break;
    }
    try
    {
        polish2.AddGradePolish(inputPolish2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPolish2 = polish2.GetStatisticsPolish();
Console.WriteLine(statisticsPolish2.Average);
Console.WriteLine(statisticsPolish2.Min);
Console.WriteLine(statisticsPolish2.Max);
Console.WriteLine();
Console.WriteLine("Submit your english grades:");
var english2 = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputEnglish2 = Console.ReadLine();
    if (inputEnglish2 == "q")
    {
        break;
    }
    try
    {
        english2.AddGradeEnglish(inputEnglish2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsEnglish2 = english2.GetStatisticsEnglish();
Console.WriteLine(statisticsEnglish2.Average);
Console.WriteLine(statisticsEnglish2.Min);
Console.WriteLine(statisticsEnglish2.Max);
Console.WriteLine();
Console.WriteLine("Submit your grades in IT:");
var IT2 = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputIT2 = Console.ReadLine();
    if (inputIT2 == "q")
    {
        break;
    }
    try
    {
        IT2.AddGradeIT(inputIT2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsIT2 = IT2.GetStatisticsIT();
Console.WriteLine(statisticsIT2.Average);
Console.WriteLine(statisticsIT2.Min);
Console.WriteLine(statisticsIT2.Max);
Console.WriteLine();
Console.WriteLine("Submit your physics grades:");
var physics2 = new StudentInMemory("Kasia", "Nowak", "15");
while (true)
{
    var inputPhysics2 = Console.ReadLine();
    if (inputPhysics2 == "q")
    {
        break;
    }
    try
    {
        physics.AddGradePhysics(inputPhysics2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch {e.Message}");
    }
}
var statisticsPhysics2 = physics2.GetStatisticsPhysics();
Console.WriteLine(statisticsPhysics2.Average);
Console.WriteLine(statisticsPhysics2.Min);
Console.WriteLine(statisticsPhysics2.Max);