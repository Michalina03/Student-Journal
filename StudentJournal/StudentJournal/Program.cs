using StudentJournal;

Console.WriteLine("Welcome to the student's journal !");
Console.WriteLine("============================");
Console.WriteLine();
Console.WriteLine("Submit your math grades:");
var math = new StudentInFile("Kasia", "Nowak", "15");
math.AddGradeMath(5);
//while (true)
//{
//    var inputMath = Console.ReadLine();
//    if (inputMath == "q")
//    {
//        break;
//    }
//    try
//    {
//        math.AddGradeMath(inputMath);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catch {e.Message}");
//    }
//}
//var statisticsMath = math.GetStatisticsMath();
//Console.WriteLine(statisticsMath.Average);
//Console.WriteLine(statisticsMath.Min);
//Console.WriteLine(statisticsMath.Max);
//Console.WriteLine();
//Console.WriteLine("Submit your polish grades:");
//var polish = new StudentInMemory("Kasia", "Nowak", "15");
//while (true)
//{
//    var inputPolish = Console.ReadLine();
//    if (inputPolish == "q")
//    {
//        break;
//    }
//    try
//    {
//        polish.AddGradePolish(inputPolish);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catch {e.Message}");
//    }
//}
//var statisticsPolish = polish.GetStatisticsPolish();
//Console.WriteLine(statisticsPolish.Average);
//Console.WriteLine(statisticsPolish.Min);
//Console.WriteLine(statisticsPolish.Max);
//Console.WriteLine();
//Console.WriteLine("Submit your english grades:");
//var english = new StudentInMemory("Kasia", "Nowak", "15");
//while (true)
//{
//    var inputEnglish = Console.ReadLine();
//    if (inputEnglish == "q")
//    {
//        break;
//    }
//    try
//    {
//        english.AddGradeEnglish(inputEnglish);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catch {e.Message}");
//    }
//}
//var statisticsEnglish = english.GetStatisticsEnglish();
//Console.WriteLine(statisticsEnglish.Average);
//Console.WriteLine(statisticsEnglish.Min);
//Console.WriteLine(statisticsEnglish.Max);
//Console.WriteLine();
//Console.WriteLine("Submit your grades in IT:");
//var IT = new StudentInMemory("Kasia", "Nowak", "15");
//while (true)
//{
//    var inputIT = Console.ReadLine();
//    if (inputIT == "q")
//    {
//        break;
//    }
//    try
//    {
//        IT.AddGradeIT(inputIT);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catch {e.Message}");
//    }
//}
//var statisticsIT = IT.GetStatisticsIT();
//Console.WriteLine(statisticsIT.Average);
//Console.WriteLine(statisticsIT.Min);
//Console.WriteLine(statisticsIT.Max);
//Console.WriteLine();
//Console.WriteLine("Submit your physics grades:");
//var physics = new StudentInMemory("Kasia", "Nowak", "15");
//while (true)
//{
//    var inputPhysics = Console.ReadLine();
//    if (inputPhysics == "q")
//    {
//        break;
//    }
//    try
//    {
//        physics.AddGradePhysics(inputPhysics);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catch {e.Message}");
//    }
//}
//var statisticsPhysics = physics.GetStatisticsIT();
//Console.WriteLine(statisticsPhysics.Average);
//Console.WriteLine(statisticsPhysics.Min);
//Console.WriteLine(statisticsPhysics.Max);