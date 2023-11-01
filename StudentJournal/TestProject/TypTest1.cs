namespace StudentJournal.Test
{
    public class StudentInMemoryTestsMath
    {

        [Test]
        public void TestingMinGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeMath(1);
            student.AddGradeMath(2);
            student.AddGradeMath(6);
            student.AddGradeMath(2);
            student.AddGradeMath(4);

            //act
            var statistics = student.GetStatisticsMath();

            //assert
            Assert.AreEqual(1, statistics.Min);

        }
        [Test]
        public void TestingMaxGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeMath(1);
            student.AddGradeMath(2);
            student.AddGradeMath(6);
            student.AddGradeMath(2);
            student.AddGradeMath(4);

            //act
            var statistics = student.GetStatisticsMath();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void TestingAverageGradeMath()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeMath(1);
            student.AddGradeMath(2);
            student.AddGradeMath(6);
            student.AddGradeMath(2);
            student.AddGradeMath(4);

            //act
            var statistics = student.GetStatisticsMath();

            //assert
            Assert.AreEqual(3, statistics.Average);

        }
    }
    public class StudentInMemoryTestsPolish
    {

        [Test]
        public void TestingMinGradePolish()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradePolish(1);
            student.AddGradePolish(2);
            student.AddGradePolish(6);
            student.AddGradePolish(2);
            student.AddGradePolish(4);

            //act
            var statistics = student.GetStatisticsPolish();

            //assert
            Assert.AreEqual(1, statistics.Min);

        }
        [Test]
        public void TestingMaxGradePolish()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradePolish(1);
            student.AddGradePolish(2);
            student.AddGradePolish(6);
            student.AddGradePolish(2);
            student.AddGradePolish(4);

            //act
            var statistics = student.GetStatisticsPolish();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void TestingAverageGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradePolish(1);
            student.AddGradePolish(2);
            student.AddGradePolish(6);
            student.AddGradePolish(2);
            student.AddGradePolish(4);

            //act
            var statistics = student.GetStatisticsPolish();

            //assert
            Assert.AreEqual(3, statistics.Average);

        }
    }
    public class StudentInMemoryTestsEnglish
    {

        [Test]
        public void TestingMinGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeEnglish(1);
            student.AddGradeEnglish(2);
            student.AddGradeEnglish(6);
            student.AddGradeEnglish(2);
            student.AddGradeEnglish(4);

            //act
            var statistics = student.GetStatisticsEnglish();

            //assert
            Assert.AreEqual(1, statistics.Min);

        }
        [Test]
        public void TestingMaxGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeEnglish(1);
            student.AddGradeEnglish(2);
            student.AddGradeEnglish(6);
            student.AddGradeEnglish(2);
            student.AddGradeEnglish(4);

            //act

            var statistics = student.GetStatisticsEnglish();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void TestingAverageGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeEnglish(1);
            student.AddGradeEnglish(2);
            student.AddGradeEnglish(6);
            student.AddGradeEnglish(2);
            student.AddGradeEnglish(4);

            //act
            var statistics = student.GetStatisticsEnglish();

            //assert
            Assert.AreEqual(3, statistics.Average);

        }
    }
    public class StudentInMemoryTestsIT
    {

        [Test]
        public void TestingMinGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeIT(1);
            student.AddGradeIT(2);
            student.AddGradeIT(6);
            student.AddGradeIT(2);
            student.AddGradeIT(4);

            //act
            var statistics = student.GetStatisticsIT();

            //assert
            Assert.AreEqual(1, statistics.Min);

        }
        [Test]
        public void TestingMaxGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeIT(1);
            student.AddGradeIT(2);
            student.AddGradeIT(6);
            student.AddGradeIT(2);
            student.AddGradeIT(4);

            //act

            var statistics = student.GetStatisticsIT();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void TestingAverageGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradeIT(1);
            student.AddGradeIT(2);
            student.AddGradeIT(6);
            student.AddGradeIT(2);
            student.AddGradeIT(4);

            //act
            var statistics = student.GetStatisticsIT();

            //assert
            Assert.AreEqual(3, statistics.Average);

        }
    }
    public class StudentInMemoryTestsPhysics
    {

        [Test]
        public void TestingMinGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradePhysics(1);
            student.AddGradePhysics(2);
            student.AddGradePhysics(6);
            student.AddGradePhysics(2);
            student.AddGradePhysics(4);

            //act
            var statistics = student.GetStatisticsPhysics();

            //assert
            Assert.AreEqual(1, statistics.Min);

        }
        [Test]
        public void TestingMaxGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradePhysics(1);
            student.AddGradePhysics(2);
            student.AddGradePhysics(6);
            student.AddGradePhysics(2);
            student.AddGradePhysics(4); ;

            //act

            var statistics = student.GetStatisticsPhysics();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void TestingAverageGrade()
        {
            //arrange
            var student = new StudentInMemory("Kasia", "Nowak", "15");
            student.AddGradePhysics(1);
            student.AddGradePhysics(2);
            student.AddGradePhysics(6);
            student.AddGradePhysics(2);
            student.AddGradePhysics(4);

            //act
            var statistics = student.GetStatisticsPhysics();

            //assert
            Assert.AreEqual(3, statistics.Average);

        }
    }
}
