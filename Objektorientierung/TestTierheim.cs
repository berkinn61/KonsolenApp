using _Objektorientierung;
 
namespace TestTierheim
{
   public class TestTierheim
    {
        [SetUp]
        public void Setup()
        {
        }
 
        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            var myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat("Catt", "black", new DateTime(208, 11, 11)));
            myTierheim.AddAnimal(new Dog("Dogg", "white", new DateTime(2023, 11, 11)));
            Assert.IsTrue(myTierheim.GetAnimalCount() == 2);
        }
 
        [Test]
        public void GetAverageAge_AddAnimals_ReturnsCorrectAverageAge()
        {
            var myTierheim = new Tierheim();
 
            myTierheim.AddAnimal(new Cat("OlderCat", "black", new DateTime(2015, 1, 1))); // 9 Jahre
            myTierheim.AddAnimal(new Dog("YoungerDog", "white", new DateTime(2020, 1, 1))); // 4 Jahre
 
            double averageAge = myTierheim.GetAverageAge();
 
            Assert.AreEqual(6.5, averageAge, 0.01, "Das Durchschnittsalter sollte 6.5 Jahre betragen.");
        }
    }
}