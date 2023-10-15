//namespace StudentJournal.Test
//{
//    public class EmployeeInMemoryTests
//    {

//        [Test]
//        public void TestMinGrade()
//        {
//            //arrange
//            var employee1 = new EmployeeInMemory("Marek", "Kowalski");
//            employee1.AddGrade(6);
//            employee1.AddGrade(4);
//            employee1.AddGrade(3);
//            employee1.AddGrade(7);


//            //act
//            var statstic = employee1.GetStatistic();

//            //assert
//            Assert.AreEqual(3, statstic.Min);

//        }


//        [Test]
//        public void TestMaxGrade()
//        {
//            //arrange
//            var employee1 = new EmployeeInMemory("Kasia", "Nowak");
//            employee1.AddGrade(6);
//            employee1.AddGrade(4);
//            employee1.AddGrade(3);
//            employee1.AddGrade(7);

//            //act
//            var statstic = employee1.GetStatistic();

//            //assert
//            Assert.AreEqual(7, statstic.Max);

//        }


//        [Test]
//        public void TestAverageGrade()
//        {
//            //arrange
//            var employee1 = new EmployeeInMemory("Kasia", "Nowak");
//            employee1.AddGrade(6);
//            employee1.AddGrade(4);
//            employee1.AddGrade(3);
//            employee1.AddGrade(7);

//            //act
//            var statstic = employee1.GetStatistic();

//            //assert
//            Assert.AreEqual(5, statstic.Average);

//        }

//        [Test]
//        public void TestAverageLettterGrade()
//        {
//            //arrange
//            var employee1 = new EmployeeInMemory("Kasia", "Nowak");
//            employee1.AddGrade(6);
//            employee1.AddGrade(4);
//            employee1.AddGrade(3);
//            employee1.AddGrade(7);

//            //act
//            var statstic = employee1.GetStatistic();

//            //assert
//            Assert.AreEqual('E', statstic.AvargeLetter);

//        }

//    }
//}