using Ingenio.CodeTest.Core;
using Ingenio.CodeTest.UnitTests.Data;
using NUnit.Framework;

namespace Ingenio.CodeTest.UnitTests
{
    [TestFixture]
    public class DataServiceTests
    {
        private DataService _dataService;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            var dataLoader = new DataLoander();
            var c = dataLoader.Load(TestData.SampleCase);
            _dataService = new DataService(c);
        }

        [Test]
        [TestCase(201, 200, "Computer", "Teaching")]
        [TestCase(202, 201, "Operating System", "Teaching")]
        public void GetItemWithKeywordByCategoryIdTest(int categoryId, int expectedParentCategoryId, string expectedName, string expectedKeywords)
        {
            var item = _dataService.GetItemWithKeywordByCategoryId(categoryId);
            Assert.That(item.ParentCategoryId, Is.EqualTo(expectedParentCategoryId));
            Assert.That(item.Name, Is.EqualTo(expectedName));
            Assert.That(item.Keywords, Is.EqualTo(expectedKeywords));
        }

        [Test]
        [TestCase(2, new[] {101, 102, 201})]
        [TestCase(3, new[] {103, 109, 202})]
        public void GetCategoriesByLevelTest(int level, int[] expectedCategories)
        {
            var categories = _dataService.GetCategoriesByLevel(level);
            Assert.That(categories, Is.EquivalentTo(expectedCategories));

        }

    }
}