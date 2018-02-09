using EvercraftSrc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvercraftTest
{
    [TestClass]
    public class CharacterTest
    {   
        [TestMethod]
        public void CharacterHasAName()
        {
            var expectedName = "Bob";
            Character testCharacter = new Character("Bob");
            Assert.AreEqual(expectedName, testCharacter.name);
        }

        [TestMethod]
        public void CharacterHasGoodAlignment()
        {
            var expectedAlignment = Character.Alignment.Good;
            Character testCharacter = new Character("GoodBob", expectedAlignment);
            Assert.AreEqual(expectedAlignment, testCharacter.alignment);
        }

        [TestMethod]
        public void CharacterHasEvilAlignment()
        {
            var expectedAlignment = Character.Alignment.Evil;
            Character testCharacter = new Character("EvilBob", expectedAlignment);
            Assert.AreEqual(expectedAlignment, testCharacter.alignment);
        }
        
        [TestMethod]
        public void CharacterHasNeutralAlignment()
        {
            var expectedAlignment = Character.Alignment.Neutral;
            Character testCharacter = new Character("EvilBob", expectedAlignment);
            Assert.AreEqual(expectedAlignment, testCharacter.alignment);
        }

        [TestMethod]
        public void CharacterHasDefaultArmorClassOf10()
        {
            Character testCharacter = new Character("Bob");
            Assert.AreEqual(10, testCharacter.armorClass);
        }
    }
}