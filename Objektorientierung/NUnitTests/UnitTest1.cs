using Objektorientierung;

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
            myTierheim.AddAnimal(new Cat("Catt", "black", new DateTime(2008, 11, 11)));
            myTierheim.AddAnimal(new Dog("Dogg", "white", new DateTime(2023, 11, 11)));
            Assert.IsTrue(myTierheim.GetAnimalCount() == 2);
        }
    }
}