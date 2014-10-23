using Ingenio.CodeTest.Core;
using Ingenio.CodeTest.Core.Data;
using Ingenio.CodeTest.UnitTests.Data;
using NUnit.Framework;

namespace Ingenio.CodeTest.UnitTests
{
    [TestFixture]
    public class DataLoanderTests
    {
        private DataLoander _dataLoander;
        private ItemEqualityComparer _itemEqualityComparer = new ItemEqualityComparer();



        [TestFixtureSetUp]
        public void SetUp()
        {
            _dataLoander = new DataLoander();
        }

        [Test]
        public void LoadTest()
        {
            ItemContainer itemContainer = _dataLoander.Load(TestData.Case01);
            Assert.That(itemContainer,Is.Not.Null);
            Assert.That(itemContainer.Items, Is.Not.Null);
            Assert.That(itemContainer.Items.Length, Is.EqualTo(2));

            var expected = new[]
            {
                new Item {CategoryId = 100, ParentCategoryId = -1, Name = "Business", Keywords = "Money"},
                new Item {CategoryId = 200, ParentCategoryId = -1, Name = "Tutoring", }
            };

            Assert.That(itemContainer.Items, Is.EquivalentTo(expected).Using(_itemEqualityComparer));
        }
    }
}